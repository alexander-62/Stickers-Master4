namespace Stickers.WinForms.MainForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblPaymentCheckInfo = new System.Windows.Forms.Label();
            this.lblOrderTrackNumber = new System.Windows.Forms.Label();
            this.lblOrderDoneDate = new System.Windows.Forms.Label();
            this.lblOrderConfirmInfo = new System.Windows.Forms.Label();
            this.lblOrderInsertInfo = new System.Windows.Forms.Label();
            this.orderUrgencyFilterCombobox = new System.Windows.Forms.ComboBox();
            this.lblUrgencyOrderFilter = new System.Windows.Forms.Label();
            this.txtOrderInsertedFilter = new System.Windows.Forms.TextBox();
            this.lblOrderInsertedByFilter = new System.Windows.Forms.Label();
            this.txtOrdersOrderIdFilter = new System.Windows.Forms.TextBox();
            this.lblOrdersOrderIdFilter = new System.Windows.Forms.Label();
            this.orderStatusListBox = new System.Windows.Forms.ListBox();
            this.orderDeliveryEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryEndDate = new System.Windows.Forms.Label();
            this.orderDeliveryStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDeliveryStartDatePicker = new System.Windows.Forms.Label();
            this.orderEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblOrderEndDate = new System.Windows.Forms.Label();
            this.orderStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblOrderstartDate = new System.Windows.Forms.Label();
            this.btnUnconfirmOrder = new System.Windows.Forms.Button();
            this.txtClientNameFilter = new System.Windows.Forms.TextBox();
            this.lblOrderSum = new System.Windows.Forms.Label();
            this.lblPlotting = new System.Windows.Forms.Label();
            this.lblLaminationArea = new System.Windows.Forms.Label();
            this.lblPrintingArea = new System.Windows.Forms.Label();
            this.lblPaperCount = new System.Windows.Forms.Label();
            this.lblLayoutsCount = new System.Windows.Forms.Label();
            this.lblOrdersCount = new System.Windows.Forms.Label();
            this.btnArchiveOrder = new System.Windows.Forms.Button();
            this.paymentComboBox = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.ordersGrid = new System.Windows.Forms.DataGridView();
            this.layoutsTab = new System.Windows.Forms.TabPage();
            this.lblLayoutsTabLayoutsTotal = new System.Windows.Forms.Label();
            this.lblContourDrawAverageTime = new System.Windows.Forms.Label();
            this.lblAveragePlottingLength = new System.Windows.Forms.Label();
            this.lblAveragePaperParameters = new System.Windows.Forms.Label();
            this.statusForDesignerCombobox = new System.Windows.Forms.ComboBox();
            this.lblStatusForDesigner = new System.Windows.Forms.Label();
            this.orderIdForDesignerCombobox = new System.Windows.Forms.ComboBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.btnOpenContoursFolder = new System.Windows.Forms.Button();
            this.btnOpenSources = new System.Windows.Forms.Button();
            this.btnContourToRevision = new System.Windows.Forms.Button();
            this.btnLoadContour = new System.Windows.Forms.Button();
            this.layoutsGrid = new System.Windows.Forms.DataGridView();
            this.clientsTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClientFilterByName = new System.Windows.Forms.Label();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.txtClientFilterByName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxGrVk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxVkGrLnk = new System.Windows.Forms.TextBox();
            this.buttonDlg = new System.Windows.Forms.Button();
            this.btnOpenVkGroupLink = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.costsTab = new System.Windows.Forms.TabPage();
            this.btnDeleteCost = new System.Windows.Forms.Button();
            this.btnEditCost = new System.Windows.Forms.Button();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.costsGrid = new System.Windows.Forms.DataGridView();
            this.deliveryTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDeliveryOrdersTotal = new System.Windows.Forms.Label();
            this.deliveryEndDateFilterPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryEndDateFilter = new System.Windows.Forms.Label();
            this.deliveryStartDateFilterPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryStartDateFilter = new System.Windows.Forms.Label();
            this.deliveryMethodComboboxFilter = new System.Windows.Forms.ComboBox();
            this.lblDeliveryMethodFilter = new System.Windows.Forms.Label();
            this.deliveryStatusComboboxFilter = new System.Windows.Forms.ComboBox();
            this.lblDeliveryStatusFilter = new System.Windows.Forms.Label();
            this.txtDeliveryTrackNumberFilter = new System.Windows.Forms.TextBox();
            this.lblDeliveryTrackNumberFilter = new System.Windows.Forms.Label();
            this.txtDeliveryClientNameFilter = new System.Windows.Forms.TextBox();
            this.lblDeliveryClientFilter = new System.Windows.Forms.Label();
            this.txtDeliveryOrderIdFilter = new System.Windows.Forms.TextBox();
            this.lblDeliveryOrderIdFilter = new System.Windows.Forms.Label();
            this.btnCheckDelivery = new System.Windows.Forms.Button();
            this.btnAddDeliveryInfo = new System.Windows.Forms.Button();
            this.deliveryGrid = new System.Windows.Forms.DataGridView();
            this.productionTab = new System.Windows.Forms.TabPage();
            this.txtProductionOrderIdFilter = new System.Windows.Forms.TextBox();
            this.lblProductionOrderIdFilter = new System.Windows.Forms.Label();
            this.productionUrgencyFilterCombobox = new System.Windows.Forms.ComboBox();
            this.lblProductionUrgencyFilter = new System.Windows.Forms.Label();
            this.lblProductionLaminationMeters = new System.Windows.Forms.Label();
            this.lblProductionPrintMeters = new System.Windows.Forms.Label();
            this.lblProductionPlotteringLength = new System.Windows.Forms.Label();
            this.lblProductionPaperCount = new System.Windows.Forms.Label();
            this.lblProductionLayoutsCount = new System.Windows.Forms.Label();
            this.lblProductionOrdersCount = new System.Windows.Forms.Label();
            this.txtClientNameProductionFilter = new System.Windows.Forms.TextBox();
            this.lblProductionClientName = new System.Windows.Forms.Label();
            this.btnCheckCutting = new System.Windows.Forms.Button();
            this.btnCheckPlottering = new System.Windows.Forms.Button();
            this.btnCheckLamination = new System.Windows.Forms.Button();
            this.btnCheckPrinting = new System.Windows.Forms.Button();
            this.btnOpenContours = new System.Windows.Forms.Button();
            this.productionGrid = new System.Windows.Forms.DataGridView();
            this.cuttingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblCuttingType = new System.Windows.Forms.Label();
            this.laminationComboBox = new System.Windows.Forms.ComboBox();
            this.lblLamination = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tabControlMain.SuspendLayout();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).BeginInit();
            this.layoutsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsGrid)).BeginInit();
            this.clientsTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.costsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costsGrid)).BeginInit();
            this.deliveryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGrid)).BeginInit();
            this.productionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.ordersTab);
            this.tabControlMain.Controls.Add(this.layoutsTab);
            this.tabControlMain.Controls.Add(this.clientsTab);
            this.tabControlMain.Controls.Add(this.costsTab);
            this.tabControlMain.Controls.Add(this.deliveryTab);
            this.tabControlMain.Controls.Add(this.productionTab);
            this.tabControlMain.Location = new System.Drawing.Point(13, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1273, 551);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // ordersTab
            // 
            this.ordersTab.Controls.Add(this.lblDeliveryDate);
            this.ordersTab.Controls.Add(this.lblPaymentCheckInfo);
            this.ordersTab.Controls.Add(this.lblOrderTrackNumber);
            this.ordersTab.Controls.Add(this.lblOrderDoneDate);
            this.ordersTab.Controls.Add(this.lblOrderConfirmInfo);
            this.ordersTab.Controls.Add(this.lblOrderInsertInfo);
            this.ordersTab.Controls.Add(this.orderUrgencyFilterCombobox);
            this.ordersTab.Controls.Add(this.lblUrgencyOrderFilter);
            this.ordersTab.Controls.Add(this.txtOrderInsertedFilter);
            this.ordersTab.Controls.Add(this.lblOrderInsertedByFilter);
            this.ordersTab.Controls.Add(this.txtOrdersOrderIdFilter);
            this.ordersTab.Controls.Add(this.lblOrdersOrderIdFilter);
            this.ordersTab.Controls.Add(this.orderStatusListBox);
            this.ordersTab.Controls.Add(this.orderDeliveryEndDatePicker);
            this.ordersTab.Controls.Add(this.lblDeliveryEndDate);
            this.ordersTab.Controls.Add(this.orderDeliveryStartDatePicker);
            this.ordersTab.Controls.Add(this.lblOrderDeliveryStartDatePicker);
            this.ordersTab.Controls.Add(this.orderEndDatePicker);
            this.ordersTab.Controls.Add(this.lblOrderEndDate);
            this.ordersTab.Controls.Add(this.orderStartDatePicker);
            this.ordersTab.Controls.Add(this.lblOrderstartDate);
            this.ordersTab.Controls.Add(this.btnUnconfirmOrder);
            this.ordersTab.Controls.Add(this.txtClientNameFilter);
            this.ordersTab.Controls.Add(this.lblOrderSum);
            this.ordersTab.Controls.Add(this.lblPlotting);
            this.ordersTab.Controls.Add(this.lblLaminationArea);
            this.ordersTab.Controls.Add(this.lblPrintingArea);
            this.ordersTab.Controls.Add(this.lblPaperCount);
            this.ordersTab.Controls.Add(this.lblLayoutsCount);
            this.ordersTab.Controls.Add(this.lblOrdersCount);
            this.ordersTab.Controls.Add(this.btnArchiveOrder);
            this.ordersTab.Controls.Add(this.paymentComboBox);
            this.ordersTab.Controls.Add(this.lblPayment);
            this.ordersTab.Controls.Add(this.lblStatus);
            this.ordersTab.Controls.Add(this.lblClientName);
            this.ordersTab.Controls.Add(this.btnConfirmOrder);
            this.ordersTab.Controls.Add(this.btnDeleteOrder);
            this.ordersTab.Controls.Add(this.btnEditOrder);
            this.ordersTab.Controls.Add(this.btnAddOrder);
            this.ordersTab.Controls.Add(this.ordersGrid);
            this.ordersTab.Location = new System.Drawing.Point(4, 24);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(1265, 523);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.Text = "Заказы";
            this.ordersTab.UseVisualStyleBackColor = true;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(1009, 137);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(89, 15);
            this.lblDeliveryDate.TabIndex = 64;
            this.lblDeliveryDate.Text = "Дата отправки:";
            // 
            // lblPaymentCheckInfo
            // 
            this.lblPaymentCheckInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentCheckInfo.AutoSize = true;
            this.lblPaymentCheckInfo.Location = new System.Drawing.Point(1009, 115);
            this.lblPaymentCheckInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentCheckInfo.Name = "lblPaymentCheckInfo";
            this.lblPaymentCheckInfo.Size = new System.Drawing.Size(106, 15);
            this.lblPaymentCheckInfo.TabIndex = 63;
            this.lblPaymentCheckInfo.Text = "Оплата отмечена:";
            // 
            // lblOrderTrackNumber
            // 
            this.lblOrderTrackNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderTrackNumber.AutoSize = true;
            this.lblOrderTrackNumber.Location = new System.Drawing.Point(1009, 93);
            this.lblOrderTrackNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTrackNumber.Name = "lblOrderTrackNumber";
            this.lblOrderTrackNumber.Size = new System.Drawing.Size(74, 15);
            this.lblOrderTrackNumber.TabIndex = 62;
            this.lblOrderTrackNumber.Text = "Трэк номер:";
            // 
            // lblOrderDoneDate
            // 
            this.lblOrderDoneDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderDoneDate.AutoSize = true;
            this.lblOrderDoneDate.Location = new System.Drawing.Point(1009, 67);
            this.lblOrderDoneDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDoneDate.Name = "lblOrderDoneDate";
            this.lblOrderDoneDate.Size = new System.Drawing.Size(105, 15);
            this.lblOrderDoneDate.TabIndex = 61;
            this.lblOrderDoneDate.Text = "Заказ изготовлен:";
            // 
            // lblOrderConfirmInfo
            // 
            this.lblOrderConfirmInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderConfirmInfo.AutoSize = true;
            this.lblOrderConfirmInfo.Location = new System.Drawing.Point(1009, 39);
            this.lblOrderConfirmInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderConfirmInfo.Name = "lblOrderConfirmInfo";
            this.lblOrderConfirmInfo.Size = new System.Drawing.Size(106, 15);
            this.lblOrderConfirmInfo.TabIndex = 60;
            this.lblOrderConfirmInfo.Text = "Заказ согласован:";
            // 
            // lblOrderInsertInfo
            // 
            this.lblOrderInsertInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderInsertInfo.AutoSize = true;
            this.lblOrderInsertInfo.Location = new System.Drawing.Point(1009, 9);
            this.lblOrderInsertInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderInsertInfo.Name = "lblOrderInsertInfo";
            this.lblOrderInsertInfo.Size = new System.Drawing.Size(81, 15);
            this.lblOrderInsertInfo.TabIndex = 59;
            this.lblOrderInsertInfo.Text = "Заказ внесен:";
            // 
            // orderUrgencyFilterCombobox
            // 
            this.orderUrgencyFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderUrgencyFilterCombobox.FormattingEnabled = true;
            this.orderUrgencyFilterCombobox.Location = new System.Drawing.Point(83, 111);
            this.orderUrgencyFilterCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.orderUrgencyFilterCombobox.Name = "orderUrgencyFilterCombobox";
            this.orderUrgencyFilterCombobox.Size = new System.Drawing.Size(203, 23);
            this.orderUrgencyFilterCombobox.TabIndex = 38;
            this.orderUrgencyFilterCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblUrgencyOrderFilter
            // 
            this.lblUrgencyOrderFilter.AutoSize = true;
            this.lblUrgencyOrderFilter.Location = new System.Drawing.Point(6, 113);
            this.lblUrgencyOrderFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrgencyOrderFilter.Name = "lblUrgencyOrderFilter";
            this.lblUrgencyOrderFilter.Size = new System.Drawing.Size(70, 15);
            this.lblUrgencyOrderFilter.TabIndex = 37;
            this.lblUrgencyOrderFilter.Text = "Срочность:";
            // 
            // txtOrderInsertedFilter
            // 
            this.txtOrderInsertedFilter.Location = new System.Drawing.Point(82, 86);
            this.txtOrderInsertedFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderInsertedFilter.Name = "txtOrderInsertedFilter";
            this.txtOrderInsertedFilter.Size = new System.Drawing.Size(241, 23);
            this.txtOrderInsertedFilter.TabIndex = 36;
            this.txtOrderInsertedFilter.TextChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderInsertedByFilter
            // 
            this.lblOrderInsertedByFilter.AutoSize = true;
            this.lblOrderInsertedByFilter.Location = new System.Drawing.Point(6, 88);
            this.lblOrderInsertedByFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderInsertedByFilter.Name = "lblOrderInsertedByFilter";
            this.lblOrderInsertedByFilter.Size = new System.Drawing.Size(68, 15);
            this.lblOrderInsertedByFilter.TabIndex = 35;
            this.lblOrderInsertedByFilter.Text = "Заказ внес:";
            // 
            // txtOrdersOrderIdFilter
            // 
            this.txtOrdersOrderIdFilter.Location = new System.Drawing.Point(97, 8);
            this.txtOrdersOrderIdFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdersOrderIdFilter.Name = "txtOrdersOrderIdFilter";
            this.txtOrdersOrderIdFilter.Size = new System.Drawing.Size(138, 23);
            this.txtOrdersOrderIdFilter.TabIndex = 34;
            this.txtOrdersOrderIdFilter.TextChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrdersOrderIdFilter
            // 
            this.lblOrdersOrderIdFilter.AutoSize = true;
            this.lblOrdersOrderIdFilter.Location = new System.Drawing.Point(3, 10);
            this.lblOrdersOrderIdFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrdersOrderIdFilter.Name = "lblOrdersOrderIdFilter";
            this.lblOrdersOrderIdFilter.Size = new System.Drawing.Size(85, 15);
            this.lblOrdersOrderIdFilter.TabIndex = 33;
            this.lblOrdersOrderIdFilter.Text = "Номер заказа:";
            // 
            // orderStatusListBox
            // 
            this.orderStatusListBox.FormattingEnabled = true;
            this.orderStatusListBox.ItemHeight = 15;
            this.orderStatusListBox.Location = new System.Drawing.Point(701, 6);
            this.orderStatusListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderStatusListBox.Name = "orderStatusListBox";
            this.orderStatusListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.orderStatusListBox.Size = new System.Drawing.Size(208, 139);
            this.orderStatusListBox.TabIndex = 32;
            this.orderStatusListBox.SelectedIndexChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // orderDeliveryEndDatePicker
            // 
            this.orderDeliveryEndDatePicker.Checked = false;
            this.orderDeliveryEndDatePicker.Location = new System.Drawing.Point(392, 59);
            this.orderDeliveryEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDeliveryEndDatePicker.Name = "orderDeliveryEndDatePicker";
            this.orderDeliveryEndDatePicker.ShowCheckBox = true;
            this.orderDeliveryEndDatePicker.Size = new System.Drawing.Size(243, 23);
            this.orderDeliveryEndDatePicker.TabIndex = 31;
            this.orderDeliveryEndDatePicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblDeliveryEndDate
            // 
            this.lblDeliveryEndDate.AutoSize = true;
            this.lblDeliveryEndDate.Location = new System.Drawing.Point(360, 63);
            this.lblDeliveryEndDate.Name = "lblDeliveryEndDate";
            this.lblDeliveryEndDate.Size = new System.Drawing.Size(25, 15);
            this.lblDeliveryEndDate.TabIndex = 30;
            this.lblDeliveryEndDate.Text = "До:";
            // 
            // orderDeliveryStartDatePicker
            // 
            this.orderDeliveryStartDatePicker.Checked = false;
            this.orderDeliveryStartDatePicker.Location = new System.Drawing.Point(118, 59);
            this.orderDeliveryStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderDeliveryStartDatePicker.Name = "orderDeliveryStartDatePicker";
            this.orderDeliveryStartDatePicker.ShowCheckBox = true;
            this.orderDeliveryStartDatePicker.Size = new System.Drawing.Size(236, 23);
            this.orderDeliveryStartDatePicker.TabIndex = 29;
            this.orderDeliveryStartDatePicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderDeliveryStartDatePicker
            // 
            this.lblOrderDeliveryStartDatePicker.AutoSize = true;
            this.lblOrderDeliveryStartDatePicker.Location = new System.Drawing.Point(3, 63);
            this.lblOrderDeliveryStartDatePicker.Name = "lblOrderDeliveryStartDatePicker";
            this.lblOrderDeliveryStartDatePicker.Size = new System.Drawing.Size(98, 15);
            this.lblOrderDeliveryStartDatePicker.TabIndex = 28;
            this.lblOrderDeliveryStartDatePicker.Text = "Дата отправки с:";
            // 
            // orderEndDatePicker
            // 
            this.orderEndDatePicker.Checked = false;
            this.orderEndDatePicker.Location = new System.Drawing.Point(392, 31);
            this.orderEndDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderEndDatePicker.Name = "orderEndDatePicker";
            this.orderEndDatePicker.ShowCheckBox = true;
            this.orderEndDatePicker.Size = new System.Drawing.Size(243, 23);
            this.orderEndDatePicker.TabIndex = 27;
            this.orderEndDatePicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderEndDate
            // 
            this.lblOrderEndDate.AutoSize = true;
            this.lblOrderEndDate.Location = new System.Drawing.Point(360, 32);
            this.lblOrderEndDate.Name = "lblOrderEndDate";
            this.lblOrderEndDate.Size = new System.Drawing.Size(25, 15);
            this.lblOrderEndDate.TabIndex = 26;
            this.lblOrderEndDate.Text = "До:";
            // 
            // orderStartDatePicker
            // 
            this.orderStartDatePicker.Checked = false;
            this.orderStartDatePicker.Location = new System.Drawing.Point(118, 31);
            this.orderStartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderStartDatePicker.Name = "orderStartDatePicker";
            this.orderStartDatePicker.ShowCheckBox = true;
            this.orderStartDatePicker.Size = new System.Drawing.Size(236, 23);
            this.orderStartDatePicker.TabIndex = 25;
            this.orderStartDatePicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderstartDate
            // 
            this.lblOrderstartDate.AutoSize = true;
            this.lblOrderstartDate.Location = new System.Drawing.Point(3, 36);
            this.lblOrderstartDate.Name = "lblOrderstartDate";
            this.lblOrderstartDate.Size = new System.Drawing.Size(81, 15);
            this.lblOrderstartDate.TabIndex = 24;
            this.lblOrderstartDate.Text = "Дата заказа с:";
            // 
            // btnUnconfirmOrder
            // 
            this.btnUnconfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnconfirmOrder.Location = new System.Drawing.Point(1148, 320);
            this.btnUnconfirmOrder.Name = "btnUnconfirmOrder";
            this.btnUnconfirmOrder.Size = new System.Drawing.Size(105, 43);
            this.btnUnconfirmOrder.TabIndex = 23;
            this.btnUnconfirmOrder.Text = "Заказ не согласован";
            this.btnUnconfirmOrder.UseVisualStyleBackColor = true;
            this.btnUnconfirmOrder.Click += new System.EventHandler(this.BtnUnconfirmOrder_Click);
            // 
            // txtClientNameFilter
            // 
            this.txtClientNameFilter.Location = new System.Drawing.Point(415, 86);
            this.txtClientNameFilter.Name = "txtClientNameFilter";
            this.txtClientNameFilter.Size = new System.Drawing.Size(194, 23);
            this.txtClientNameFilter.TabIndex = 22;
            this.txtClientNameFilter.TextChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderSum
            // 
            this.lblOrderSum.AutoSize = true;
            this.lblOrderSum.Location = new System.Drawing.Point(1009, 157);
            this.lblOrderSum.Name = "lblOrderSum";
            this.lblOrderSum.Size = new System.Drawing.Size(154, 15);
            this.lblOrderSum.TabIndex = 21;
            this.lblOrderSum.Text = "Общая стоимость заказов:";
            // 
            // lblPlotting
            // 
            this.lblPlotting.AutoSize = true;
            this.lblPlotting.Location = new System.Drawing.Point(308, 157);
            this.lblPlotting.Name = "lblPlotting";
            this.lblPlotting.Size = new System.Drawing.Size(75, 15);
            this.lblPlotting.TabIndex = 20;
            this.lblPlotting.Text = "Всего резки:";
            // 
            // lblLaminationArea
            // 
            this.lblLaminationArea.AutoSize = true;
            this.lblLaminationArea.Location = new System.Drawing.Point(803, 157);
            this.lblLaminationArea.Name = "lblLaminationArea";
            this.lblLaminationArea.Size = new System.Drawing.Size(118, 15);
            this.lblLaminationArea.TabIndex = 19;
            this.lblLaminationArea.Text = "Метров ламинации:";
            // 
            // lblPrintingArea
            // 
            this.lblPrintingArea.AutoSize = true;
            this.lblPrintingArea.Location = new System.Drawing.Point(616, 157);
            this.lblPrintingArea.Name = "lblPrintingArea";
            this.lblPrintingArea.Size = new System.Drawing.Size(93, 15);
            this.lblPrintingArea.TabIndex = 18;
            this.lblPrintingArea.Text = "Метров печати:";
            // 
            // lblPaperCount
            // 
            this.lblPaperCount.AutoSize = true;
            this.lblPaperCount.Location = new System.Drawing.Point(477, 157);
            this.lblPaperCount.Name = "lblPaperCount";
            this.lblPaperCount.Size = new System.Drawing.Size(82, 15);
            this.lblPaperCount.TabIndex = 17;
            this.lblPaperCount.Text = "Всего листов:";
            // 
            // lblLayoutsCount
            // 
            this.lblLayoutsCount.AutoSize = true;
            this.lblLayoutsCount.Location = new System.Drawing.Point(140, 157);
            this.lblLayoutsCount.Name = "lblLayoutsCount";
            this.lblLayoutsCount.Size = new System.Drawing.Size(89, 15);
            this.lblLayoutsCount.TabIndex = 16;
            this.lblLayoutsCount.Text = "Всего макетов:";
            // 
            // lblOrdersCount
            // 
            this.lblOrdersCount.AutoSize = true;
            this.lblOrdersCount.Location = new System.Drawing.Point(3, 157);
            this.lblOrdersCount.Name = "lblOrdersCount";
            this.lblOrdersCount.Size = new System.Drawing.Size(85, 15);
            this.lblOrdersCount.TabIndex = 15;
            this.lblOrdersCount.Text = "Всего заказов:";
            // 
            // btnArchiveOrder
            // 
            this.btnArchiveOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchiveOrder.Location = new System.Drawing.Point(1148, 370);
            this.btnArchiveOrder.Name = "btnArchiveOrder";
            this.btnArchiveOrder.Size = new System.Drawing.Size(105, 43);
            this.btnArchiveOrder.TabIndex = 14;
            this.btnArchiveOrder.Text = "Заархивировать заказ";
            this.btnArchiveOrder.UseVisualStyleBackColor = true;
            this.btnArchiveOrder.Click += new System.EventHandler(this.BtnArchiveOrder_Click);
            // 
            // paymentComboBox
            // 
            this.paymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentComboBox.FormattingEnabled = true;
            this.paymentComboBox.Location = new System.Drawing.Point(382, 111);
            this.paymentComboBox.Name = "paymentComboBox";
            this.paymentComboBox.Size = new System.Drawing.Size(180, 23);
            this.paymentComboBox.TabIndex = 13;
            this.paymentComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(326, 114);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(50, 15);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "Оплата:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(648, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 15);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(326, 88);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(81, 15);
            this.lblClientName.TabIndex = 8;
            this.lblClientName.Text = "Имя клиента:";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(1148, 275);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(105, 40);
            this.btnConfirmOrder.TabIndex = 5;
            this.btnConfirmOrder.Text = "Заказ согласован";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.BtnConfirmOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(1148, 475);
            this.btnDeleteOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(105, 45);
            this.btnDeleteOrder.TabIndex = 3;
            this.btnDeleteOrder.Text = "Удалить заказ";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.BtnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOrder.Location = new System.Drawing.Point(1148, 224);
            this.btnEditOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(105, 45);
            this.btnEditOrder.TabIndex = 2;
            this.btnEditOrder.Text = "Изменить\r\nзаказ";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.BtnEditOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrder.Location = new System.Drawing.Point(1148, 175);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(105, 44);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Добавить\r\nзаказ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // ordersGrid
            // 
            this.ordersGrid.AllowUserToAddRows = false;
            this.ordersGrid.AllowUserToDeleteRows = false;
            this.ordersGrid.AllowUserToResizeColumns = false;
            this.ordersGrid.AllowUserToResizeRows = false;
            this.ordersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGrid.Location = new System.Drawing.Point(3, 175);
            this.ordersGrid.Name = "ordersGrid";
            this.ordersGrid.ReadOnly = true;
            this.ordersGrid.RowHeadersVisible = false;
            this.ordersGrid.RowHeadersWidth = 51;
            this.ordersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersGrid.Size = new System.Drawing.Size(1140, 344);
            this.ordersGrid.TabIndex = 0;
            this.ordersGrid.Text = "dataGridView1";
            this.ordersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersGrid_CellClick);
            this.ordersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellDoubleClick);
            this.ordersGrid.SelectionChanged += new System.EventHandler(this.OrdersGrid_SelectionChanged);
            // 
            // layoutsTab
            // 
            this.layoutsTab.Controls.Add(this.lblLayoutsTabLayoutsTotal);
            this.layoutsTab.Controls.Add(this.lblContourDrawAverageTime);
            this.layoutsTab.Controls.Add(this.lblAveragePlottingLength);
            this.layoutsTab.Controls.Add(this.lblAveragePaperParameters);
            this.layoutsTab.Controls.Add(this.statusForDesignerCombobox);
            this.layoutsTab.Controls.Add(this.lblStatusForDesigner);
            this.layoutsTab.Controls.Add(this.orderIdForDesignerCombobox);
            this.layoutsTab.Controls.Add(this.lblOrderId);
            this.layoutsTab.Controls.Add(this.btnOpenContoursFolder);
            this.layoutsTab.Controls.Add(this.btnOpenSources);
            this.layoutsTab.Controls.Add(this.btnContourToRevision);
            this.layoutsTab.Controls.Add(this.btnLoadContour);
            this.layoutsTab.Controls.Add(this.layoutsGrid);
            this.layoutsTab.Location = new System.Drawing.Point(4, 24);
            this.layoutsTab.Name = "layoutsTab";
            this.layoutsTab.Size = new System.Drawing.Size(1265, 523);
            this.layoutsTab.TabIndex = 6;
            this.layoutsTab.Text = "Работа с макетами";
            // 
            // lblLayoutsTabLayoutsTotal
            // 
            this.lblLayoutsTabLayoutsTotal.AutoSize = true;
            this.lblLayoutsTabLayoutsTotal.Location = new System.Drawing.Point(505, 9);
            this.lblLayoutsTabLayoutsTotal.Name = "lblLayoutsTabLayoutsTotal";
            this.lblLayoutsTabLayoutsTotal.Size = new System.Drawing.Size(89, 15);
            this.lblLayoutsTabLayoutsTotal.TabIndex = 12;
            this.lblLayoutsTabLayoutsTotal.Text = "Всего макетов:";
            // 
            // lblContourDrawAverageTime
            // 
            this.lblContourDrawAverageTime.AutoSize = true;
            this.lblContourDrawAverageTime.Location = new System.Drawing.Point(623, 35);
            this.lblContourDrawAverageTime.Name = "lblContourDrawAverageTime";
            this.lblContourDrawAverageTime.Size = new System.Drawing.Size(195, 15);
            this.lblContourDrawAverageTime.TabIndex = 11;
            this.lblContourDrawAverageTime.Text = "Среднее время отрисовки макета:";
            // 
            // lblAveragePlottingLength
            // 
            this.lblAveragePlottingLength.AutoSize = true;
            this.lblAveragePlottingLength.Location = new System.Drawing.Point(311, 35);
            this.lblAveragePlottingLength.Name = "lblAveragePlottingLength";
            this.lblAveragePlottingLength.Size = new System.Drawing.Size(126, 15);
            this.lblAveragePlottingLength.TabIndex = 10;
            this.lblAveragePlottingLength.Text = "Средняя длина резки:";
            // 
            // lblAveragePaperParameters
            // 
            this.lblAveragePaperParameters.AutoSize = true;
            this.lblAveragePaperParameters.Location = new System.Drawing.Point(3, 35);
            this.lblAveragePaperParameters.Name = "lblAveragePaperParameters";
            this.lblAveragePaperParameters.Size = new System.Drawing.Size(135, 15);
            this.lblAveragePaperParameters.TabIndex = 9;
            this.lblAveragePaperParameters.Text = "Средний размер листа:";
            // 
            // statusForDesignerCombobox
            // 
            this.statusForDesignerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusForDesignerCombobox.FormattingEnabled = true;
            this.statusForDesignerCombobox.Location = new System.Drawing.Point(273, 6);
            this.statusForDesignerCombobox.Name = "statusForDesignerCombobox";
            this.statusForDesignerCombobox.Size = new System.Drawing.Size(206, 23);
            this.statusForDesignerCombobox.TabIndex = 8;
            this.statusForDesignerCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterOrderItemsForDesignerEvent);
            // 
            // lblStatusForDesigner
            // 
            this.lblStatusForDesigner.AutoSize = true;
            this.lblStatusForDesigner.Location = new System.Drawing.Point(221, 9);
            this.lblStatusForDesigner.Name = "lblStatusForDesigner";
            this.lblStatusForDesigner.Size = new System.Drawing.Size(46, 15);
            this.lblStatusForDesigner.TabIndex = 7;
            this.lblStatusForDesigner.Text = "Статус:";
            // 
            // orderIdForDesignerCombobox
            // 
            this.orderIdForDesignerCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderIdForDesignerCombobox.FormattingEnabled = true;
            this.orderIdForDesignerCombobox.Location = new System.Drawing.Point(94, 6);
            this.orderIdForDesignerCombobox.Name = "orderIdForDesignerCombobox";
            this.orderIdForDesignerCombobox.Size = new System.Drawing.Size(122, 23);
            this.orderIdForDesignerCombobox.TabIndex = 6;
            this.orderIdForDesignerCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterOrderItemsForDesignerEvent);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(3, 9);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(85, 15);
            this.lblOrderId.TabIndex = 5;
            this.lblOrderId.Text = "Номер заказа:";
            // 
            // btnOpenContoursFolder
            // 
            this.btnOpenContoursFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenContoursFolder.Location = new System.Drawing.Point(1155, 53);
            this.btnOpenContoursFolder.Name = "btnOpenContoursFolder";
            this.btnOpenContoursFolder.Size = new System.Drawing.Size(106, 46);
            this.btnOpenContoursFolder.TabIndex = 4;
            this.btnOpenContoursFolder.Text = "Открыть контуры";
            this.btnOpenContoursFolder.UseVisualStyleBackColor = true;
            this.btnOpenContoursFolder.Click += new System.EventHandler(this.BtnOpenContoursFolder_Click);
            // 
            // btnOpenSources
            // 
            this.btnOpenSources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSources.Location = new System.Drawing.Point(1155, 102);
            this.btnOpenSources.Name = "btnOpenSources";
            this.btnOpenSources.Size = new System.Drawing.Size(106, 51);
            this.btnOpenSources.TabIndex = 3;
            this.btnOpenSources.Text = "Открыть исходники";
            this.btnOpenSources.UseVisualStyleBackColor = true;
            this.btnOpenSources.Click += new System.EventHandler(this.BtnOpenSources_Click);
            // 
            // btnContourToRevision
            // 
            this.btnContourToRevision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContourToRevision.Location = new System.Drawing.Point(1155, 218);
            this.btnContourToRevision.Name = "btnContourToRevision";
            this.btnContourToRevision.Size = new System.Drawing.Size(106, 66);
            this.btnContourToRevision.TabIndex = 2;
            this.btnContourToRevision.Text = "Отправить контур на доработку";
            this.btnContourToRevision.UseVisualStyleBackColor = true;
            this.btnContourToRevision.Click += new System.EventHandler(this.BtnContourToRevision_Click);
            // 
            // btnLoadContour
            // 
            this.btnLoadContour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContour.Location = new System.Drawing.Point(1155, 159);
            this.btnLoadContour.Name = "btnLoadContour";
            this.btnLoadContour.Size = new System.Drawing.Size(106, 53);
            this.btnLoadContour.TabIndex = 1;
            this.btnLoadContour.Text = "Загрузить контур";
            this.btnLoadContour.UseVisualStyleBackColor = true;
            this.btnLoadContour.Click += new System.EventHandler(this.BtnLoadContour_Click);
            // 
            // layoutsGrid
            // 
            this.layoutsGrid.AllowUserToAddRows = false;
            this.layoutsGrid.AllowUserToDeleteRows = false;
            this.layoutsGrid.AllowUserToResizeColumns = false;
            this.layoutsGrid.AllowUserToResizeRows = false;
            this.layoutsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.layoutsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layoutsGrid.Location = new System.Drawing.Point(3, 53);
            this.layoutsGrid.MultiSelect = false;
            this.layoutsGrid.Name = "layoutsGrid";
            this.layoutsGrid.ReadOnly = true;
            this.layoutsGrid.RowHeadersVisible = false;
            this.layoutsGrid.RowHeadersWidth = 51;
            this.layoutsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.layoutsGrid.Size = new System.Drawing.Size(1147, 467);
            this.layoutsGrid.TabIndex = 0;
            this.layoutsGrid.Text = "dataGridView1";
            // 
            // clientsTab
            // 
            this.clientsTab.Controls.Add(this.tableLayoutPanel1);
            this.clientsTab.Controls.Add(this.buttonDlg);
            this.clientsTab.Controls.Add(this.btnOpenVkGroupLink);
            this.clientsTab.Controls.Add(this.btnDeleteClient);
            this.clientsTab.Controls.Add(this.btnEditClient);
            this.clientsTab.Controls.Add(this.btnAddClient);
            this.clientsTab.Controls.Add(this.clientsGrid);
            this.clientsTab.Location = new System.Drawing.Point(4, 24);
            this.clientsTab.Name = "clientsTab";
            this.clientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTab.Size = new System.Drawing.Size(1265, 523);
            this.clientsTab.TabIndex = 1;
            this.clientsTab.Text = "Клиенты";
            this.clientsTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblClientFilterByName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCom, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClientFilterByName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFio, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxGrVk, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVkGrLnk, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1259, 29);
            this.tableLayoutPanel1.TabIndex = 90;
            // 
            // lblClientFilterByName
            // 
            this.lblClientFilterByName.Location = new System.Drawing.Point(3, 0);
            this.lblClientFilterByName.Name = "lblClientFilterByName";
            this.lblClientFilterByName.Size = new System.Drawing.Size(81, 15);
            this.lblClientFilterByName.TabIndex = 4;
            this.lblClientFilterByName.Text = "Имя клиента:";
            this.lblClientFilterByName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCom
            // 
            this.textBoxCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCom.Location = new System.Drawing.Point(1054, 3);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(202, 23);
            this.textBoxCom.TabIndex = 89;
            this.textBoxCom.TextChanged += new System.EventHandler(this.FilterClientsEvent);
            // 
            // txtClientFilterByName
            // 
            this.txtClientFilterByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtClientFilterByName.Location = new System.Drawing.Point(90, 3);
            this.txtClientFilterByName.Name = "txtClientFilterByName";
            this.txtClientFilterByName.Size = new System.Drawing.Size(119, 23);
            this.txtClientFilterByName.TabIndex = 5;
            this.txtClientFilterByName.TextChanged += new System.EventHandler(this.FilterClientsEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 88;
            this.label4.Text = "Комментарий:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 82;
            this.label1.Text = "Название группы ВК:";
            // 
            // textBoxFio
            // 
            this.textBoxFio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFio.Location = new System.Drawing.Point(836, 3);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(119, 23);
            this.textBoxFio.TabIndex = 87;
            this.textBoxFio.TextChanged += new System.EventHandler(this.FilterClientsEvent);
            // 
            // textBoxGrVk
            // 
            this.textBoxGrVk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxGrVk.Location = new System.Drawing.Point(344, 3);
            this.textBoxGrVk.Name = "textBoxGrVk";
            this.textBoxGrVk.Size = new System.Drawing.Size(119, 23);
            this.textBoxGrVk.TabIndex = 83;
            this.textBoxGrVk.TextChanged += new System.EventHandler(this.FilterClientsEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "ФИО получателя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 84;
            this.label2.Text = "Ссылка на группу ВК:";
            // 
            // textBoxVkGrLnk
            // 
            this.textBoxVkGrLnk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVkGrLnk.Location = new System.Drawing.Point(601, 3);
            this.textBoxVkGrLnk.Name = "textBoxVkGrLnk";
            this.textBoxVkGrLnk.Size = new System.Drawing.Size(119, 23);
            this.textBoxVkGrLnk.TabIndex = 85;
            this.textBoxVkGrLnk.TextChanged += new System.EventHandler(this.FilterClientsEvent);
            // 
            // buttonDlg
            // 
            this.buttonDlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDlg.Location = new System.Drawing.Point(1178, 123);
            this.buttonDlg.Name = "buttonDlg";
            this.buttonDlg.Size = new System.Drawing.Size(83, 39);
            this.buttonDlg.TabIndex = 81;
            this.buttonDlg.Text = "Открыть\r\nдиалог";
            this.buttonDlg.UseVisualStyleBackColor = true;
            this.buttonDlg.Click += new System.EventHandler(this.Clients_DlgClick);
            // 
            // btnOpenVkGroupLink
            // 
            this.btnOpenVkGroupLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenVkGroupLink.AutoSize = true;
            this.btnOpenVkGroupLink.Location = new System.Drawing.Point(1178, 168);
            this.btnOpenVkGroupLink.Name = "btnOpenVkGroupLink";
            this.btnOpenVkGroupLink.Size = new System.Drawing.Size(84, 40);
            this.btnOpenVkGroupLink.TabIndex = 80;
            this.btnOpenVkGroupLink.Text = "Открыть\r\nгруппу";
            this.btnOpenVkGroupLink.UseVisualStyleBackColor = true;
            this.btnOpenVkGroupLink.Click += new System.EventHandler(this.btnOpenVkGroupLink_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteClient.Location = new System.Drawing.Point(1178, 94);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteClient.TabIndex = 3;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.BtnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditClient.Location = new System.Drawing.Point(1178, 65);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(83, 23);
            this.btnEditClient.TabIndex = 2;
            this.btnEditClient.Text = "Изменить";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.BtnEditClient_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClient.Location = new System.Drawing.Point(1178, 36);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(83, 23);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Добавить";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // clientsGrid
            // 
            this.clientsGrid.AllowUserToAddRows = false;
            this.clientsGrid.AllowUserToDeleteRows = false;
            this.clientsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Location = new System.Drawing.Point(3, 41);
            this.clientsGrid.MultiSelect = false;
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.ReadOnly = true;
            this.clientsGrid.RowHeadersVisible = false;
            this.clientsGrid.RowHeadersWidth = 51;
            this.clientsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.clientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsGrid.Size = new System.Drawing.Size(1169, 479);
            this.clientsGrid.TabIndex = 0;
            this.clientsGrid.Text = "dataGridView1";
            this.clientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGrid_CellClick);
            this.clientsGrid.CurrentCellChanged += new System.EventHandler(this.clientsGrid_CurrentCellChanged);
            // 
            // costsTab
            // 
            this.costsTab.Controls.Add(this.btnDeleteCost);
            this.costsTab.Controls.Add(this.btnEditCost);
            this.costsTab.Controls.Add(this.btnAddCost);
            this.costsTab.Controls.Add(this.costsGrid);
            this.costsTab.Location = new System.Drawing.Point(4, 24);
            this.costsTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costsTab.Name = "costsTab";
            this.costsTab.Size = new System.Drawing.Size(1265, 523);
            this.costsTab.TabIndex = 2;
            this.costsTab.Text = "Затраты";
            // 
            // btnDeleteCost
            // 
            this.btnDeleteCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCost.Location = new System.Drawing.Point(1155, 54);
            this.btnDeleteCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCost.Name = "btnDeleteCost";
            this.btnDeleteCost.Size = new System.Drawing.Size(106, 22);
            this.btnDeleteCost.TabIndex = 3;
            this.btnDeleteCost.Text = "Удалить";
            this.btnDeleteCost.UseVisualStyleBackColor = true;
            this.btnDeleteCost.Click += new System.EventHandler(this.BtnDeleteCost_Click);
            // 
            // btnEditCost
            // 
            this.btnEditCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCost.Location = new System.Drawing.Point(1155, 28);
            this.btnEditCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCost.Name = "btnEditCost";
            this.btnEditCost.Size = new System.Drawing.Size(106, 22);
            this.btnEditCost.TabIndex = 2;
            this.btnEditCost.Text = "Изменить";
            this.btnEditCost.UseVisualStyleBackColor = true;
            this.btnEditCost.Click += new System.EventHandler(this.BtnEditCost_Click);
            // 
            // btnAddCost
            // 
            this.btnAddCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCost.Location = new System.Drawing.Point(1155, 2);
            this.btnAddCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(106, 22);
            this.btnAddCost.TabIndex = 1;
            this.btnAddCost.Text = "Добавить";
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.BtnAddCost_Click);
            // 
            // costsGrid
            // 
            this.costsGrid.AllowUserToAddRows = false;
            this.costsGrid.AllowUserToDeleteRows = false;
            this.costsGrid.AllowUserToResizeColumns = false;
            this.costsGrid.AllowUserToResizeRows = false;
            this.costsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.costsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costsGrid.Location = new System.Drawing.Point(3, 2);
            this.costsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costsGrid.MultiSelect = false;
            this.costsGrid.Name = "costsGrid";
            this.costsGrid.ReadOnly = true;
            this.costsGrid.RowHeadersVisible = false;
            this.costsGrid.RowHeadersWidth = 51;
            this.costsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.costsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.costsGrid.Size = new System.Drawing.Size(1147, 519);
            this.costsGrid.TabIndex = 0;
            this.costsGrid.Text = "dataGridView1";
            this.costsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.СostsGrid_CellFormatting);
            // 
            // deliveryTab
            // 
            this.deliveryTab.Controls.Add(this.button1);
            this.deliveryTab.Controls.Add(this.lblDeliveryOrdersTotal);
            this.deliveryTab.Controls.Add(this.deliveryEndDateFilterPicker);
            this.deliveryTab.Controls.Add(this.lblDeliveryEndDateFilter);
            this.deliveryTab.Controls.Add(this.deliveryStartDateFilterPicker);
            this.deliveryTab.Controls.Add(this.lblDeliveryStartDateFilter);
            this.deliveryTab.Controls.Add(this.deliveryMethodComboboxFilter);
            this.deliveryTab.Controls.Add(this.lblDeliveryMethodFilter);
            this.deliveryTab.Controls.Add(this.deliveryStatusComboboxFilter);
            this.deliveryTab.Controls.Add(this.lblDeliveryStatusFilter);
            this.deliveryTab.Controls.Add(this.txtDeliveryTrackNumberFilter);
            this.deliveryTab.Controls.Add(this.lblDeliveryTrackNumberFilter);
            this.deliveryTab.Controls.Add(this.txtDeliveryClientNameFilter);
            this.deliveryTab.Controls.Add(this.lblDeliveryClientFilter);
            this.deliveryTab.Controls.Add(this.txtDeliveryOrderIdFilter);
            this.deliveryTab.Controls.Add(this.lblDeliveryOrderIdFilter);
            this.deliveryTab.Controls.Add(this.btnCheckDelivery);
            this.deliveryTab.Controls.Add(this.btnAddDeliveryInfo);
            this.deliveryTab.Controls.Add(this.deliveryGrid);
            this.deliveryTab.Location = new System.Drawing.Point(4, 24);
            this.deliveryTab.Name = "deliveryTab";
            this.deliveryTab.Size = new System.Drawing.Size(1265, 523);
            this.deliveryTab.TabIndex = 3;
            this.deliveryTab.Text = "Доставка";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1155, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 55);
            this.button1.TabIndex = 18;
            this.button1.Text = "Напечатать адресные этикетки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDeliveryOrdersTotal
            // 
            this.lblDeliveryOrdersTotal.AutoSize = true;
            this.lblDeliveryOrdersTotal.Location = new System.Drawing.Point(811, 42);
            this.lblDeliveryOrdersTotal.Name = "lblDeliveryOrdersTotal";
            this.lblDeliveryOrdersTotal.Size = new System.Drawing.Size(85, 15);
            this.lblDeliveryOrdersTotal.TabIndex = 17;
            this.lblDeliveryOrdersTotal.Text = "Всего заказов:";
            // 
            // deliveryEndDateFilterPicker
            // 
            this.deliveryEndDateFilterPicker.Checked = false;
            this.deliveryEndDateFilterPicker.Location = new System.Drawing.Point(356, 66);
            this.deliveryEndDateFilterPicker.Name = "deliveryEndDateFilterPicker";
            this.deliveryEndDateFilterPicker.ShowCheckBox = true;
            this.deliveryEndDateFilterPicker.Size = new System.Drawing.Size(236, 23);
            this.deliveryEndDateFilterPicker.TabIndex = 16;
            this.deliveryEndDateFilterPicker.ValueChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryEndDateFilter
            // 
            this.lblDeliveryEndDateFilter.AutoSize = true;
            this.lblDeliveryEndDateFilter.Location = new System.Drawing.Point(325, 71);
            this.lblDeliveryEndDateFilter.Name = "lblDeliveryEndDateFilter";
            this.lblDeliveryEndDateFilter.Size = new System.Drawing.Size(25, 15);
            this.lblDeliveryEndDateFilter.TabIndex = 15;
            this.lblDeliveryEndDateFilter.Text = "До:";
            // 
            // deliveryStartDateFilterPicker
            // 
            this.deliveryStartDateFilterPicker.Checked = false;
            this.deliveryStartDateFilterPicker.Location = new System.Drawing.Point(90, 66);
            this.deliveryStartDateFilterPicker.Name = "deliveryStartDateFilterPicker";
            this.deliveryStartDateFilterPicker.ShowCheckBox = true;
            this.deliveryStartDateFilterPicker.Size = new System.Drawing.Size(229, 23);
            this.deliveryStartDateFilterPicker.TabIndex = 14;
            this.deliveryStartDateFilterPicker.ValueChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryStartDateFilter
            // 
            this.lblDeliveryStartDateFilter.AutoSize = true;
            this.lblDeliveryStartDateFilter.Location = new System.Drawing.Point(4, 72);
            this.lblDeliveryStartDateFilter.Name = "lblDeliveryStartDateFilter";
            this.lblDeliveryStartDateFilter.Size = new System.Drawing.Size(79, 15);
            this.lblDeliveryStartDateFilter.TabIndex = 13;
            this.lblDeliveryStartDateFilter.Text = "Отправлен с:";
            // 
            // deliveryMethodComboboxFilter
            // 
            this.deliveryMethodComboboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryMethodComboboxFilter.FormattingEnabled = true;
            this.deliveryMethodComboboxFilter.Location = new System.Drawing.Point(363, 35);
            this.deliveryMethodComboboxFilter.Name = "deliveryMethodComboboxFilter";
            this.deliveryMethodComboboxFilter.Size = new System.Drawing.Size(215, 23);
            this.deliveryMethodComboboxFilter.TabIndex = 12;
            this.deliveryMethodComboboxFilter.SelectedIndexChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryMethodFilter
            // 
            this.lblDeliveryMethodFilter.AutoSize = true;
            this.lblDeliveryMethodFilter.Location = new System.Drawing.Point(251, 38);
            this.lblDeliveryMethodFilter.Name = "lblDeliveryMethodFilter";
            this.lblDeliveryMethodFilter.Size = new System.Drawing.Size(106, 15);
            this.lblDeliveryMethodFilter.TabIndex = 11;
            this.lblDeliveryMethodFilter.Text = "Способ отправки:";
            // 
            // deliveryStatusComboboxFilter
            // 
            this.deliveryStatusComboboxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryStatusComboboxFilter.FormattingEnabled = true;
            this.deliveryStatusComboboxFilter.Location = new System.Drawing.Point(56, 35);
            this.deliveryStatusComboboxFilter.Name = "deliveryStatusComboboxFilter";
            this.deliveryStatusComboboxFilter.Size = new System.Drawing.Size(187, 23);
            this.deliveryStatusComboboxFilter.TabIndex = 10;
            this.deliveryStatusComboboxFilter.SelectedIndexChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryStatusFilter
            // 
            this.lblDeliveryStatusFilter.AutoSize = true;
            this.lblDeliveryStatusFilter.Location = new System.Drawing.Point(4, 38);
            this.lblDeliveryStatusFilter.Name = "lblDeliveryStatusFilter";
            this.lblDeliveryStatusFilter.Size = new System.Drawing.Size(46, 15);
            this.lblDeliveryStatusFilter.TabIndex = 9;
            this.lblDeliveryStatusFilter.Text = "Статус:";
            // 
            // txtDeliveryTrackNumberFilter
            // 
            this.txtDeliveryTrackNumberFilter.Location = new System.Drawing.Point(582, 7);
            this.txtDeliveryTrackNumberFilter.Name = "txtDeliveryTrackNumberFilter";
            this.txtDeliveryTrackNumberFilter.Size = new System.Drawing.Size(211, 23);
            this.txtDeliveryTrackNumberFilter.TabIndex = 8;
            this.txtDeliveryTrackNumberFilter.TextChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryTrackNumberFilter
            // 
            this.lblDeliveryTrackNumberFilter.AutoSize = true;
            this.lblDeliveryTrackNumberFilter.Location = new System.Drawing.Point(500, 10);
            this.lblDeliveryTrackNumberFilter.Name = "lblDeliveryTrackNumberFilter";
            this.lblDeliveryTrackNumberFilter.Size = new System.Drawing.Size(76, 15);
            this.lblDeliveryTrackNumberFilter.TabIndex = 7;
            this.lblDeliveryTrackNumberFilter.Text = "Трэк-номер:";
            // 
            // txtDeliveryClientNameFilter
            // 
            this.txtDeliveryClientNameFilter.Location = new System.Drawing.Point(304, 7);
            this.txtDeliveryClientNameFilter.Name = "txtDeliveryClientNameFilter";
            this.txtDeliveryClientNameFilter.Size = new System.Drawing.Size(189, 23);
            this.txtDeliveryClientNameFilter.TabIndex = 6;
            this.txtDeliveryClientNameFilter.TextChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryClientFilter
            // 
            this.lblDeliveryClientFilter.AutoSize = true;
            this.lblDeliveryClientFilter.Location = new System.Drawing.Point(217, 10);
            this.lblDeliveryClientFilter.Name = "lblDeliveryClientFilter";
            this.lblDeliveryClientFilter.Size = new System.Drawing.Size(81, 15);
            this.lblDeliveryClientFilter.TabIndex = 5;
            this.lblDeliveryClientFilter.Text = "Имя клиента:";
            // 
            // txtDeliveryOrderIdFilter
            // 
            this.txtDeliveryOrderIdFilter.Location = new System.Drawing.Point(94, 7);
            this.txtDeliveryOrderIdFilter.Name = "txtDeliveryOrderIdFilter";
            this.txtDeliveryOrderIdFilter.Size = new System.Drawing.Size(117, 23);
            this.txtDeliveryOrderIdFilter.TabIndex = 4;
            this.txtDeliveryOrderIdFilter.TextChanged += new System.EventHandler(this.FilterDeliveryOrdersEvent);
            // 
            // lblDeliveryOrderIdFilter
            // 
            this.lblDeliveryOrderIdFilter.AutoSize = true;
            this.lblDeliveryOrderIdFilter.Location = new System.Drawing.Point(3, 10);
            this.lblDeliveryOrderIdFilter.Name = "lblDeliveryOrderIdFilter";
            this.lblDeliveryOrderIdFilter.Size = new System.Drawing.Size(85, 15);
            this.lblDeliveryOrderIdFilter.TabIndex = 3;
            this.lblDeliveryOrderIdFilter.Text = "Номер заказа:";
            // 
            // btnCheckDelivery
            // 
            this.btnCheckDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckDelivery.Location = new System.Drawing.Point(1155, 169);
            this.btnCheckDelivery.Name = "btnCheckDelivery";
            this.btnCheckDelivery.Size = new System.Drawing.Size(106, 43);
            this.btnCheckDelivery.TabIndex = 2;
            this.btnCheckDelivery.Text = "Отметить отправку";
            this.btnCheckDelivery.UseVisualStyleBackColor = true;
            this.btnCheckDelivery.Click += new System.EventHandler(this.BtnCheckDelivery_Click);
            // 
            // btnAddDeliveryInfo
            // 
            this.btnAddDeliveryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDeliveryInfo.Location = new System.Drawing.Point(1155, 95);
            this.btnAddDeliveryInfo.Name = "btnAddDeliveryInfo";
            this.btnAddDeliveryInfo.Size = new System.Drawing.Size(106, 68);
            this.btnAddDeliveryInfo.TabIndex = 1;
            this.btnAddDeliveryInfo.Text = "Заполнить информацию по отправке";
            this.btnAddDeliveryInfo.UseVisualStyleBackColor = true;
            this.btnAddDeliveryInfo.Click += new System.EventHandler(this.BtnAddDeliveryInfo_Click);
            // 
            // deliveryGrid
            // 
            this.deliveryGrid.AllowUserToAddRows = false;
            this.deliveryGrid.AllowUserToDeleteRows = false;
            this.deliveryGrid.AllowUserToResizeRows = false;
            this.deliveryGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deliveryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryGrid.Location = new System.Drawing.Point(3, 95);
            this.deliveryGrid.Name = "deliveryGrid";
            this.deliveryGrid.ReadOnly = true;
            this.deliveryGrid.RowHeadersVisible = false;
            this.deliveryGrid.RowHeadersWidth = 51;
            this.deliveryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deliveryGrid.Size = new System.Drawing.Size(1147, 425);
            this.deliveryGrid.TabIndex = 0;
            this.deliveryGrid.Text = "dataGridView1";
            this.deliveryGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DeliveryGrid_CellMouseDoubleClick);
            // 
            // productionTab
            // 
            this.productionTab.Controls.Add(this.txtProductionOrderIdFilter);
            this.productionTab.Controls.Add(this.lblProductionOrderIdFilter);
            this.productionTab.Controls.Add(this.productionUrgencyFilterCombobox);
            this.productionTab.Controls.Add(this.lblProductionUrgencyFilter);
            this.productionTab.Controls.Add(this.lblProductionLaminationMeters);
            this.productionTab.Controls.Add(this.lblProductionPrintMeters);
            this.productionTab.Controls.Add(this.lblProductionPlotteringLength);
            this.productionTab.Controls.Add(this.lblProductionPaperCount);
            this.productionTab.Controls.Add(this.lblProductionLayoutsCount);
            this.productionTab.Controls.Add(this.lblProductionOrdersCount);
            this.productionTab.Controls.Add(this.txtClientNameProductionFilter);
            this.productionTab.Controls.Add(this.lblProductionClientName);
            this.productionTab.Controls.Add(this.btnCheckCutting);
            this.productionTab.Controls.Add(this.btnCheckPlottering);
            this.productionTab.Controls.Add(this.btnCheckLamination);
            this.productionTab.Controls.Add(this.btnCheckPrinting);
            this.productionTab.Controls.Add(this.btnOpenContours);
            this.productionTab.Controls.Add(this.productionGrid);
            this.productionTab.Controls.Add(this.cuttingTypeComboBox);
            this.productionTab.Controls.Add(this.lblCuttingType);
            this.productionTab.Controls.Add(this.laminationComboBox);
            this.productionTab.Controls.Add(this.lblLamination);
            this.productionTab.Controls.Add(this.lblFilm);
            this.productionTab.Controls.Add(this.filmComboBox);
            this.productionTab.Location = new System.Drawing.Point(4, 24);
            this.productionTab.Name = "productionTab";
            this.productionTab.Size = new System.Drawing.Size(1265, 523);
            this.productionTab.TabIndex = 5;
            this.productionTab.Text = "Производство";
            // 
            // txtProductionOrderIdFilter
            // 
            this.txtProductionOrderIdFilter.Location = new System.Drawing.Point(108, 34);
            this.txtProductionOrderIdFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductionOrderIdFilter.Name = "txtProductionOrderIdFilter";
            this.txtProductionOrderIdFilter.Size = new System.Drawing.Size(106, 23);
            this.txtProductionOrderIdFilter.TabIndex = 23;
            this.txtProductionOrderIdFilter.TextChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // lblProductionOrderIdFilter
            // 
            this.lblProductionOrderIdFilter.AutoSize = true;
            this.lblProductionOrderIdFilter.Location = new System.Drawing.Point(13, 35);
            this.lblProductionOrderIdFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductionOrderIdFilter.Name = "lblProductionOrderIdFilter";
            this.lblProductionOrderIdFilter.Size = new System.Drawing.Size(85, 15);
            this.lblProductionOrderIdFilter.TabIndex = 22;
            this.lblProductionOrderIdFilter.Text = "Номер заказа:";
            // 
            // productionUrgencyFilterCombobox
            // 
            this.productionUrgencyFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productionUrgencyFilterCombobox.FormattingEnabled = true;
            this.productionUrgencyFilterCombobox.Location = new System.Drawing.Point(1140, 3);
            this.productionUrgencyFilterCombobox.Name = "productionUrgencyFilterCombobox";
            this.productionUrgencyFilterCombobox.Size = new System.Drawing.Size(157, 23);
            this.productionUrgencyFilterCombobox.TabIndex = 21;
            this.productionUrgencyFilterCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // lblProductionUrgencyFilter
            // 
            this.lblProductionUrgencyFilter.AutoSize = true;
            this.lblProductionUrgencyFilter.Location = new System.Drawing.Point(1060, 6);
            this.lblProductionUrgencyFilter.Name = "lblProductionUrgencyFilter";
            this.lblProductionUrgencyFilter.Size = new System.Drawing.Size(73, 15);
            this.lblProductionUrgencyFilter.TabIndex = 20;
            this.lblProductionUrgencyFilter.Text = "Срочность: ";
            // 
            // lblProductionLaminationMeters
            // 
            this.lblProductionLaminationMeters.AutoSize = true;
            this.lblProductionLaminationMeters.Location = new System.Drawing.Point(526, 63);
            this.lblProductionLaminationMeters.Name = "lblProductionLaminationMeters";
            this.lblProductionLaminationMeters.Size = new System.Drawing.Size(107, 15);
            this.lblProductionLaminationMeters.TabIndex = 19;
            this.lblProductionLaminationMeters.Text = "Всего ламинации:";
            // 
            // lblProductionPrintMeters
            // 
            this.lblProductionPrintMeters.AutoSize = true;
            this.lblProductionPrintMeters.Location = new System.Drawing.Point(349, 64);
            this.lblProductionPrintMeters.Name = "lblProductionPrintMeters";
            this.lblProductionPrintMeters.Size = new System.Drawing.Size(82, 15);
            this.lblProductionPrintMeters.TabIndex = 18;
            this.lblProductionPrintMeters.Text = "Всего печати:";
            // 
            // lblProductionPlotteringLength
            // 
            this.lblProductionPlotteringLength.AutoSize = true;
            this.lblProductionPlotteringLength.Location = new System.Drawing.Point(741, 63);
            this.lblProductionPlotteringLength.Name = "lblProductionPlotteringLength";
            this.lblProductionPlotteringLength.Size = new System.Drawing.Size(75, 15);
            this.lblProductionPlotteringLength.TabIndex = 17;
            this.lblProductionPlotteringLength.Text = "Всего резки:";
            // 
            // lblProductionPaperCount
            // 
            this.lblProductionPaperCount.AutoSize = true;
            this.lblProductionPaperCount.Location = new System.Drawing.Point(928, 63);
            this.lblProductionPaperCount.Name = "lblProductionPaperCount";
            this.lblProductionPaperCount.Size = new System.Drawing.Size(82, 15);
            this.lblProductionPaperCount.TabIndex = 16;
            this.lblProductionPaperCount.Text = "Всего листов:";
            // 
            // lblProductionLayoutsCount
            // 
            this.lblProductionLayoutsCount.AutoSize = true;
            this.lblProductionLayoutsCount.Location = new System.Drawing.Point(171, 63);
            this.lblProductionLayoutsCount.Name = "lblProductionLayoutsCount";
            this.lblProductionLayoutsCount.Size = new System.Drawing.Size(89, 15);
            this.lblProductionLayoutsCount.TabIndex = 15;
            this.lblProductionLayoutsCount.Text = "Всего макетов:";
            // 
            // lblProductionOrdersCount
            // 
            this.lblProductionOrdersCount.AutoSize = true;
            this.lblProductionOrdersCount.Location = new System.Drawing.Point(13, 63);
            this.lblProductionOrdersCount.Name = "lblProductionOrdersCount";
            this.lblProductionOrdersCount.Size = new System.Drawing.Size(85, 15);
            this.lblProductionOrdersCount.TabIndex = 14;
            this.lblProductionOrdersCount.Text = "Всего заказов:";
            // 
            // txtClientNameProductionFilter
            // 
            this.txtClientNameProductionFilter.Location = new System.Drawing.Point(844, 3);
            this.txtClientNameProductionFilter.Name = "txtClientNameProductionFilter";
            this.txtClientNameProductionFilter.Size = new System.Drawing.Size(210, 23);
            this.txtClientNameProductionFilter.TabIndex = 13;
            this.txtClientNameProductionFilter.TextChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // lblProductionClientName
            // 
            this.lblProductionClientName.AutoSize = true;
            this.lblProductionClientName.Location = new System.Drawing.Point(757, 6);
            this.lblProductionClientName.Name = "lblProductionClientName";
            this.lblProductionClientName.Size = new System.Drawing.Size(81, 15);
            this.lblProductionClientName.TabIndex = 12;
            this.lblProductionClientName.Text = "Имя клиента:";
            // 
            // btnCheckCutting
            // 
            this.btnCheckCutting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckCutting.Location = new System.Drawing.Point(1158, 290);
            this.btnCheckCutting.Name = "btnCheckCutting";
            this.btnCheckCutting.Size = new System.Drawing.Size(104, 42);
            this.btnCheckCutting.TabIndex = 11;
            this.btnCheckCutting.Text = "Отметить резку на листы";
            this.btnCheckCutting.UseVisualStyleBackColor = true;
            this.btnCheckCutting.Click += new System.EventHandler(this.BtnCheckCutting_Click);
            // 
            // btnCheckPlottering
            // 
            this.btnCheckPlottering.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckPlottering.Location = new System.Drawing.Point(1158, 225);
            this.btnCheckPlottering.Name = "btnCheckPlottering";
            this.btnCheckPlottering.Size = new System.Drawing.Size(104, 59);
            this.btnCheckPlottering.TabIndex = 10;
            this.btnCheckPlottering.Text = "Отметить плоттерную резку";
            this.btnCheckPlottering.UseVisualStyleBackColor = true;
            this.btnCheckPlottering.Click += new System.EventHandler(this.BtnCheckPlottering_Click);
            // 
            // btnCheckLamination
            // 
            this.btnCheckLamination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckLamination.Location = new System.Drawing.Point(1158, 173);
            this.btnCheckLamination.Name = "btnCheckLamination";
            this.btnCheckLamination.Size = new System.Drawing.Size(104, 47);
            this.btnCheckLamination.TabIndex = 9;
            this.btnCheckLamination.Text = "Отметить ламинацию";
            this.btnCheckLamination.UseVisualStyleBackColor = true;
            this.btnCheckLamination.Click += new System.EventHandler(this.BtnCheckLamination_Click);
            // 
            // btnCheckPrinting
            // 
            this.btnCheckPrinting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckPrinting.Location = new System.Drawing.Point(1158, 126);
            this.btnCheckPrinting.Name = "btnCheckPrinting";
            this.btnCheckPrinting.Size = new System.Drawing.Size(104, 40);
            this.btnCheckPrinting.TabIndex = 8;
            this.btnCheckPrinting.Text = "Отметить печать";
            this.btnCheckPrinting.UseVisualStyleBackColor = true;
            this.btnCheckPrinting.Click += new System.EventHandler(this.BtnCheckPrinting_Click);
            // 
            // btnOpenContours
            // 
            this.btnOpenContours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenContours.Location = new System.Drawing.Point(1158, 81);
            this.btnOpenContours.Name = "btnOpenContours";
            this.btnOpenContours.Size = new System.Drawing.Size(104, 39);
            this.btnOpenContours.TabIndex = 7;
            this.btnOpenContours.Text = "Открыть контуры";
            this.btnOpenContours.UseVisualStyleBackColor = true;
            this.btnOpenContours.Click += new System.EventHandler(this.BtnOpenContours_Click);
            // 
            // productionGrid
            // 
            this.productionGrid.AllowUserToAddRows = false;
            this.productionGrid.AllowUserToDeleteRows = false;
            this.productionGrid.AllowUserToResizeRows = false;
            this.productionGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productionGrid.Location = new System.Drawing.Point(13, 81);
            this.productionGrid.Name = "productionGrid";
            this.productionGrid.ReadOnly = true;
            this.productionGrid.RowHeadersVisible = false;
            this.productionGrid.RowHeadersWidth = 51;
            this.productionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productionGrid.Size = new System.Drawing.Size(1140, 439);
            this.productionGrid.TabIndex = 6;
            this.productionGrid.Text = "dataGridView1";
            this.productionGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ProductionGrid_CellFormatting);
            // 
            // cuttingTypeComboBox
            // 
            this.cuttingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuttingTypeComboBox.FormattingEnabled = true;
            this.cuttingTypeComboBox.Location = new System.Drawing.Point(596, 3);
            this.cuttingTypeComboBox.Name = "cuttingTypeComboBox";
            this.cuttingTypeComboBox.Size = new System.Drawing.Size(154, 23);
            this.cuttingTypeComboBox.TabIndex = 5;
            this.cuttingTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // lblCuttingType
            // 
            this.lblCuttingType.AutoSize = true;
            this.lblCuttingType.Location = new System.Drawing.Point(526, 6);
            this.lblCuttingType.Name = "lblCuttingType";
            this.lblCuttingType.Size = new System.Drawing.Size(64, 15);
            this.lblCuttingType.TabIndex = 4;
            this.lblCuttingType.Text = "Тип резки:";
            // 
            // laminationComboBox
            // 
            this.laminationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laminationComboBox.FormattingEnabled = true;
            this.laminationComboBox.Location = new System.Drawing.Point(356, 3);
            this.laminationComboBox.Name = "laminationComboBox";
            this.laminationComboBox.Size = new System.Drawing.Size(154, 23);
            this.laminationComboBox.TabIndex = 3;
            this.laminationComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // lblLamination
            // 
            this.lblLamination.AutoSize = true;
            this.lblLamination.Location = new System.Drawing.Point(253, 6);
            this.lblLamination.Name = "lblLamination";
            this.lblLamination.Size = new System.Drawing.Size(96, 15);
            this.lblLamination.TabIndex = 2;
            this.lblLamination.Text = "Тип ламинации:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(13, 6);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(73, 15);
            this.lblFilm.TabIndex = 1;
            this.lblFilm.Text = "Тип пленки:";
            // 
            // filmComboBox
            // 
            this.filmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.Location = new System.Drawing.Point(92, 3);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(154, 23);
            this.filmComboBox.TabIndex = 0;
            this.filmComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterProductionItemsEvent);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1296, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "Главное меню";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 590);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "Стикеры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControlMain.ResumeLayout(false);
            this.ordersTab.ResumeLayout(false);
            this.ordersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGrid)).EndInit();
            this.layoutsTab.ResumeLayout(false);
            this.layoutsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutsGrid)).EndInit();
            this.clientsTab.ResumeLayout(false);
            this.clientsTab.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.costsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.costsGrid)).EndInit();
            this.deliveryTab.ResumeLayout(false);
            this.deliveryTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryGrid)).EndInit();
            this.productionTab.ResumeLayout(false);
            this.productionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productionGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.TabPage clientsTab;
        private System.Windows.Forms.DataGridView ordersGrid;
        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TabPage costsTab;
        private System.Windows.Forms.Button btnDeleteCost;
        private System.Windows.Forms.Button btnEditCost;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.DataGridView costsGrid;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.TabPage deliveryTab;
        private System.Windows.Forms.DataGridView deliveryGrid;
        private System.Windows.Forms.Button btnAddDeliveryInfo;
        private System.Windows.Forms.Button btnCheckDelivery;
        private System.Windows.Forms.TabPage productionTab;
        private System.Windows.Forms.Label lblCuttingType;
        private System.Windows.Forms.ComboBox laminationComboBox;
        private System.Windows.Forms.Label lblLamination;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.ComboBox filmComboBox;
        private System.Windows.Forms.ComboBox cuttingTypeComboBox;
        private System.Windows.Forms.DataGridView productionGrid;
        private System.Windows.Forms.Button btnOpenContours;
        private System.Windows.Forms.Button btnCheckPrinting;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.TabPage layoutsTab;
        private System.Windows.Forms.DataGridView layoutsGrid;
        private System.Windows.Forms.Button btnLoadContour;
        private System.Windows.Forms.Button btnContourToRevision;
        private System.Windows.Forms.Button btnOpenSources;
        private System.Windows.Forms.Button btnCheckLamination;
        private System.Windows.Forms.Button btnCheckPlottering;
        private System.Windows.Forms.Button btnCheckCutting;
        private System.Windows.Forms.ComboBox paymentComboBox;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblProductionClientName;
        private System.Windows.Forms.Button btnArchiveOrder;
        private System.Windows.Forms.Button btnOpenContoursFolder;
        private System.Windows.Forms.Label lblPlotting;
        private System.Windows.Forms.Label lblLaminationArea;
        private System.Windows.Forms.Label lblPrintingArea;
        private System.Windows.Forms.Label lblPaperCount;
        private System.Windows.Forms.Label lblLayoutsCount;
        private System.Windows.Forms.Label lblOrdersCount;
        private System.Windows.Forms.ComboBox orderIdForDesignerCombobox;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.ComboBox statusForDesignerCombobox;
        private System.Windows.Forms.Label lblStatusForDesigner;
        private System.Windows.Forms.Label lblOrderSum;
        private System.Windows.Forms.TextBox txtClientNameFilter;
        private System.Windows.Forms.TextBox txtClientNameProductionFilter;
        private System.Windows.Forms.TextBox txtClientFilterByName;
        private System.Windows.Forms.Label lblClientFilterByName;
        private System.Windows.Forms.Label lblContourDrawAverageTime;
        private System.Windows.Forms.Label lblAveragePlottingLength;
        private System.Windows.Forms.Label lblAveragePaperParameters;
        private System.Windows.Forms.Button btnUnconfirmOrder;
        private System.Windows.Forms.Label lblProductionPlotteringLength;
        private System.Windows.Forms.Label lblProductionPaperCount;
        private System.Windows.Forms.Label lblProductionLayoutsCount;
        private System.Windows.Forms.Label lblProductionOrdersCount;
        private System.Windows.Forms.Label lblProductionLaminationMeters;
        private System.Windows.Forms.Label lblProductionPrintMeters;
        private System.Windows.Forms.ComboBox productionUrgencyFilterCombobox;
        private System.Windows.Forms.Label lblProductionUrgencyFilter;
        private System.Windows.Forms.DateTimePicker orderDeliveryEndDatePicker;
        private System.Windows.Forms.Label lblDeliveryEndDate;
        private System.Windows.Forms.DateTimePicker orderDeliveryStartDatePicker;
        private System.Windows.Forms.Label lblOrderDeliveryStartDatePicker;
        private System.Windows.Forms.DateTimePicker orderEndDatePicker;
        private System.Windows.Forms.Label lblOrderEndDate;
        private System.Windows.Forms.DateTimePicker orderStartDatePicker;
        private System.Windows.Forms.Label lblOrderstartDate;
        private System.Windows.Forms.ComboBox deliveryStatusComboboxFilter;
        private System.Windows.Forms.Label lblDeliveryStatusFilter;
        private System.Windows.Forms.TextBox txtDeliveryTrackNumberFilter;
        private System.Windows.Forms.Label lblDeliveryTrackNumberFilter;
        private System.Windows.Forms.TextBox txtDeliveryClientNameFilter;
        private System.Windows.Forms.Label lblDeliveryClientFilter;
        private System.Windows.Forms.TextBox txtDeliveryOrderIdFilter;
        private System.Windows.Forms.Label lblDeliveryOrderIdFilter;
        private System.Windows.Forms.DateTimePicker deliveryEndDateFilterPicker;
        private System.Windows.Forms.Label lblDeliveryEndDateFilter;
        private System.Windows.Forms.DateTimePicker deliveryStartDateFilterPicker;
        private System.Windows.Forms.Label lblDeliveryStartDateFilter;
        private System.Windows.Forms.ComboBox deliveryMethodComboboxFilter;
        private System.Windows.Forms.Label lblDeliveryMethodFilter;
        private System.Windows.Forms.Label lblDeliveryOrdersTotal;
        private System.Windows.Forms.Label lblLayoutsTabLayoutsTotal;
        private System.Windows.Forms.ListBox orderStatusListBox;
        private System.Windows.Forms.TextBox txtOrdersOrderIdFilter;
        private System.Windows.Forms.Label lblOrdersOrderIdFilter;
        private System.Windows.Forms.TextBox txtProductionOrderIdFilter;
        private System.Windows.Forms.Label lblProductionOrderIdFilter;
        private System.Windows.Forms.TextBox txtOrderInsertedFilter;
        private System.Windows.Forms.Label lblOrderInsertedByFilter;
        private System.Windows.Forms.ComboBox orderUrgencyFilterCombobox;
        private System.Windows.Forms.Label lblUrgencyOrderFilter;
        private System.Windows.Forms.Button btnOpenVkGroupLink;
        private System.Windows.Forms.Button buttonDlg;
        private System.Windows.Forms.TextBox textBoxCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVkGrLnk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGrVk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblPaymentCheckInfo;
        private System.Windows.Forms.Label lblOrderTrackNumber;
        private System.Windows.Forms.Label lblOrderDoneDate;
        private System.Windows.Forms.Label lblOrderConfirmInfo;
        private System.Windows.Forms.Label lblOrderInsertInfo;
        private System.Windows.Forms.Button button1;
    }
}

