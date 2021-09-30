using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;
using Stickers.WinForms.ProductionForms;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private List<OrderItemView> _orderItems;
        private List<OrderItemView> _filteredOrderItems;
        private List<Film> _films;

        private void CreateProductionTable(bool flag = false)
        {
            if (flag)
            {
                var _orders = _ordersService.GetOrderViews();
                foreach (var item in _filteredOrderItems)
                {
                    var res = _orders.FirstOrDefault(c => c.Id == item.OrderId);
                    if (res != null)
                    {
                        item.DaysFromConfirmation = res.DaysFromConfirmation;
                    }
                }
            }

            productionGrid.DataSource = null;
            productionGrid.AutoGenerateColumns = false;
            productionGrid.Columns.Clear();
            productionGrid.DataSource = _filteredOrderItems;

            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderId", "Номер заказа"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("DaysFromConfirmation", "Дней с момента согласования"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("ClientName", "Имя клиента"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("ApproximalDeliveryDate", "Желаемая дата поставки"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("DeliveryType", "Способ отправки"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Название макета"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("ContourDrawnBy", "Контур нарисовал"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("Film", "Пленка"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("Lamination", "Ламинация"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("CommentForProduction", "Комментарий"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperParameters", "Параметры листа"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("CuttingType", "Тип резки"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("OverallCuttingLength", "Общая длина резки"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("IsUrgent", "Срочность", true));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperCount", "Количество листов"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("PrintedCount", "Напечатано"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("LaminatedCount", "Заламинировано"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("PlotteredCount", "Порезано на плоттере"));
            productionGrid.Columns.Add(ColumnUtility.CreateTableColumn("CutCount", "Порезано на листы"));

            productionGrid.Columns[0].Visible = false;
            Type dgvType = productionGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
              BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(productionGrid, true, null);
            PaintProductionRows();
            CalculateProductionStatistics();

      
        }

        private void CalculateProductionStatistics()
        {
            var ordersCount = _filteredOrderItems.Select(x => x.OrderId).Distinct().Count();
            var layoutsCount = _filteredOrderItems.Count;
            var papersCount = _filteredOrderItems.Sum(o => o.PaperCount);
            var cuttingLength = Math.Round(_filteredOrderItems.Sum(o => o.OverallCuttingLength), 2);
            var printingArea = Math.Round(_filteredOrderItems.Sum(o => o.OverallPrintingArea), 2);
            var laminationArea = Math.Round(_filteredOrderItems.Sum(o => o.OverallLaminationArea), 2);

            lblProductionOrdersCount.Text = $"Всего заказов: {ordersCount}";
            lblProductionLayoutsCount.Text = $"Всего макетов: {layoutsCount}";
            lblProductionPaperCount.Text = $"Всего листов: {papersCount}";
            lblProductionPlotteringLength.Text = $"Всего резки: {cuttingLength}";
            lblProductionPrintMeters.Text = $"Метров печати: {printingArea}";
            lblProductionLaminationMeters.Text = $"Метров ламинации: {laminationArea}";
        }

        private void ProductionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (productionGrid.Columns[e.ColumnIndex].DataPropertyName == "PrintedCount" ||
                productionGrid.Columns[e.ColumnIndex].DataPropertyName == "LaminatedCount" ||
                productionGrid.Columns[e.ColumnIndex].DataPropertyName == "PlotteredCount" ||
                productionGrid.Columns[e.ColumnIndex].DataPropertyName == "CutCount")
            {
                int value = (int)e.Value;
                if (value == 0)
                {
                    e.Value = "-";
                    e.FormattingApplied = true;
                }
            }

            if (productionGrid.Columns[e.ColumnIndex].DataPropertyName == "LaminatedCount")
            {
                var row = productionGrid.Rows[e.RowIndex];
                var id = (int)row.Cells[0].Value;
                var orderItem = _filteredOrderItems.FirstOrDefault(x => x.Id == id);
                if(orderItem?.Lamination == EnumUtility.GetEnumDescription(Lamination.None))
                {
                    e.Value = "\u274C";
                    e.FormattingApplied = true;
                }
            }

            if (productionGrid.Columns[e.ColumnIndex].DataPropertyName == "PlotteredCount")
            {
                var row = productionGrid.Rows[e.RowIndex];
                var id = (int)row.Cells[0].Value;
                var orderItem = _filteredOrderItems.FirstOrDefault(x => x.Id == id);
                if (orderItem?.CuttingType == EnumUtility.GetEnumDescription(CuttingType.None))
                {
                    e.Value = "\u274C";
                    e.FormattingApplied = true;
                }
            }
        }

        private void PaintProductionRows()
        {
            var previousOrderId = 0;
            var previousColor = Color.White;
            var currentColor = Color.Bisque;
            foreach (DataGridViewRow row in productionGrid.Rows)
            {
                var orderId = (int) row.Cells[1].Value;
                if (orderId != previousOrderId)
                {
                    var temp = previousColor;
                    previousColor = currentColor;
                    currentColor = temp;
                    previousOrderId = orderId;
                }
                
                row.DefaultCellStyle.BackColor = currentColor;
            }
        }

        private void InitializeProductionFilters()
        {
            InitializeUrgencyFilterCombobox();
            InitializeCuttingTypeCombobox();
            InitializeLaminationTypeCombobox();
            InitializeFilmTypeCombobox();
        }

        private void InitializeUrgencyFilterCombobox()
        {
            var options = new Dictionary<int, string>();
            options.Add(-1, "Любая");
            options.Add(0, "Не срочные");
            options.Add(1, "Срочные");

            productionUrgencyFilterCombobox.DataSource = new BindingSource(options, null);
            productionUrgencyFilterCombobox.DisplayMember = "Value";
            productionUrgencyFilterCombobox.ValueMember = "Key";
            productionUrgencyFilterCombobox.SelectedItem = productionUrgencyFilterCombobox.Items[0];
        }
        private void InitializeFilmTypeCombobox()
        {
            _films = _filmService.GetFilms();
            var filmsWithDefault = new List<Film>
            {
                new Film { Id = 0, Name = "Не выбрана" }
            };
            filmsWithDefault.AddRange(_films);
            filmComboBox.DataSource = new BindingSource(filmsWithDefault, null);
            filmComboBox.DisplayMember = "Name";
        }

        private void InitializeLaminationTypeCombobox()
        {
            var laminationTypeValues = Enum.GetValues(typeof(Lamination)).Cast<Lamination>().ToList();
            var laminationTypeValuesWithDescription = new Dictionary<Lamination, string>();
            foreach (var value in laminationTypeValues)
            {
                if (value == Lamination.NotSelected)
                {
                    laminationTypeValuesWithDescription.Add(value, "Любая");
                }
                else
                {
                    laminationTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
                }
            }
            laminationComboBox.DataSource = new BindingSource(laminationTypeValuesWithDescription, null);
            laminationComboBox.DisplayMember = "Value";
            laminationComboBox.ValueMember = "Key";
            laminationComboBox.SelectedItem = laminationComboBox.Items[0];
        }

        private void InitializeCuttingTypeCombobox()
        {
            var cuttingTypeValues = Enum.GetValues(typeof(CuttingType)).Cast<CuttingType>().ToList();
            var cuttingTypeValuesWithDescription = new Dictionary<CuttingType, string>();
            foreach (var value in cuttingTypeValues)
            {
                if (value == CuttingType.NotSelected)
                {
                    cuttingTypeValuesWithDescription.Add(value, "Любой");
                }
                else
                {
                    cuttingTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
                }
            }
            cuttingTypeComboBox.DataSource = new BindingSource(cuttingTypeValuesWithDescription, null);
            cuttingTypeComboBox.DisplayMember = "Value";
            cuttingTypeComboBox.ValueMember = "Key";
            cuttingTypeComboBox.SelectedItem = cuttingTypeComboBox.Items[0];
        }

        private void FilterProductionItemsEvent(object sender, EventArgs e)
        {
            FilterProductionItems();
        }

        private void FilterProductionItems()
        {
            if (filmComboBox.SelectedItem != null && laminationComboBox.SelectedItem != null &&
                cuttingTypeComboBox.SelectedItem != null && productionUrgencyFilterCombobox != null)
            {
                var film = (Film)filmComboBox.SelectedItem;
                var lamination = ((KeyValuePair<Lamination, string>)laminationComboBox.SelectedItem).Key;
                var cuttingType = ((KeyValuePair<CuttingType, string>)cuttingTypeComboBox.SelectedItem).Key;
                var urgency = ((KeyValuePair<int, string>)productionUrgencyFilterCombobox.SelectedItem).Key;
                
                _filteredOrderItems = film.Id != 0 ?
                    _orderItems.Where(x => x.Film == film.Name).ToList() :
                    _orderItems;

                if (int.TryParse(txtProductionOrderIdFilter.Text.Trim(), out _))
                {
                    _filteredOrderItems = _filteredOrderItems
                        .Where(x => x.OrderId.ToString().Contains(txtProductionOrderIdFilter.Text.Trim())).ToList();
                }
                if (lamination != Lamination.NotSelected)
                {
                    _filteredOrderItems = _filteredOrderItems.Where(x => x.Lamination == EnumUtility.GetEnumDescription(lamination)).ToList();
                }
                if (cuttingType != CuttingType.NotSelected)
                {
                    _filteredOrderItems = _filteredOrderItems.Where(x => x.CuttingType == EnumUtility.GetEnumDescription(cuttingType)).ToList();
                }

                if (urgency != -1)
                {
                    _filteredOrderItems = _filteredOrderItems.Where(x => x.IsUrgent == (urgency != 0)).ToList();
                }

                _filteredOrderItems = _filteredOrderItems
                    .Where(x =>
                    x.ClientName.Contains(txtClientNameProductionFilter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
                _filteredOrderItems = _filteredOrderItems.OrderBy(x => x.ConfirmedDate).ToList();
                CreateProductionTable();
            }
        }

        private void BtnOpenContours_Click(object sender, EventArgs e)
        {
            var rows = productionGrid.SelectedRows;
            var films = new List<string>();
            var orderIds = new List<int>();
            foreach (DataGridViewRow row in rows)
            {
                orderIds.Add((int)row.Cells[1].Value);
                films.Add((string)row.Cells[5].Value);
            }

            if (films.All(x => x == films.First()))
            {
                _orderFilesService.OpenContourFolders(orderIds.Distinct().ToList());
            }
            else
            {
                MessageBox.Show("Выберите позиции с одинаковой пленкой");
            }
        }

        private void BtnCheckPrinting_Click(object sender, EventArgs e)
        {
            CheckWork(WorkType.Printing);
        }

        private void BtnCheckLamination_Click(object sender, EventArgs e)
        {
            CheckWork(WorkType.Lamination);
        }

        private void BtnCheckPlottering_Click(object sender, EventArgs e)
        {
            CheckWork(WorkType.Plottering);
        }

        private void BtnCheckCutting_Click(object sender, EventArgs e)
        {
            CheckWork(WorkType.Cutting);
        }

        private void CheckWork(WorkType workType)
        {
            var orderItemsIds = new List<int>();
            foreach (DataGridViewRow row in productionGrid.SelectedRows)
            {
                orderItemsIds.Add((int)row.Cells[0].Value);
            }
            var orderItems = orderItemsIds.Select(x => _orderItemService.GetOrderItemById(x)).ToList();
            if (RowsAreValid(workType, orderItems))
            {
                var rolls = GetValidRolls(workType, orderItems.First());
                var form = new CheckWorkForm(orderItems, rolls, workType);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (workType == WorkType.Printing || workType == WorkType.Lamination)
                        {
                            SaveRollExpenditure(form.Roll.Id, form.UsedMeters);
                        }

                        foreach (var pair in form.DoneLists)
                        {
                            OrderItem orderItem = _orderItemService.GetOrderItemById(pair.Key);
                            var orderItemView = _orderItems.FirstOrDefault(x => x.Id == pair.Key);
                            CheckDonePapers(orderItem, workType, pair.Value);
                            CreateWorkReport(orderItem, pair.Value, workType, form.Roll);

                            if (workType == WorkType.Printing && orderItem.Status == OrderItemStatus.ReadyForProduction)
                            {
                                orderItem.Status = OrderItemStatus.InProduction;
                                SetOrderInProduction(orderItem.OrderId);
                            }
                            if (workType == WorkType.Cutting && orderItem.CutCount == orderItem.PaperCount)
                            {
                                orderItem.Status = OrderItemStatus.Done;
                                
                            }
                            var newOrderItemView = _orderItemService.UpdateOrderItem(orderItem);
                            _orderItems.Remove(orderItemView);
                            if (newOrderItemView.Status != EnumUtility.GetEnumDescription(OrderItemStatus.Done))
                            {
                                _orderItems.Add(newOrderItemView);
                            }
                            else
                            {
                                CheckOrder(orderItem.OrderId);
                            }
                        }
                        FilterProductionItems();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите позиции с одинаковым типом");
            }
        }

        private void SaveRollExpenditure(int id, decimal usedMeters)
        {
            var roll = _rollService.GetRollById(id);
            roll.Length -= usedMeters;
            _rollService.UpdateRoll(roll);
        }

        private void CheckDonePapers(OrderItem item, WorkType workType, int papersCount)
        {
            if (workType == WorkType.Printing)
            {
                item.PrintedCount += papersCount;
            }
            else if (workType == WorkType.Lamination)
            {
                item.LaminatedCount += papersCount;
            }
            else if (workType == WorkType.Plottering)
            {
                item.PlotteredCount += papersCount;
            }
            else
            {
                item.CutCount += papersCount;
            }
        }

        private void CreateWorkReport(OrderItem item, int paperCount, WorkType workType, Roll roll)
        {
            var report = new WorkReport
            {
                OrderId = item.OrderId,
                OrderItemId = item.Id,
                PaperCount = paperCount,
                PaperParameters = _paperParametersService.GetPaperParametersDescription(item.PaperLength, item.PaperWidth),
                UserId = _currentUser.Id,
                WorkType = workType,
                Date = DateTime.Now
            };
            if (workType == WorkType.Printing || workType == WorkType.Lamination)
            {
                report.RollId = roll.Id;
            }
            if (workType == WorkType.Plottering)
            {
                report.PlotteringLength = item.CuttingLength * paperCount;
            }
            _workReportService.AddReport(report);
        }

        private void CheckOrder(int id)
        {
            var order = _ordersService.GetOrderById(id);
            if (order.OrderItems.All(x => x.Status == OrderItemStatus.Done))
            {
                order.Status = OrderStatus.ReadyForDelivery;
            }

            _ordersService.UpdateOrder(order);
        }

        private void SetOrderInProduction(int id)
        {
            var order = _ordersService.GetOrderById(id);
            if (order.Status != OrderStatus.InProduction)
            {
                order.Status = OrderStatus.InProduction;
            }

            _ordersService.UpdateOrder(order);
        }

        private List<Roll> GetValidRolls(WorkType workType, OrderItem item)
        {
            var result = new List<Roll>();
            if (workType == WorkType.Printing)
            {
                result = _rollService.GetRolls().Where(x => x.FilmId == item.FilmId).ToList();
            }
            else if (workType == WorkType.Lamination)
            {
                var laminationType = item.Lamination;
                if (laminationType == Lamination.Glossy)
                {
                    result = _rollService.GetRolls().Where(x => x.Film.Name == "Прозрачная глянцевая").ToList();
                }
                if (laminationType == Lamination.Opaque)
                {
                    result = _rollService.GetRolls().Where(x => x.Film.Name == "Прозрачная матовая").ToList();
                }
            }

            return result;
        }

        private bool RowsAreValid(WorkType workType, List<OrderItem> items)
        {
            if (workType == WorkType.Printing)
            {
                return items.All(x => x.FilmId == items.First().FilmId);
            }

            if (workType == WorkType.Lamination)
            {
                return items.All(x => x.Lamination == items.First().Lamination);
            }

            if (workType == WorkType.Plottering)
            {
                return items.All(x => x.CuttingType == items.First().CuttingType);
            }
            return true;
        }
    }
}
