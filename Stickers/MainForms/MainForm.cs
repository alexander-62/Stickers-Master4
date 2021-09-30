using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Stickers.Core.Services;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm : Form
    {
        private BusinessClientsService _businessClientsService;
        private CostsService _costsService;
        private OrdersService _ordersService;
        private OrderFilesService _orderFilesService;
        private OrderItemService _orderItemService;
        private FilmService _filmService;
        private OrderItemCalculator _orderItemCalculator;
        private RollService _rollService;
        private WorkReportService _workReportService;
        private PaperParametersService _paperParametersService;
        private readonly User _currentUser;

        public MainForm(User user)
        {
            _currentUser = user;

            InitializeComponent();
            InitializeMenu();
            CreateServices();
            ConfigurePermissions();
        }

        private void ConfigurePermissions()
        {
            if (_currentUser.UserRole == UserRole.Guest)
            {
                tabControlMain.Visible = false;
            }
            else
            {
                if (_currentUser.UserRole == UserRole.Worker)
                {
                    tabControlMain.TabPages.RemoveAt(3);
                    tabControlMain.TabPages.RemoveAt(2);
                    tabControlMain.TabPages.RemoveAt(1);
                    tabControlMain.TabPages.RemoveAt(0);
                }
                else if (_currentUser.UserRole == UserRole.Manager)
                {
                    tabControlMain.TabPages.RemoveAt(5);
                    tabControlMain.TabPages.RemoveAt(3);
                    btnDeleteOrder.Visible = false;
                }
                else if (_currentUser.UserRole == UserRole.Designer)
                {
                    tabControlMain.TabPages.RemoveAt(5);
                    tabControlMain.TabPages.RemoveAt(3);
                    tabControlMain.TabPages.RemoveAt(2);
                    tabControlMain.TabPages.RemoveAt(0);
                    btnAddDeliveryInfo.Visible = false;
                    btnCheckDelivery.Visible = false;
                    btnContourToRevision.Visible = false;
                    btnUnconfirmOrder.Visible = false;
                }

                if (_currentUser.UserRole == UserRole.Manager || _currentUser.UserRole == UserRole.Administrator)
                {
                    _orders = _ordersService.GetOrderViews();
                    _filteredOrders = _orders;
                    InitializeOrderFilters();
                    CreateOrdersTable();
                }
                else if (_currentUser.UserRole == UserRole.Worker)
                {
                    _orders = _ordersService.GetOrderViews();
                    InitializeDeliveryFilters();
                    CreateDeliveryTable();
                }
                else if (_currentUser.UserRole == UserRole.Designer)
                {
                    _orderItems = _orderItemService.GetOrderItemViewsForDesigner();
                    _filteredOrderItems = _orderItems;
                    InitializeLayoutFilters();
                    CreateLayoutsTable();
                }
            }
        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab.Name == "ordersTab")
            {
                _orders = _ordersService.GetOrderViews();
                _filteredOrders = _orders;
                InitializeOrderFilters();
                CreateOrdersTable();
            }
            else if (tabControlMain.SelectedTab.Name == "layoutsTab")
            {
                _orderItems = _orderItemService.GetOrderItemViewsForDesigner();
                _filteredOrderItems = _orderItems;
                InitializeLayoutFilters();
                CreateLayoutsTable();
            }
            else if (tabControlMain.SelectedTab.Name == "clientsTab")
            {
                _businessClients = _businessClientsService.GetClients();
                _filteredClients = _businessClients;
                CreateBusinessClientsTable(true);
            }
            else if (tabControlMain.SelectedTab.Name == "costsTab")
            {
                _costs = _costsService.GetCosts();
                CreateCostsTable();
            }
            else if (tabControlMain.SelectedTab.Name == "deliveryTab")
            {
                _orders = _ordersService.GetOrderViewsForDelivery();
                InitializeDeliveryFilters();
                CreateDeliveryTable();
            }
            else if (tabControlMain.SelectedTab.Name == "productionTab")
            {
                _orderItems = _orderItemService.GetOrderItemViewsForProduction();
                InitializeProductionFilters();
                CreateProductionTable(true);
            }
        }

        private void CreateServices()
        {
            _businessClientsService = new BusinessClientsService();
            _costsService = new CostsService();
            _ordersService = new OrdersService();
            _orderFilesService = new OrderFilesService();
            _orderItemService = new OrderItemService();
            _filmService = new FilmService();
            _orderItemCalculator = new OrderItemCalculator();
            _rollService = new RollService();
            _workReportService = new WorkReportService();
            _paperParametersService = new PaperParametersService();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Завершить работу приложения?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly) == DialogResult.No)
            {
                e.Cancel = true;
            }

            TopMost = true;
            TopLevel = true;
            Show();
        }
    }
}