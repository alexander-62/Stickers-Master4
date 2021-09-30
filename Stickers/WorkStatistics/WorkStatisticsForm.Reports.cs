using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Stickers.WinForms.WorkStatistics
{
    public partial class WorkStatisticsForm
    {
        private List<WorkReportView> _reports;
        private List<WorkReportView> _filteredReports;

        private void CreateReportsTable()
        {
            workReportsGrid.DataSource = null;
            workReportsGrid.AutoGenerateColumns = false;
            workReportsGrid.Columns.Clear();
            workReportsGrid.DataSource = _filteredReports;

            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Date", "Дата"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderId", "Номер заказа"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderItemName", "Название макета"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("WorkType", "Тип работы"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperCount", "Количество листов"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperParameters", "Параметры листа"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PlotteringLength", "Длина плоттерной резки"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("UserName", "Имя работника"));
            workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("RollId", "Номер рулона"));

            //workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("", "Потраченный материал, м2"));
            //workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("", "Себестоимость материала, руб"));
            //workReportsGrid.Columns.Add(ColumnUtility.CreateTableColumn("", "Стоимость краски, руб"));

            workReportsGrid.Columns[0].Visible = false;

            Type dgvType = workReportsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(workReportsGrid, true, null);
            CalculateWorkReportStatistics();
        }

        private void CalculateWorkReportStatistics()
        {
            var laminationReports = _filteredReports.Where(x => x.WorkType == EnumUtility.GetEnumDescription(WorkType.Lamination)).ToList();
            var cutReports = _filteredReports.Where(x => x.WorkType == EnumUtility.GetEnumDescription(WorkType.Cutting)).ToList();
            var printReports = _filteredReports.Where(x => x.WorkType == EnumUtility.GetEnumDescription(WorkType.Printing)).ToList();
            var plotteringReports = _filteredReports.Where(x => x.WorkType == EnumUtility.GetEnumDescription(WorkType.Plottering)).ToList();

            var cutCount = cutReports.Sum(x => x.PaperCount);
            // тут ГАВНО надо пересчитать
            var plotteringLength = Math.Round(plotteringReports.Sum(x => x.OrderItemView?.OverallCuttingLength ?? 0), 2);
            var laminationArea = Math.Round(laminationReports.Sum(x => x.OrderItemView?.OverallLaminationArea ?? 0), 2);
            var printedArea = Math.Round(printReports.Sum(x => x.OrderItemView?.OverallPrintingArea ?? 0), 2);

            var orderIds = _filteredReports.Where(x => x.OrderId.HasValue).Select(x => x.OrderId.Value).Distinct().ToList();
            var overallCost = _ordersService.GetOverallCost(orderIds);

            lblPaperCutCount.Text = $"Всего нарезавно листов: {cutCount}";
            lblLaminatedArea.Text = $"Всего заламинировано, кв.м.: {laminationArea}";
            lblPrintedArea.Text = $"Всего напечатано кв.м.: {printedArea}";
            lblPlotteredLength.Text = $"Всего порезано на плоттере м: {plotteringLength}";
            lblWorkReportsAmount.Text = $"Всего операций: {_filteredReports.Count}";
            lblOverallCost.Text = $"Общая стоимость стикеров: {overallCost}";
        }

        private void InitializeReportFilters()
        {
            InitializeUserNameCombobox();
            InitializeWorkTypeCombobox();
        }

        private void InitializeUserNameCombobox()
        {
            if (_currentUser.UserRole == UserRole.Administrator)
            {
                var _users = _userService.GetUsers();
                var usersWithDefault = new List<User>
                {
                    new User { Id=0, Name="Не выбран" }
                };
                usersWithDefault.AddRange(_users);
                userNameCombobox.DataSource = new BindingSource(usersWithDefault, null);
                userNameCombobox.DisplayMember = "Name";
            }
            else
            {
                userNameCombobox.Enabled = false;
            }
        }

        private void InitializeWorkTypeCombobox()
        {
            var workTypeValues = Enum.GetValues(typeof(WorkType)).Cast<WorkType>().ToList();
            var workTypeValuesWithDescription = new Dictionary<WorkType, string> { { (WorkType)(-1), "Любая" } };
            foreach (var value in workTypeValues)
            {
                workTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            workTypeCombobox.DataSource = new BindingSource(workTypeValuesWithDescription, null);
            workTypeCombobox.DisplayMember = "Value";
            workTypeCombobox.ValueMember = "Key";
            workTypeCombobox.SelectedItem = workTypeCombobox.Items[0];
        }

        private void FilterReportsEvent(object sender, EventArgs e)
        {
            FilterReports();
        }

        private void FilterReports()
        {
            if (workTypeCombobox.SelectedItem != null)
            {
                var user = (User)userNameCombobox.SelectedItem;
                var startDate = startDateTimePicker.Checked ? startDateTimePicker.Value : (DateTime?)null;
                var endDate = endDateTimePicker.Checked ? endDateTimePicker.Value : (DateTime?)null;
                var deliveryStartDate = deliveryStartDatePicker.Checked ? deliveryStartDatePicker.Value : (DateTime?)null;
                var deliveryEndDate = deliveryEndDatePicker.Checked ? deliveryEndDatePicker.Value : (DateTime?)null;

                if (userNameCombobox.Enabled && user.Id != 0)
                {
                    _filteredReports = _reports.Where(x => x.UserName == user.Name).ToList();
                }
                else
                {
                    _filteredReports = _reports;
                }

                if (int.TryParse(txtWorkStatisticsOrderIdFilter.Text.Trim(), out _))
                {
                    _filteredReports = _filteredReports
                        .Where(x => x.OrderId.ToString().Contains(txtWorkStatisticsOrderIdFilter.Text.Trim())).ToList();
                }

                var workType = ((KeyValuePair<WorkType, string>)workTypeCombobox.SelectedItem).Value;

                if (workType != "Любая")
                {
                    _filteredReports = _filteredReports.Where(x => x.WorkType == workType).ToList();
                }

                if (startDate != null)
                {
                    startDate = DateUtility.GetZeroTimeDate(startDate.Value);
                    _filteredReports = _filteredReports.Where(x => x.Date >= startDate.Value).ToList();
                }

                if (endDate != null)
                {
                    endDate = DateUtility.GetAlmostMidnightDate(endDate.Value);
                    _filteredReports = _filteredReports.Where(x => x.Date <= endDate.Value).ToList();
                }

                if (deliveryStartDate != null || deliveryEndDate != null)
                {
                    var orderIds = _ordersService.GetOrderIdsDeliveredInBetween(deliveryStartDate, deliveryEndDate);
                    _filteredReports = _filteredReports.Where(x => x.OrderId.HasValue && orderIds.Contains(x.OrderId.Value)).ToList();
                }

                _filteredReports = _filteredReports.OrderBy(x => x.Id).ToList();
                CreateReportsTable();
            }
        }
    }
}
