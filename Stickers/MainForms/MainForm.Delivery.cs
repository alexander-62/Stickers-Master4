

using Stickers.Core.Utilities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;
using Stickers.WinForms.DeliveryForms;
using Stickers.WinForms.OrderForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private List<OrderView> _filteredDeliveryOrders;

        private void CreateDeliveryTable()
        {
            deliveryGrid.DataSource = null;
            deliveryGrid.AutoGenerateColumns = false;
            deliveryGrid.Columns.Clear();
            deliveryGrid.DataSource = _filteredDeliveryOrders;

            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Номер заказа"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("ClientName", "Имя клиента"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderDate", "Дата заказа"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("ApproximalDeliveryDate", "Желаемая дата доставки"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("DeliveryDate", "Дата отправки"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("DeliveryType", "Способ отправки"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("TrackIdentifier", "Трэк номер"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("DeliveryAddress", "Адрес"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("PostIndex", "Почтовый индекс"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("ReceiverCredentials", "ФИО Получателя"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("StickersCost", "Цена стикеров"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("DeliveryCost", "Стоимость доставки"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("OrderCost", "Сумма заказа"));
            deliveryGrid.Columns.Add(ColumnUtility.CreateTableColumn("Status", "Статус"));
            deliveryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //deliveryGrid.AutoResizeColumns();

            Type dgvType = deliveryGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(deliveryGrid, true, null);
            CalculateDeliveryStatistics();
        }

        private void CalculateDeliveryStatistics()
        {
            lblDeliveryOrdersTotal.Text = $"Всего заказов: {_filteredDeliveryOrders.Count}";
        }

        private void InitializeDeliveryFilters()
        {
            InitializeDeliveryStatusCombobox();
            InitializeDeliveryTypeCombobox();
        }

        private void InitializeDeliveryTypeCombobox()
        {
            var deliveryTypeValues = Enum.GetValues(typeof(DeliveryType)).Cast<DeliveryType>().ToList();
            var deliveryTypeValuesWithDescription = new Dictionary<DeliveryType, string>();
            deliveryTypeValuesWithDescription.Add((DeliveryType)(-1), "Любой");
            foreach (var value in deliveryTypeValues)
            {
                deliveryTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            deliveryMethodComboboxFilter.DataSource = new BindingSource(deliveryTypeValuesWithDescription, null);
            deliveryMethodComboboxFilter.DisplayMember = "Value";
            deliveryMethodComboboxFilter.ValueMember = "Key";
            deliveryMethodComboboxFilter.SelectedItem = deliveryMethodComboboxFilter.Items[0];
        }

        private void InitializeDeliveryStatusCombobox()
        {
            deliveryStatusComboboxFilter.DataSource = new[] { "Любой", "Отправлен", "Не отправлен" };
            deliveryStatusComboboxFilter.SelectedItem = deliveryStatusComboboxFilter.Items[0];
        }

        private void FilterDeliveryOrdersEvent(object sender, EventArgs e)
        {
            FilterDeliveryOrders();
        }

        private void FilterDeliveryOrders()
        {
            if (deliveryMethodComboboxFilter.SelectedItem != null && deliveryStatusComboboxFilter.SelectedItem != null)
            {
                _filteredDeliveryOrders = _orders
                    .Where(x => x.ClientName.Contains(txtDeliveryClientNameFilter.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                    .ToList();

                if (int.TryParse(txtDeliveryOrderIdFilter.Text.Trim(), out _))
                {
                    _filteredDeliveryOrders = _filteredDeliveryOrders
                        .Where(x => x.Id.ToString().Contains(txtDeliveryOrderIdFilter.Text.Trim())).ToList();
                }

                if (!string.IsNullOrEmpty(txtDeliveryTrackNumberFilter.Text))
                {
                    _filteredDeliveryOrders = _filteredDeliveryOrders
                        .Where(x => !string.IsNullOrEmpty(x.TrackIdentifier) && x.TrackIdentifier.Contains(txtDeliveryTrackNumberFilter.Text.Trim())).ToList();
                }

                var deliveryType = ((KeyValuePair<DeliveryType, string>)deliveryMethodComboboxFilter.SelectedItem).Key;
                var deliveryStatus = (string)deliveryStatusComboboxFilter.SelectedItem;
                var startDate = deliveryStartDateFilterPicker.Checked ? deliveryStartDateFilterPicker.Value : (DateTime?)null;
                var endDate = deliveryEndDateFilterPicker.Checked ? deliveryEndDateFilterPicker.Value : (DateTime?)null;

                if ((int)deliveryType != -1)
                {
                    _filteredDeliveryOrders = _filteredDeliveryOrders.Where(x => x.DeliveryType == EnumUtility.GetEnumDescription(deliveryType)).ToList();
                }
                if (deliveryStatus != "Любой")
                {
                    if (deliveryStatus == "Отправлен")
                    {
                        _filteredDeliveryOrders = _filteredDeliveryOrders.Where(x => x.DeliveryDate.HasValue).ToList();
                    }
                    else
                    {
                        _filteredDeliveryOrders = _filteredDeliveryOrders.Where(x => !x.DeliveryDate.HasValue).ToList();
                    }
                }

                if (startDate != null)
                {
                    startDate = DateUtility.GetZeroTimeDate(startDate.Value);
                    _filteredDeliveryOrders = _filteredDeliveryOrders.Where(x => x.DeliveryDate.HasValue && x.DeliveryDate.Value >= startDate.Value).ToList();
                }

                if (endDate != null)
                {
                    endDate = DateUtility.GetAlmostMidnightDate(endDate.Value);
                    _filteredDeliveryOrders = _filteredDeliveryOrders.Where(x => x.DeliveryDate.HasValue && x.DeliveryDate.Value <= endDate.Value).ToList();
                }


                _filteredDeliveryOrders = _filteredDeliveryOrders.OrderBy(x => x.Id).ToList();
                CreateDeliveryTable();
            }
        }

        private void BtnAddDeliveryInfo_Click(object sender, EventArgs e)
        {
            if (deliveryGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите заказ.");
            }
            else
            {
                var row = deliveryGrid.Rows[deliveryGrid.SelectedCells[0].RowIndex];
                var id = (int)row.Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ.");
                }
                else
                {
                    var order = _ordersService.GetOrderById(id);
                    var form = new AddDeliveryInfoForm(order.TrackIdentifier, order.DeliveryCost);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        order.DeliveryCost = form.DeliveryCost;
                        order.TrackIdentifier = form.TrackIdentifier;
                        var newOrderView = _ordersService.UpdateOrder(order);
                        _orders.Remove(orderView);
                        _orders.Add(newOrderView);
                        CreateDeliveryTable();
                    }
                }
            }
        }

        private void BtnCheckDelivery_Click(object sender, EventArgs e)
        {
            if (deliveryGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите заказ.");
            }
            else
            {
                var row = deliveryGrid.Rows[deliveryGrid.SelectedCells[0].RowIndex];
                var id = (int)row.Cells[0].Value;
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
                if (orderView == null)
                {
                    MessageBox.Show("Выберите заказ.");
                }
                else
                {
                    var order = _ordersService.GetOrderById(id);
                    if (order.Status == OrderStatus.Delivered)
                    {
                        order.Status = OrderStatus.ReadyForDelivery;
                        order.DeliveryDate = null;
                    }
                    else if (order.Status == OrderStatus.ReadyForDelivery)
                    {
                        order.Status = OrderStatus.Delivered;
                        order.DeliveryDate = DateTime.Now;
                    }

                    var newOrderView = _ordersService.UpdateOrder(order);
                    _orders.Remove(orderView);
                    _orders.Add(newOrderView);
                    CreateDeliveryTable();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            try
            {
                if (Directory.Exists(Application.StartupPath + "\\print_files\\"))
                {
                    try
                    {
                        Directory.Delete(Application.StartupPath + "\\print_files\\", true);
                    }
                    catch { }
                }

                var print_files = Application.StartupPath + "\\print_files\\" + DateTime.Now.ToString("yyyy-dd-M-HH-mm-ss") + "\\";

                if (!Directory.Exists(print_files))
                {
                    Directory.CreateDirectory(print_files);
                }

                foreach (DataGridViewRow row in deliveryGrid.SelectedRows)
                {
                    OrderView tmp = _filteredDeliveryOrders.FirstOrDefault(c => c.Id == (int)row.Cells[0].Value);
                    var text = File.ReadAllText(Application.StartupPath + "document.xml");
                    text = text.Replace("FIO", tmp.ReceiverCredentials).Replace("ADR", tmp.DeliveryAddress)
                        .Replace("INDEX", tmp.PostIndex).Replace("NUM", tmp.Id.ToString());

                    File.WriteAllText(Application.StartupPath + "\\templ_docx\\word\\document.xml", text);
                    ZipFile.CreateFromDirectory(Application.StartupPath + "\\templ_docx", print_files + tmp.Id.ToString() + ".docx");
                }

                using (var pd = new PrintDialog())
                {
                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        var files = Directory.GetFiles(print_files);
                        foreach (var file in files)
                        {
                            using (var p = new Process())
                            {
                                p.StartInfo = new ProcessStartInfo(file)
                                {
                                    ErrorDialog = false,
                                    Arguments = "\"" + pd.PrinterSettings.PrinterName + "\"",
                                    UseShellExecute = true,
                                    Verb = "PrintTo",
                                    CreateNoWindow = true,
                                    WindowStyle = ProcessWindowStyle.Hidden
                                };
                                p.Start();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }

            button1.Enabled = true;
        }

        private void DeliveryGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && deliveryGrid.Rows.Count > e.RowIndex)
            {
                var id = (int)deliveryGrid.Rows[e.RowIndex].Cells[0].Value;
                var orderFullView = _ordersService.GetOrderFullViewById(id);
                var orderView = _orders.FirstOrDefault(x => x.Id == id);
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

                        var newOrderView = _ordersService.UpdateOrder(order);
                        _orders.Remove(orderView);
                        _orders.Add(newOrderView);
                        CreateOrdersTable();
                    }
                }
            }
        }
    }
}