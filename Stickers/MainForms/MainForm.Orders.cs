using System;
using System.Collections.Generic;
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
        private List<OrderView> _orders;
        private List<OrderView> _filteredOrders;
        private void CreateOrdersTable()
        {
            ordersGrid.DataSource = null;
            ordersGrid.AutoGenerateColumns = false;
            ordersGrid.Columns.Clear();
            ordersGrid.DataSource = _filteredOrders;

            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Номер заказа"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrdersCount", "Количество макетов"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderDate", "Дата заказа"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("InsertedBy", "Заказ заполнил"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("ApproximalDeliveryDate", "Желаемая дата доставки"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("DaysFromConfirmation", "Дней с момента согласования"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("ClientName", "Имя клиента"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Comment", "Комментарий"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Status", "Статус"));
            ordersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("StickersCost", "Цена стикеров"));
            ordersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("DeliveryCost", "Цена доставки"));
            ordersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("OrderCost", "Сумма заказа"));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("IsUrgent", "Срочность", true));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("IsPayed", "Оплачен", true));
            ordersGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaymentMethod", "Метод оплаты"));

            Type dgvType = ordersGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
              BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(ordersGrid, true, null);
            CalculateOrderStatistics();
        }

        private void CalculateOrderStatistics()
        {
            var layoutsCount = Math.Round((decimal)_filteredOrders.Sum(x => x.OrderItems.Count), 2);
            var papersCount = Math.Round((decimal)_filteredOrders.Sum(x => x.OrderItems.Sum(o => o.PaperCount)), 2);
            var cuttingLength = Math.Round(_filteredOrders.Sum(x => x.OrderItems.Sum(o => o.OverallCuttingLength)), 2);
            var printingArea = Math.Round(_filteredOrders.Sum(x => x.OrderItems.Sum(o => o.OverallPrintingArea)), 2);
            var laminationArea = Math.Round(_filteredOrders.Sum(x => x.OrderItems.Sum(o => o.OverallLaminationArea)), 2);
            var orderCostSum = Math.Round(_filteredOrders.Sum(x => x.OrderCost), 2);

            lblOrdersCount.Text = $"Всего заказов: {_filteredOrders.Count}";
            lblLayoutsCount.Text = $"Всего макетов: {layoutsCount}";
            lblPaperCount.Text = $"Всего листов: {papersCount}";
            lblPlotting.Text = $"Всего резки: {cuttingLength}";
            lblPrintingArea.Text = $"Метров печати: {printingArea}";
            lblLaminationArea.Text = $"Метров ламинации: {laminationArea}";
            lblOrderSum.Text = $"Общая стоимость заказов: {orderCostSum}";
        }

        private void InitializeOrderFilters()
        {
            InitializePaymentCombobox();
            InitializeOrderStatusListBox();
            InitializeUrgencyOrderFilterCombobox();
        }

        private void InitializeUrgencyOrderFilterCombobox()
        {
            var options = new Dictionary<int, string>();
            options.Add(-1, "Любая");
            options.Add(0, "Не срочные");
            options.Add(1, "Срочные");

            orderUrgencyFilterCombobox.DataSource = new BindingSource(options, null);
            orderUrgencyFilterCombobox.DisplayMember = "Value";
            orderUrgencyFilterCombobox.ValueMember = "Key";
            orderUrgencyFilterCombobox.SelectedItem = orderUrgencyFilterCombobox.Items[0];
        }

        private void InitializeOrderStatusListBox()
        {
            var orderStatusTypeValues = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
            var orderStatusValuesWithDescription = new Dictionary<OrderStatus, string>();
            orderStatusValuesWithDescription.Add((OrderStatus)(-1), "Любой");
            foreach(var value in orderStatusTypeValues)
            {
                orderStatusValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            orderStatusListBox.DataSource = new BindingSource(orderStatusValuesWithDescription, null);
            orderStatusListBox.DisplayMember = "Value";
            orderStatusListBox.ValueMember = "Key";
        }

        private void InitializePaymentCombobox()
        {
            paymentComboBox.DataSource = new[] { "Любая", "Оплачен", "Не оплачен" };
            paymentComboBox.SelectedItem = paymentComboBox.Items[0];
        }

        private void FilterOrdersEvent(object sender, EventArgs e)
        {
            FilterOrders();
        }

        private void FilterOrders()
        {
            if (paymentComboBox.SelectedItem != null && orderUrgencyFilterCombobox.SelectedItem != null)
            {
                _filteredOrders = _orders
                    .Where(x => x.ClientName.Contains(txtClientNameFilter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
                if (!string.IsNullOrEmpty(txtOrderInsertedFilter.Text))
                {
                    _filteredOrders = _filteredOrders
                    .Where(x => x.InsertedBy != null && x.InsertedBy.Contains(txtOrderInsertedFilter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
                }

                var orderStatuses = new List<OrderStatus>();
                foreach (KeyValuePair<OrderStatus, string> item in orderStatusListBox.SelectedItems)
                {
                    orderStatuses.Add(item.Key);
                }
                var payment = (string)paymentComboBox.SelectedItem;
                var urgency = ((KeyValuePair<int, string>)orderUrgencyFilterCombobox.SelectedItem).Key;
                var startDate = orderStartDatePicker.Checked ? orderStartDatePicker.Value : (DateTime?)null;
                var endDate = orderEndDatePicker.Checked ? orderEndDatePicker.Value : (DateTime?)null;
                var deliveryStartDate = orderDeliveryStartDatePicker.Checked ? orderDeliveryStartDatePicker.Value : (DateTime?)null;
                var deliveryEndDate = orderDeliveryEndDatePicker.Checked ? orderDeliveryEndDatePicker.Value : (DateTime?)null;

                if (int.TryParse(txtOrdersOrderIdFilter.Text.Trim(), out _))
                {
                    _filteredOrders = _filteredOrders
                        .Where(x => x.Id.ToString().Contains(txtOrdersOrderIdFilter.Text.Trim())).ToList();
                }
                if (!orderStatuses.Contains((OrderStatus)(-1)))
                {
                    _filteredOrders = _filteredOrders.Where(x => orderStatuses.Exists(s => x.Status == EnumUtility.GetEnumDescription(s))).ToList();
                }
                if (payment != "Любая")
                {
                    if (payment == "Оплачен")
                    {
                        _filteredOrders = _filteredOrders.Where(x => x.IsPayed).ToList();
                    }
                    else
                    {
                        _filteredOrders = _filteredOrders.Where(x => !x.IsPayed).ToList();
                    }
                }
                if (urgency != -1)
                {
                    _filteredOrders = _filteredOrders.Where(x => x.IsUrgent == (urgency != 0)).ToList();
                }
                if (startDate != null)
                {
                    startDate = DateUtility.GetZeroTimeDate(startDate.Value);
                    _filteredOrders = _filteredOrders.Where(x => x.OrderDate >= startDate.Value).ToList();
                }

                if (endDate != null)
                {
                    endDate = DateUtility.GetAlmostMidnightDate(endDate.Value);
                    _filteredOrders = _filteredOrders.Where(x => x.OrderDate <= endDate.Value).ToList();
                }

                if (deliveryStartDate != null)
                {
                    deliveryStartDate = DateUtility.GetZeroTimeDate(deliveryStartDate.Value);
                    _filteredOrders = _filteredOrders.Where(x => x.DeliveryDate.HasValue && x.DeliveryDate.Value >= deliveryStartDate.Value).ToList();
                }

                if (deliveryEndDate != null)
                {
                    deliveryEndDate = DateUtility.GetAlmostMidnightDate(deliveryEndDate.Value);
                    _filteredOrders = _filteredOrders.Where(x => x.DeliveryDate.HasValue && x.DeliveryDate.Value <= deliveryEndDate.Value).ToList();
                }

                _filteredOrders = _filteredOrders.OrderBy(x => x.Id).ToList();
                CreateOrdersTable();
            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            var form = new OrderForm(_businessClientsService.GetClients(), _filmService.GetFilms(), _currentUser);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Order order = new Order
                {
                    OrderDate = DateTime.Now,
                    ApproximalDeliveryDate = form.ApproximalDeliveryDate,
                    IsPayed = false,
                    PaymentMethod = form.PaymentMethod,
                    IsUrgent = form.IsUrgent,
                    Status = form.OrderItems.All(x => x.Status == OrderItemStatus.ContourDrawn)
                    ? OrderStatus.ContoursDrawn : OrderStatus.NotStarted,
                    ClientId = form.Client.Id,
                    DeliveryAddress = form.DeliveryAddress,
                    ReceiverCredentials = form.ReceiverCredentials,
                    PostIndex = form.PostIndex,
                    DeliveryType = form.DeliveryType,
                    DeliveryCost = 0,
                    IsArchived = false,
                    Comment = form.Comment,
                    OrderItems = form.OrderItems,
                    InsertedBy = _currentUser.Name,
                };
                var newOrder = _ordersService.AddOrder(order);
                _orders.Add(newOrder);
                _orderFilesService.SaveOrderSourceFiles(newOrder.Id, form.OrderItemsSourceFiles);
                foreach(var item in order.OrderItems)
                {
                    if (form.OrderItemsContourFiles.ContainsKey(item.Name))
                    {
                        _orderFilesService.SaveOrderItemContourFiles(newOrder.Id, item.Name, form.OrderItemsContourFiles[item.Name]);
                        CreateLayoutReport(item);
                    }
                }

                var workReport = new WorkReport
                {
                    UserId = _currentUser.Id,
                    Date = DateTime.Now,
                    OrderId = newOrder.Id,
                    WorkType = WorkType.OrderInsert
                };
                _workReportService.AddReport(workReport);
                _filteredOrders = _orders;
                FilterOrders();
            }
        }

        private void BtnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
            else
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _ordersService.DeleteOrder(id);
                    var orderRemoved = _orders.Find(x => x.Id == id);
                    _orders.Remove(orderRemoved);
                    _orderFilesService.DeleteOrderFolder(id);
                    _filteredOrders = _orders;
                    FilterOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEditOrder_Click(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для изменения.");
            }
            else
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                var orderFullView = _ordersService.GetOrderFullViewById(id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для изменения.");
                }
                else
                {
                    var form = new OrderForm(_businessClientsService.GetClients(), _filmService.GetFilms(), _currentUser, orderFullView);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var order = _ordersService.GetOrderById(id);

                        order.ApproximalDeliveryDate = form.ApproximalDeliveryDate;
                        order.IsUrgent = form.IsUrgent;
                        order.ClientId = form.Client.Id;
                        order.DeliveryAddress = form.DeliveryAddress;
                        order.PostIndex = form.PostIndex;
                        order.ReceiverCredentials = form.ReceiverCredentials;
                        order.DeliveryType = form.DeliveryType;
                        order.PaymentMethod = form.PaymentMethod;
                        order.OrderItems = form.OrderItems;
                        order.Comment = form.Comment;
                        if(order.IsPayed != form.IsPayed)
                        {
                            if (form.IsPayed)
                            {
                                order.IsPayed = true;
                                var report = new WorkReport
                                {
                                    UserId = _currentUser.Id,
                                    OrderId = order.Id,
                                    Date = DateTime.Now,
                                    WorkType = WorkType.CheckPayment,
                                };
                                _workReportService.AddReport(report);
                            }
                            else
                            {
                                order.IsPayed = false;
                                var report = _workReportService
                                    .GetReportsForOrder(order.Id)
                                    .FirstOrDefault(x => x.WorkType == WorkType.CheckPayment);
                                if (report != null)
                                {
                                    _workReportService.DeleteReport(report.Id);
                                }
                            }
                        }
                        var newOrderView = _ordersService.UpdateOrder(order);
                        _orders.Remove(orderView);
                        _orders.Add(newOrderView);
                        _orderFilesService.SaveOrderSourceFiles(order.Id, form.OrderItemsSourceFiles);
                        foreach (var item in order.OrderItems)
                        {
                            if (form.OrderItemsContourFiles.ContainsKey(item.Name))
                            {
                                _orderFilesService.SaveOrderItemContourFiles(order.Id, item.Name, form.OrderItemsContourFiles[item.Name]);
                                CreateLayoutReport(item);
                            }
                        }
                        _filteredOrders = _orders;
                        FilterOrders();
                    }
                }
            }
        }

        private void BtnArchiveOrder_Click(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для архивации.");
            }
            else
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для архивации.");
                }
                else
                {
                    try
                    {
                        var order = _ordersService.GetOrderById(id);
                        _orderFilesService.ArchiveOrder(id);
                        order.IsArchived = true;
                        _ordersService.UpdateOrder(order);
                        _orders.Remove(orderView);
                        _filteredOrders = _orders;
                        FilterOrders();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void OrdersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count > 0)
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                btnEditOrder.Enabled =
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.NotStarted) ||
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.ContoursDrawn) ||
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.ContoursOnRevision);
                btnConfirmOrder.Enabled =
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.ContoursDrawn) ||
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.ContoursOnRevision);
                btnUnconfirmOrder.Enabled =
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.ReadyForProduction);
                btnArchiveOrder.Enabled =
                    orderView?.Status == EnumUtility.GetEnumDescription(OrderStatus.Delivered) &&
                    orderView.IsPayed;

                var order = _ordersService.GetOrderFullViewById(id);
                if (order != null)
                {
                    lblOrderInsertInfo.Text = $"Заказ внесен: {order.InsertedBy} {order.InsertedDate?.ToString("dd/MM/yyyy")}";
                    lblOrderConfirmInfo.Text = $"Заказ согласован: {order.ConfirmedBy} {order.ConfirmedDate?.ToString("dd/MM/yyyy")}";
                    lblOrderDoneDate.Text = $"Заказ изготовлен: {order.OrderDoneDate?.ToString("dd/MM/yyyy")}";
                    lblOrderTrackNumber.Text = $"Трэк номер: {order.TrackIdentifier}";
                    lblPaymentCheckInfo.Text = $"Оплата отмечена: {order.PaymentCheckedBy} {order.PaymentCheckedDate?.ToString("dd/MM/yyyy")}";
                    lblDeliveryDate.Text = $"Дата отправки: {order.DeliveryDate?.ToString("dd/MM/yyyy")}";
                }
                else
                {
                    lblOrderInsertInfo.Text = $"Заказ внесен:";
                    lblOrderConfirmInfo.Text = $"Заказ согласован:";
                    lblOrderDoneDate.Text = $"Заказ изготовлен:";
                    lblOrderTrackNumber.Text = $"Трэк номер:";
                    lblPaymentCheckInfo.Text = $"Оплата отмечена:";
                    lblDeliveryDate.Text = $"Дата отправки:";
                }
            }
        }

        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ для подтверждения.");
            }
            else
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для подтверждения.");
                }
                else
                {
                    var order = _ordersService.GetOrderById(id);
                    order.Status = OrderStatus.ReadyForProduction;
                    order.ConfirmedDate = DateTime.Now;
                    foreach (var item in order.OrderItems)
                    {
                        item.Status = OrderItemStatus.ReadyForProduction;
                    }

                    var newOrderView = _ordersService.UpdateOrder(order);
                    _orders.Remove(orderView);
                    _orders.Add(newOrderView);
                    _filteredOrders = _orders;
                    var workReport = new WorkReport
                    {
                        UserId = _currentUser.Id,
                        Date = DateTime.Now,
                        OrderId = newOrderView.Id,
                        WorkType = WorkType.OrderConfirmation
                    };
                    _workReportService.AddReport(workReport);
                    FilterOrders();
                }
            }
        }

        private void BtnUnconfirmOrder_Click(object sender, EventArgs e)
        {
            if (ordersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите заказ.");
            }
            else
            {
                var id = (int)ordersGrid.SelectedRows[0].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для.");
                }
                else
                {
                    var order = _ordersService.GetOrderById(id);
                    order.Status = OrderStatus.ContoursDrawn;
                    order.ConfirmedDate = DateTime.Now;
                    foreach (var item in order.OrderItems)
                    {
                        item.Status = OrderItemStatus.ContourDrawn;
                    }

                    var newOrderView = _ordersService.UpdateOrder(order);
                    _orders.Remove(orderView);
                    _orders.Add(newOrderView);
                    _filteredOrders = _orders;
                    var workReport = new WorkReport
                    {
                        UserId = _currentUser.Id,
                        Date = DateTime.Now,
                        OrderId = newOrderView.Id,
                        WorkType = WorkType.OrderDeconfirmation,
                    };
                    _workReportService.AddReport(workReport);
                    FilterOrders();
                }
            }
        }

        private void ordersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && ordersGrid.Rows.Count > e.RowIndex)
            {
            }
        }

        private void OrdersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && ordersGrid.Rows.Count > e.RowIndex)
            {
                var id = (int)ordersGrid.Rows[e.RowIndex].Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                var orderFullView = _ordersService.GetOrderFullViewById(id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для изменения.");
                }
                else
                {
                    var form = new OrderForm(_businessClientsService.GetClients(), _filmService.GetFilms(), _currentUser, orderFullView, true);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var order = _ordersService.GetOrderById(id);

                        order.ApproximalDeliveryDate = form.ApproximalDeliveryDate;
                        order.IsUrgent = form.IsUrgent;
                        order.ClientId = form.Client.Id;
                        order.DeliveryAddress = form.DeliveryAddress;
                        order.PostIndex = form.PostIndex;
                        order.ReceiverCredentials = form.ReceiverCredentials;
                        order.DeliveryType = form.DeliveryType;
                        order.PaymentMethod = form.PaymentMethod;
                        order.OrderItems = form.OrderItems;
                        order.Comment = form.Comment;
                        if (order.IsPayed != form.IsPayed)
                        {
                            if (form.IsPayed)
                            {
                                order.IsPayed = true;
                                var report = new WorkReport
                                {
                                    UserId = _currentUser.Id,
                                    OrderId = order.Id,
                                    Date = DateTime.Now,
                                    WorkType = WorkType.CheckPayment,
                                };
                                _workReportService.AddReport(report);
                            }
                            else
                            {
                                order.IsPayed = false;
                                var report = _workReportService
                                    .GetReportsForOrder(order.Id)
                                    .FirstOrDefault(x => x.WorkType == WorkType.CheckPayment);
                                if (report != null)
                                {
                                    _workReportService.DeleteReport(report.Id);
                                }
                            }
                        }
                        var newOrderView = _ordersService.UpdateOrder(order);
                        _orders.Remove(orderView);
                        _orders.Add(newOrderView);
                        FilterOrders();
                    }
                }
            }
        }
    }
}
