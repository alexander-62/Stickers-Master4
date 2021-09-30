using System;
using Stickers.Core.Services;
using Stickers.Data.Model.Views;
using Stickers.WinForms.OrderForms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Data.Entities;
using Stickers.Core.Utilities;

namespace Stickers.WinForms.ArchiveForms
{
    public partial class ArchiveForm : Form
    {
        private readonly OrdersService _ordersService;
        private readonly BusinessClientsService _clientsService;
        private readonly FilmService _filmService;
        private List<OrderView> _orders;
        private List<OrderView> _filteredOrders;
        private readonly User _currentUser;

        public ArchiveForm(User currentUser)
        {
            _ordersService = new OrdersService();
            _currentUser = currentUser;
            _clientsService = new BusinessClientsService();
            _filmService = new FilmService();
            InitializeComponent();
            _orders = _ordersService.GetArchivedOrderViews();
            _filteredOrders = _orders;
            CreateOrdersTable();
        }

        private void CreateOrdersTable()
        {
            archiveOrdersGrid.DataSource = null;
            archiveOrdersGrid.AutoGenerateColumns = false;
            archiveOrdersGrid.Columns.Clear();
            archiveOrdersGrid.DataSource = _filteredOrders;

            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Номер заказа"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrdersCount", "Количество макетов"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderDate", "Дата заказа"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("DeliveryDate", "Дата доставки"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("InsertedBy", "Заказ заполнил"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("ClientName", "Имя клиента"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Comment", "Комментарий"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("TrackIdentifier", "Трек-номер"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Status", "Статус"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("StickersCost", "Цена стикеров"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("DeliveryCost", "Цена доставки"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("OrderCost", "Сумма заказа"));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("IsUrgent", "Срочность", true));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("IsPayed", "Оплачен", true));
            archiveOrdersGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaymentMethod", "Метод оплаты"));

            Type dgvType = archiveOrdersGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(archiveOrdersGrid, true, null);
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

            lblOrdersTotal.Text = $"Всего заказов: {_filteredOrders.Count}";
            lblLayoutsTotal.Text = $"Всего макетов: {layoutsCount}";
            lblPaperTotal.Text = $"Всего листов: {papersCount}";
            lblPlotteringLength.Text = $"Всего резки: {cuttingLength}";
            lblPrintArea.Text = $"Метров печати: {printingArea}";
            lblLaminationArea.Text = $"Метров ламинации: {laminationArea}";
            lblCostTotal.Text = $"Общая стоимость заказов: {orderCostSum}";
        }

        private void FilterOrdersEvent(object sender, EventArgs e)
        {
            FilterOrders();
        }

        private void FilterOrders()
        {
            var startDate = orderDateFromPicker.Checked ? orderDateFromPicker.Value : (DateTime?)null;
            var endDate = orderDateTillPicker.Checked ? orderDateTillPicker.Value : (DateTime?)null;
            var deliveryStartDate = deliveryDateFromPicker.Checked ? deliveryDateFromPicker.Value : (DateTime?)null;
            var deliveryEndDate = deliveryDateTillPicker.Checked ? deliveryDateTillPicker.Value : (DateTime?)null;

            _filteredOrders = _orders
                .Where(x => x.ClientName.Contains(txtClientName.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            if (int.TryParse(txtArchiveOrderIdFilter.Text.Trim(), out _))
            {
                _filteredOrders = _filteredOrders
                    .Where(x => x.Id.ToString().Contains(txtArchiveOrderIdFilter.Text.Trim())).ToList();
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

        private void ArchiveOrdersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && archiveOrdersGrid.Rows.Count > e.RowIndex)
            {
                var id = (int)archiveOrdersGrid.Rows[e.RowIndex].Cells[0].Value;
                var orderFullView = _ordersService.GetOrderFullViewById(id);
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ для просмотра.");
                }
                else
                {
                    var form = new OrderForm(_clientsService.GetClients(), _filmService.GetFilms(), _currentUser, orderFullView, true);
                    form.Show();
                }
            }
        }
    }
}
