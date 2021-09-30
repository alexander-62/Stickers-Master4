using Stickers.Core.Services;
using Stickers.Data.Entities;
using Stickers.WinForms.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Core.Mappers;
using Stickers.Core.Utilities;
using Stickers.Data.Model.Constants;
using Stickers.Data.Model.Views;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Stickers.WinForms.OrderForms
{
    public partial class OrderForm : Form
    {
        public BusinessClient Client => (BusinessClient)clientComboBox.SelectedItem;
        public DateTime? ApproximalDeliveryDate => approximalDeliveryDatePicker.Checked ? approximalDeliveryDatePicker.Value : (DateTime?)null;
        public bool IsUrgent => urgencyCheckBox.Checked;
        public bool IsPayed => paymentCheckBox.Checked;
        public string DeliveryAddress => txtDeliveryAddress.Text.Trim();
        public string ReceiverCredentials => txtReceiverCredentials.Text.Trim();
        public string PostIndex => txtPostIndex.Text.Trim();
        public string Comment => txtComment.Text.Trim();
        public PaymentMethod PaymentMethod => ((KeyValuePair<PaymentMethod, string>)comboBoxPaymentMethod.SelectedItem).Key;
        public DeliveryType DeliveryType => ((KeyValuePair<DeliveryType, string>)deliveryTypeComboBox.SelectedItem).Key;
        public List<OrderItem> OrderItems { get; set; }
        public Dictionary<string, List<string>> OrderItemsSourceFiles { get; set; }
        public Dictionary<string, string> OrderItemsContourFiles { get; set; }
        private List<BusinessClient> Clients { get; set; }
        private List<Film> Films { get; set; }
        private readonly bool _editMode;
        private readonly OrderView _currentOrder;
        private readonly User _currentUser;

        private readonly BusinessClientsService _businessClientsService;
        private readonly OrderItemMapper _orderItemMapper;
        private readonly OrderItemCalculator _orderItemCalculator;
        private readonly OrderFilesService _orderFilesService;
        private readonly OrderItemService _orderItemService;
        private readonly OrdersService _ordersService;
        private readonly PaperParametersService _paperParametersService;
        private readonly WorkReportService _workReportService;

        public OrderForm(List<BusinessClient> clients, List<Film> films, User currentUser)
        {
            InitializeComponent();
            _editMode = false;
            _currentUser = currentUser;
            Clients = clients;
            Films = films;
            OrderItemsSourceFiles = new Dictionary<string, List<string>>();
            OrderItemsContourFiles = new Dictionary<string, string>();
            _businessClientsService = new BusinessClientsService();
            _orderItemMapper = new OrderItemMapper();
            _orderItemCalculator = new OrderItemCalculator();
            _orderFilesService = new OrderFilesService();
            _orderItemService = new OrderItemService();
            _ordersService = new OrdersService();
            _paperParametersService = new PaperParametersService();
            _workReportService = new WorkReportService();

            OrderItems = new List<OrderItem>();

            InitializePaymentMethodCombobox();
            InitializeDeliveryTypeCombobox();
            InitializeClientsComboBox(true);
            CreateOrderItemsTable();
            CreateLabels();
        }

        public OrderForm(List<BusinessClient> clients, List<Film> films, User currentUser, OrderFullView order, bool readOnly = false) : this(clients, films, currentUser)
        {
            _editMode = true;
            _currentOrder = order;
            Text += $" №{order.Id}";
            txtComment.Text = order.Comment;
            lblOrderInsertInfo.Text += $" {order.InsertedBy} {order.InsertedDate?.ToString("dd/MM/yyyy")}";
            lblOrderConfirmInfo.Text += $" {order.ConfirmedBy} {order.ConfirmedDate?.ToString("dd/MM/yyyy")}";
            lblOrderDoneDate.Text += $" {order.OrderDoneDate?.ToString("dd/MM/yyyy")}";
            lblOrderTrackNumber.Text += $" {order.TrackIdentifier}";
            lblPaymentCheckInfo.Text += $" {order.PaymentCheckedBy} {order.PaymentCheckedDate?.ToString("dd/MM/yyyy")}";
            lblDeliveryDate.Text += $" {order.DeliveryDate?.ToString("dd/MM/yyyy")}";
            clientComboBox.SelectedItem = Clients.Find(x => x.Name == order.ClientName);
            urgencyCheckBox.Checked = order.IsUrgent;
            paymentCheckBox.Checked = order.IsPayed;
            approximalDeliveryDatePicker.Checked = order.ApproximalDeliveryDate.HasValue;
            if (order.ApproximalDeliveryDate.HasValue)
            {
                approximalDeliveryDatePicker.Value = order.ApproximalDeliveryDate.Value;
            }

            txtDeliveryAddress.Text = order.DeliveryAddress;
            txtPostIndex.Text = order.PostIndex;
            txtReceiverCredentials.Text = order.ReceiverCredentials;
            comboBoxPaymentMethod.SelectedIndex = comboBoxPaymentMethod.Items.IndexOf(order.PaymentMethod);
            deliveryTypeComboBox.SelectedIndex = deliveryTypeComboBox.Items.IndexOf(order.DeliveryType);

            OrderItems = _orderItemService.GetOrderItemsByOrderId(order.Id);
            InitializePaymentMethodCombobox(order.PaymentMethod);
            InitializeDeliveryTypeCombobox(order.DeliveryType);
            CreateOrderItemsTable();
            CreateLabels();
            if (readOnly)
            {
                orderItemsGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
                clientComboBox.Enabled = false;
                btnAddClient.Enabled = false;
                urgencyCheckBox.Enabled = false;
                btnAddOrderItem.Enabled = false;
                btnDeleteOrderItem.Enabled = false;
                btnСhangeSourceFiles.Enabled = false;
                btnLoadContour.Enabled = false;
                btnEditOrderItem.Enabled = false;
            }
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            var form = new AddClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                BusinessClient newClient = new BusinessClient()
                {
                    Name = form.ClientName,
                    VkId = form.VkId,
                    PostIndex = form.PostIndex,
                    Address = form.Address,
                    ReceiverCredentials = form.ReceiverCredentials,
                    Comment = form.Comment,
                    VkLink = form.VkLink,
                    VkGroupName = form.VkGroupName
                };
                newClient = _businessClientsService.AddClient(newClient);
                Clients.Add(newClient);
                InitializeClientsComboBox();
                clientComboBox.SelectedItem = newClient;
                txtDeliveryAddress.Text = newClient.Address;
                txtReceiverCredentials.Text = newClient.ReceiverCredentials;
                txtPostIndex.Text = newClient.PostIndex;
                txtClientComment.Text = newClient.Comment;
                txtVkLink.Text = newClient.VkLink;
                txtVkGroupName.Text = newClient.VkGroupName;

            }
        }

        private void CreateOrderItemsTable()
        {
            orderItemsGrid.DataSource = null;
            orderItemsGrid.AutoGenerateColumns = false;
            orderItemsGrid.Columns.Clear();
            orderItemsGrid.DataSource = _orderItemMapper.MapList(OrderItems);

            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Название макета"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Film", "Пленка"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Lamination", "Ламинация"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CommentForDesigner", "Комментарий для дизайнера"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CommentForProduction", "Комментарий для производства"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("ItemCost", "Цена стикеров"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("ItemCostPerPaper", "Цена листа"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Discount", "Скидка"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperParameters", "Параметры листа"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperCount", "Количество листов"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CuttingType", "Тип резки"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CuttingLength", "Длина резки"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Status", "Статус"));
            orderItemsGrid.Columns.Add(ColumnUtility.CreateTableColumn("ContourDrawnBy", "Контур нарисовал"));

            orderItemsGrid.Columns[0].Visible = false;

            Type dgvType = orderItemsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(orderItemsGrid, true, null);
        }

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            var form = new OrderItemForm(OrderItems.Select(x => x.Name).ToList(), Films);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderItem orderItem = new OrderItem()
                {
                    Id = 0,
                    CommentForDesigner = form.CommentForDesigner,
                    CommentForProduction = form.CommentForProduction,
                    CuttingLength = form.CuttingLength,
                    CuttingType = form.CuttingType,
                    Name = form.Description,
                    FilmId = form.Film.Id,
                    Film = form.Film,
                    Lamination = form.Lamination,
                    Status = OrderItemStatus.NotStarted,
                    PaperCount = form.PaperCount,
                    PaperLength = form.PaperLength,
                    PaperWidth = form.PaperWidth,
                    CreatedDateTime = DateTime.Now,
                    Discount = form.Discount,
                };
                if (orderItem.CuttingType == CuttingType.None)
                {
                    orderItem.PlotteredCount = orderItem.PaperCount;
                }

                if (orderItem.Lamination == Lamination.None)
                {
                    orderItem.LaminatedCount = orderItem.PaperCount;
                }

                if (form.ManualPrice > -1)
                {
                    orderItem.IsManualPricing = true;
                    orderItem.ItemCost = form.ManualPrice * form.PaperCount;
                }
                
                try
                {
                    if (form.ContourFileStatus)
                    {
                        OrderItemsContourFiles.Add(form.Description, form.ContourFile);
                        orderItem.Status = OrderItemStatus.ContourDrawn;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(form.ContourFile))
                        {
                            OrderItemsSourceFiles.Add(form.Description, form.SourceFiles);
                        }
                        else
                        {
                            OrderItemsContourFiles.Add(form.Description, form.ContourFile);
                            orderItem.Status = OrderItemStatus.ContourDrawn;
                        }
                    }

                    orderItem.ItemCost = _orderItemCalculator.CalculateCost(orderItem, IsUrgent);
                    OrderItems.Add(orderItem);
                    CreateOrderItemsTable();
                    
                    CreateLabels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEditOrderItem_Click(object sender, EventArgs e)
        {
            if (orderItemsGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите позицию для изменения.");
            }
            else
            {
                var row = orderItemsGrid.Rows[orderItemsGrid.SelectedCells[0].RowIndex];
                var id = (int) row.Cells[0].Value;
                var orderItem = OrderItems.FirstOrDefault(x => x.Id == id);
                var form = new OrderItemForm(OrderItems.Select(x => x.Name).ToList(), Films, orderItem);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    orderItem.CommentForDesigner = form.CommentForDesigner;
                    orderItem.CommentForProduction = form.CommentForProduction;
                    orderItem.CuttingType = form.CuttingType;
                    orderItem.FilmId = form.Film.Id;
                    orderItem.Film = form.Film;
                    orderItem.Lamination = form.Lamination;
                    orderItem.PaperCount = form.PaperCount;
                    orderItem.PaperLength = form.PaperLength;
                    orderItem.PaperWidth = form.PaperWidth;
                    orderItem.Discount = form.Discount;

                    orderItem.PlotteredCount = orderItem.CuttingType == CuttingType.None ? orderItem.PaperCount : 0;

                    orderItem.LaminatedCount = orderItem.Lamination == Lamination.None ? orderItem.PaperCount : 0;

                    if (form.ManualPrice > -1)
                    {
                        orderItem.IsManualPricing = true;
                        orderItem.ItemCost = form.ManualPrice * form.PaperCount;
                    }
                    else
                    {
                        orderItem.IsManualPricing = false;
                    }

                    try
                    {
                        if (form.SourceFiles.Count > 0)
                        {
                            OrderItemsSourceFiles.Add(form.Description, form.SourceFiles);
                        }
                        else if (!string.IsNullOrEmpty(form.ContourFile))
                        {
                            OrderItemsContourFiles.Add(form.Description, form.ContourFile);
                            orderItem.Status = OrderItemStatus.ContourDrawn;
                        }
                        orderItem.ItemCost = _orderItemCalculator.CalculateCost(orderItem, IsUrgent);
                        CreateOrderItemsTable();
                        CreateLabels();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UrgencyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var item in OrderItems)
            {
                item.ItemCost = _orderItemCalculator.CalculateCost(item, IsUrgent);
            }
            CreateOrderItemsTable();
            CreateLabels();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void InitializeClientsComboBox(bool firstTime = false)
        {
            var emptyClient = new BusinessClient
            {
                Id = -1,
                Name = string.Empty,
            };
            if (firstTime)
            {
                Clients.Add(emptyClient);
                Clients = Clients.OrderBy(x => x.Id).ToList();
            }
            clientComboBox.DataSource = new BindingSource(Clients, null);
            clientComboBox.DisplayMember = "Name";
            if (Clients.Any())
            {
                clientComboBox.SelectedItem = clientComboBox.Items[0];
            }
        }

        private void СlientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientComboBox.SelectedItem is BusinessClient client)
            {
                txtDeliveryAddress.Text = client.Address;
                txtReceiverCredentials.Text = client.ReceiverCredentials;
                txtPostIndex.Text = client.PostIndex;
                txtClientComment.Text = client.Comment;
                txtVkLink.Text = client.VkLink;
                txtVkGroupName.Text = client.VkGroupName;
            }
        }

        private void TxtDeliveryAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeliveryAddress.Text.Trim()))
            {
                errorDeliveryAddress.SetError(txtDeliveryAddress, "Введите адрес отправки");
                e.Cancel = true;
            }
            else
            {
                errorDeliveryAddress.SetError(txtDeliveryAddress, "");
                e.Cancel = false;
            }
        }

        private void TxtReceiverCredentials_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtReceiverCredentials.Text.Trim()))
            {
                errorReceiverCredentials.SetError(txtReceiverCredentials, "Введите ФИО получателя");
                e.Cancel = true;
            }
            else
            {
                errorReceiverCredentials.SetError(txtReceiverCredentials, "");
                e.Cancel = false;
            }
        }

        private void TxtPostIndex_Validating(object sender, CancelEventArgs e)
        {
            if (((KeyValuePair<DeliveryType, string>) deliveryTypeComboBox.SelectedItem).Key ==
                DeliveryType.RussianPost)
            {
                if (string.IsNullOrEmpty(txtPostIndex.Text.Trim()))
                {
                    errorPostIndex.SetError(txtPostIndex, "Введите индекс");
                    e.Cancel = true;
                }
                else if (!string.IsNullOrEmpty(txtPostIndex.Text.Trim()) && txtPostIndex.Text.Trim().Length != 6)
                {
                    errorPostIndex.SetError(txtPostIndex, "Должно быть 6 символов");
                    e.Cancel = true;
                }
                else if (!string.IsNullOrEmpty(txtPostIndex.Text.Trim()) && txtPostIndex.Text.Trim().Any(x => !char.IsDigit(x)))
                {
                    errorPostIndex.SetError(txtPostIndex, "Индекс должен содержать только цифры");
                    e.Cancel = true;
                }
                else
                {
                    errorPostIndex.SetError(txtPostIndex, "");
                    e.Cancel = false;
                }
            }
        }

        private void BtnDeleteOrderItem_Click(object sender, EventArgs e)
        {
            if (orderItemsGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите позицию для удаления.");
            }
            else
            {
                var row = orderItemsGrid.Rows[orderItemsGrid.SelectedCells[0].RowIndex];
                var name = (string)row.Cells[1].Value;
                try
                {
                    var orderRemoved = OrderItems.Find(x => x.Name == name);
                    OrderItems.Remove(orderRemoved);
                    OrderItemsSourceFiles.Remove(name);
                    OrderItemsContourFiles.Remove(name);
                    if (_editMode)
                    {
                        _orderFilesService.DeleteOrderItemFiles(_currentOrder.Id, name);
                    }
                    CreateOrderItemsTable();
                    CreateLabels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeliveryTypeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (deliveryTypeComboBox.SelectedIndex == 0)
            {
                errorDeliveryType.SetError(deliveryTypeComboBox, "Выберите способ доставки");
                e.Cancel = true;
            }
            else
            {
                errorDeliveryType.SetError(deliveryTypeComboBox, "");
                e.Cancel = false;
            }
        }

        private void InitializePaymentMethodCombobox(string currentMethod = null)
        {
            var paymentMethodValues = Enum.GetValues(typeof(PaymentMethod)).Cast<PaymentMethod>().ToList();
            var paymentMethodValuesWithDescription = new Dictionary<PaymentMethod, string>();
            foreach (var value in paymentMethodValues)
            {
                paymentMethodValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            comboBoxPaymentMethod.DataSource = new BindingSource(paymentMethodValuesWithDescription, null);
            comboBoxPaymentMethod.DisplayMember = "Value";
            comboBoxPaymentMethod.ValueMember = "Key";
            if (currentMethod == null)
            {
                comboBoxPaymentMethod.SelectedItem = comboBoxPaymentMethod.Items[0];
            }
            else
            {
                var selected = paymentMethodValuesWithDescription.First(x => x.Value == currentMethod);
                comboBoxPaymentMethod.SelectedItem = selected;
            }
        }

        private void InitializeDeliveryTypeCombobox(string currentType = null)
        {
            var deliveryTypeValues = Enum.GetValues(typeof(DeliveryType)).Cast<DeliveryType>().ToList();
            var deliveryTypeValuesWithDescription = new Dictionary<DeliveryType, string>();
            foreach (var value in deliveryTypeValues)
            {
                deliveryTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            deliveryTypeComboBox.DataSource = new BindingSource(deliveryTypeValuesWithDescription, null);
            deliveryTypeComboBox.DisplayMember = "Value";
            deliveryTypeComboBox.ValueMember = "Key";
            if (currentType == null)
            {
                deliveryTypeComboBox.SelectedItem = deliveryTypeComboBox.Items[0];
            }
            else
            {
                var selected = deliveryTypeValuesWithDescription.First(x => x.Value == currentType);
                deliveryTypeComboBox.SelectedItem = selected;
            }
        }

        private void BtnСhangeSourceFiles_Click(object sender, EventArgs e)
        {
            if (orderItemsGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите позицию для загрузки исходников.");
            }
            else
            {
                var row = orderItemsGrid.Rows[orderItemsGrid.SelectedCells[0].RowIndex];
                var name = (string)row.Cells[1].Value;
                try
                {
                    var orderItem = OrderItems.Find(x => x.Name == name);
                    OpenFileDialog openFileDialog = new OpenFileDialog
                    {
                        CheckFileExists = true,
                        AddExtension = true,
                        Multiselect = true
                    };

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (!_editMode)
                        {
                            OrderItemsSourceFiles[orderItem.Name] = openFileDialog.FileNames.ToList();
                            OrderItemsContourFiles.Remove(orderItem.Name);
                        }
                        else
                        {
                            _orderFilesService.DeleteOrderItemFiles(_currentOrder.Id, orderItem.Name);
                            _orderFilesService.SaveOrderItemSourceFiles(_currentOrder.Id, orderItem.Name, openFileDialog.FileNames.ToList());
                            orderItem.Status = OrderItemStatus.NotStarted;
                            orderItem.Order.Status = OrderStatus.NotStarted;
                            orderItem.CuttingLength = 0;
                            _orderItemService.UpdateOrderItem(orderItem);
                            OrderItems = _orderItemService.GetOrderItemsByOrderId(orderItem.OrderId);
                            CreateOrderItemsTable();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CreateLabels()
        {
            var stickersCost = Math.Round(OrderItems.Sum(x => x.ItemCost), 2);
            var deliveryCost = _currentOrder == null ? 0m : Math.Round(_currentOrder.DeliveryCost, 2);
            var fullCost = stickersCost + deliveryCost;
            lblStickersCostValue.Text = stickersCost + " руб.";
            lblDeliveryCostValue.Text = deliveryCost + " руб.";
            lblFullCostValue.Text = fullCost + " руб.";
        }

        private void BtnOpenContourFolder_Click(object sender, EventArgs e)
        {
            if (_currentOrder == null)
            {
                MessageBox.Show("Заказ еще не сохранен!");
            }
            else
            {
                _orderFilesService.OpenContourFolder(_currentOrder.Id, _currentOrder.IsArchived);
            }
        }

        private void ClientComboBox_Validating(object sender, CancelEventArgs e)
        {
            if ((BusinessClient) clientComboBox.SelectedItem == null || ((BusinessClient)clientComboBox.SelectedItem).Id == -1)
            {
                errorClient.SetError(clientComboBox, "Выберите клиента");
                e.Cancel = true;
            }
            else
            {
                errorClient.SetError(clientComboBox, string.Empty);
                e.Cancel = false;
            }
        }

        private void BtnLoadContour_Click(object sender, EventArgs e)
        {
            if (orderItemsGrid.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите позицию для загрузки контура.");
            }
            else
            {
                var row = orderItemsGrid.Rows[orderItemsGrid.SelectedCells[0].RowIndex];
                var name = (string)row.Cells[1].Value;
                try
                {
                    var orderItem = OrderItems.Find(x => x.Name == name);
                    OrderItemContourForm form = new OrderItemContourForm(orderItem.CuttingLength, EnumUtility.GetEnumDescription(orderItem.CuttingType));
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        orderItem.Status = OrderItemStatus.ContourDrawn;
                        orderItem.CuttingLength = form.CuttingLength;
                        orderItem.ItemCost = _orderItemCalculator.CalculateCost(orderItem, IsUrgent);
                        if (!_editMode)
                        {
                            OrderItemsContourFiles.Add(orderItem.Name, form.ContourFile);
                        }
                        if (_editMode)
                        {
                            _orderFilesService.SaveOrderItemContourFiles(orderItem.OrderId, orderItem.Name, form.ContourFile);
                            _orderItemService.UpdateOrderItem(orderItem);
                            var order = _ordersService.GetOrderById(orderItem.OrderId);
                            if (OrderItems.All(x => x.Status == OrderItemStatus.ContourDrawn))
                            {
                                order.Status = OrderStatus.ContoursDrawn;
                            }
                            _ordersService.UpdateOrder(order);
                            orderItem = _orderItemService.GetOrderItemById(orderItem.Id);
                            CreateLayoutReport(orderItem);
                        }
                        CreateOrderItemsTable();
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

        private void BtnOpenDialog_Click(object sender, EventArgs e)
        {
            var client = (BusinessClient)clientComboBox.SelectedItem;
            if (client != null && !string.IsNullOrEmpty(client.VkId))
            {
                var url = client.VkId.Contains("vk.com") ? client.VkId : @"https://vk.com/gim161594158?sel=" + client.VkId;
                try
                {
                    Process.Start(url);
                }
                catch
                {
                    // hack because of this: https://github.com/dotnet/corefx/issues/10361
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show($"У клиента {client.Name} не указана информация о ВКонтакте.");
            }
        }

        private void btnOpenVkGroupLink_Click(object sender, EventArgs e)
        {
            var url = txtVkLink.Text;

            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
