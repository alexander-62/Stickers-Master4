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
using Stickers.WinForms.OrderForms;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private List<OrderItemView> _filteredOrderItemsForDesigner;
        private void CreateLayoutsTable()
        {
            layoutsGrid.DataSource = null;
            layoutsGrid.AutoGenerateColumns = false;
            layoutsGrid.Columns.Clear();
            layoutsGrid.DataSource = _filteredOrderItemsForDesigner;

            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderId", "Номер заказа"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("ConfirmedDate", "Дата подтверждения заказа"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("ApproximalDeliveryDate", "Желаемая дата поставки"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Название макета"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Status", "Статус макета"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("ContourDrawnBy", "Контур нарисовал"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperParameters", "Параметры листа"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CuttingType", "Тип резки"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CuttingLength", "Длина резки"));
            layoutsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CommentForDesigner", "Комментарий"));
            layoutsGrid.Columns[0].Visible = false;

            Type dgvType = layoutsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(layoutsGrid, true, null);

            CalculateLayoutStatistics();
            PaintLayoutRows();
        }

        private void PaintLayoutRows()
        {
            var previousOrderId = 0;
            var previousColor = Color.White;
            var currentColor = Color.Bisque;
            foreach (DataGridViewRow row in layoutsGrid.Rows)
            {
                var orderId = (int)row.Cells[1].Value;
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

        private void CalculateLayoutStatistics()
        {
            var averagePlottingLength = _filteredOrderItemsForDesigner.Any() ? Math.Round(_filteredOrderItemsForDesigner.Average(x => x.CuttingLength), 2) : 0m;
            var averagePaperLength = _filteredOrderItemsForDesigner.Any() ? Math.Round(_filteredOrderItemsForDesigner.Average(x => x.PaperLength), 2) : 0m;
            var averagePaperWidth = _filteredOrderItemsForDesigner.Any() ? Math.Round(_filteredOrderItemsForDesigner.Average(x => x.PaperWidth), 2) : 0m;
            var times = new List<TimeSpan>();
            var workReports = _workReportService.GetReportsByWorkType(WorkType.DrawContour);
            foreach (var orderItem in _filteredOrderItemsForDesigner)
            {
                var reports = workReports.Where(x => x.OrderItemId == orderItem.Id);
                if (reports.Any())
                {
                    var report = reports.OrderByDescending(x => x.Date).First();
                    times.Add(report.Date - orderItem.CreatedDateTime);
                }
            }

            var averageTicks = times.Any() ? times.Average(x => x.Ticks) : 0;
            lblLayoutsTabLayoutsTotal.Text = $"Всего макетов: {_filteredOrderItemsForDesigner.Count}";
            lblAveragePaperParameters.Text = $"Средний размер листа: {averagePaperLength}мм * {averagePaperWidth}мм";
            lblAveragePlottingLength.Text = $"Средняя длина резки: {averagePlottingLength}";
            lblContourDrawAverageTime.Text = $"Среднее время отрисовки макета: {new TimeSpan(Convert.ToInt64(averageTicks))}";
        }

        private void InitializeLayoutFilters()
        {
            InitializeOrderIdCombobox();
            InitializeStatusForDesignerCombobox();
        }

        private void InitializeStatusForDesignerCombobox()
        {
            var orderItemStatusTypeValues = Enum.GetValues(typeof(OrderItemStatus)).Cast<OrderItemStatus>().ToList();
            var orderItemStatusValuesWithDescription = new Dictionary<OrderItemStatus, string>();
            orderItemStatusValuesWithDescription.Add((OrderItemStatus)(-1), "Любой");
            foreach (var value in orderItemStatusTypeValues)
            {
                orderItemStatusValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            statusForDesignerCombobox.DataSource = new BindingSource(orderItemStatusValuesWithDescription, null);
            statusForDesignerCombobox.DisplayMember = "Value";
            statusForDesignerCombobox.ValueMember = "Key";
            statusForDesignerCombobox.SelectedItem = statusForDesignerCombobox.Items[0];
        }

        private void InitializeOrderIdCombobox()
        {
            var orderIdItems = _orderItems.Select(x => x.OrderId.ToString()).Distinct().ToList();
            var resultItems = new List<string>();
            resultItems.Add("Любой");
            resultItems.AddRange(orderIdItems);
            orderIdForDesignerCombobox.DataSource = resultItems;
            orderIdForDesignerCombobox.SelectedItem = orderIdForDesignerCombobox.Items[0];
        }

        private void FilterOrderItemsForDesignerEvent(object sender, EventArgs e)
        {
            FilterOrderItemsForDesigner();
        }

        private void FilterOrderItemsForDesigner()
        {
            if (orderIdForDesignerCombobox.SelectedItem != null && statusForDesignerCombobox.SelectedItem != null)
            {
                var orderId = (string)orderIdForDesignerCombobox.SelectedItem;
                var orderItemStatus = ((KeyValuePair<OrderItemStatus, string>)statusForDesignerCombobox.SelectedItem).Key;

                if (orderId == "Любой")
                {
                    _filteredOrderItemsForDesigner = _orderItems;
                }
                else
                {
                    _filteredOrderItemsForDesigner = _orderItems.Where(x => x.OrderId == int.Parse(orderId)).ToList();
                }
                if ((int)orderItemStatus != -1)
                {
                    _filteredOrderItemsForDesigner = _filteredOrderItemsForDesigner.Where(x => x.Status == EnumUtility.GetEnumDescription(orderItemStatus)).ToList();
                }

                _filteredOrderItemsForDesigner = _filteredOrderItemsForDesigner.OrderBy(x => x.Id).ToList();
                CreateLayoutsTable();
            }
        }

        private void BtnLoadContour_Click(object sender, EventArgs e)
        {
            if (layoutsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию для загрузки контура.");
            }
            else
            {
                var id = (int)layoutsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    var orderItemView = _orderItems.Find(x => x.Id == id);
                    OrderItemContourForm form = new OrderItemContourForm(orderItemView.CuttingLength, orderItemView.CuttingType);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _orderFilesService.SaveOrderItemContourFiles(orderItemView.OrderId, orderItemView.Name, form.ContourFile);
                        var orderItem = _orderItemService.GetOrderItemById(orderItemView.Id);
                        orderItem.Status = OrderItemStatus.ContourDrawn;
                        orderItem.CuttingLength = form.CuttingLength;
                        orderItem.ItemCost = _orderItemCalculator.CalculateCost(orderItem, orderItem.Order.IsUrgent);
                        _orderItemService.UpdateOrderItem(orderItem);
                        var order = _ordersService.GetOrderById(orderItem.OrderId);
                        if (order.OrderItems.All(x => x.Status == OrderItemStatus.ContourDrawn))
                        {
                            order.Status = OrderStatus.ContoursDrawn;
                        }

                        _ordersService.UpdateOrder(order);
                        orderItem = _orderItemService.GetOrderItemById(orderItemView.Id);
                        CreateLayoutReport(orderItem);
                        _orderItems = _orderItemService.GetOrderItemViewsForDesigner();
                        FilterOrderItemsForDesigner();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreateLayoutReport(OrderItem item)
        {
            var report = new WorkReport
            {
                OrderId = item.OrderId,
                WorkType = WorkType.DrawContour,
                PaperCount = 0,
                PaperParameters = _paperParametersService.GetPaperParametersDescription(item.PaperLength, item.PaperWidth),
                PlotteringLength = item.CuttingLength,
                Date = DateTime.Now,
                UserId = _currentUser.Id,
                OrderItemId = item.Id
            };
            _workReportService.AddReport(report);
        }

        private void BtnContourToRevision_Click(object sender, EventArgs e)
        {
            if (layoutsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию");
            }
            else
            {
                var id = (int)layoutsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    var orderItemView = _orderItems.Find(x => x.Id == id);
                    var orderItem = _orderItemService.GetOrderItemById(orderItemView.Id);
                    var order = _ordersService.GetOrderById(orderItem.OrderId);
                    orderItem.Status = OrderItemStatus.ContourOnRevision;
                    order.Status = OrderStatus.ContoursOnRevision;
                    _orderItemService.UpdateOrderItem(orderItem);
                    _ordersService.UpdateOrder(order);
                    _orderItems = _orderItemService.GetOrderItemViewsForDesigner();
                    FilterOrderItemsForDesigner();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnOpenSources_Click(object sender, EventArgs e)
        {
            if (layoutsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию");
            }
            var id = (int)layoutsGrid.SelectedRows[0].Cells[0].Value;
            var orderItemView = _orderItems.Find(x => x.Id == id);
            _orderFilesService.OpenSourceFolder(orderItemView.OrderId);
        }

        private void BtnOpenContoursFolder_Click(object sender, EventArgs e)
        {
            if (layoutsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите позицию");
            }
            var id = (int)layoutsGrid.SelectedRows[0].Cells[0].Value;
            var orderItemView = _orderItems.Find(x => x.Id == id);
            _orderFilesService.OpenContourFolder(orderItemView.OrderId, false);
        }
    }
}
