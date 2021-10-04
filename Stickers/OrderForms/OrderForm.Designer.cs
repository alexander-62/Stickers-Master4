namespace Stickers.WinForms.OrderForms
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClient = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.lblApproximalDeliveryDate = new System.Windows.Forms.Label();
            this.approximalDeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.errorDeliveryCost = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddClient = new System.Windows.Forms.Button();
            this.urgencyCheckBox = new System.Windows.Forms.CheckBox();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.orderItemsGrid = new System.Windows.Forms.DataGridView();
            this.btnAddOrderItem = new System.Windows.Forms.Button();
            this.btnDeleteOrderItem = new System.Windows.Forms.Button();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblReceiverCredentials = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtReceiverCredentials = new System.Windows.Forms.TextBox();
            this.txtPostIndex = new System.Windows.Forms.TextBox();
            this.lblPostIndex = new System.Windows.Forms.Label();
            this.errorDeliveryAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorReceiverCredentials = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPostIndex = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.deliveryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblDeliveryType = new System.Windows.Forms.Label();
            this.errorDeliveryType = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnСhangeSourceFiles = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.lblStickersCost = new System.Windows.Forms.Label();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.lblFullCost = new System.Windows.Forms.Label();
            this.lblStickersCostValue = new System.Windows.Forms.Label();
            this.lblDeliveryCostValue = new System.Windows.Forms.Label();
            this.lblFullCostValue = new System.Windows.Forms.Label();
            this.btnOpenContourFolder = new System.Windows.Forms.Button();
            this.paymentCheckBox = new System.Windows.Forms.CheckBox();
            this.btnEditOrderItem = new System.Windows.Forms.Button();
            this.errorClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadContour = new System.Windows.Forms.Button();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.lblOrderInsertInfo = new System.Windows.Forms.Label();
            this.lblOrderConfirmInfo = new System.Windows.Forms.Label();
            this.lblOrderDoneDate = new System.Windows.Forms.Label();
            this.lblOrderTrackNumber = new System.Windows.Forms.Label();
            this.lblPaymentCheckInfo = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.btnOpenVkGroupLink = new System.Windows.Forms.Button();
            this.txtVkGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVkLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReceiverCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(1394, 599);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 22);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1510, 599);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(10, 7);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(60, 15);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Заказчик:";
            // 
            // clientComboBox
            // 
            this.clientComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(185, 4);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(219, 23);
            this.clientComboBox.TabIndex = 0;
            this.clientComboBox.SelectedIndexChanged += new System.EventHandler(this.СlientComboBox_SelectedIndexChanged);
            this.clientComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.ClientComboBox_Validating);
            // 
            // lblApproximalDeliveryDate
            // 
            this.lblApproximalDeliveryDate.AutoSize = true;
            this.lblApproximalDeliveryDate.Location = new System.Drawing.Point(10, 38);
            this.lblApproximalDeliveryDate.Name = "lblApproximalDeliveryDate";
            this.lblApproximalDeliveryDate.Size = new System.Drawing.Size(145, 15);
            this.lblApproximalDeliveryDate.TabIndex = 4;
            this.lblApproximalDeliveryDate.Text = "Желаемая дата доставки:";
            // 
            // approximalDeliveryDatePicker
            // 
            this.approximalDeliveryDatePicker.CausesValidation = false;
            this.approximalDeliveryDatePicker.Checked = false;
            this.approximalDeliveryDatePicker.Location = new System.Drawing.Point(185, 32);
            this.approximalDeliveryDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approximalDeliveryDatePicker.Name = "approximalDeliveryDatePicker";
            this.approximalDeliveryDatePicker.ShowCheckBox = true;
            this.approximalDeliveryDatePicker.Size = new System.Drawing.Size(219, 23);
            this.approximalDeliveryDatePicker.TabIndex = 2;
            // 
            // errorDeliveryCost
            // 
            this.errorDeliveryCost.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDeliveryCost.ContainerControl = this;
            // 
            // btnAddClient
            // 
            this.btnAddClient.CausesValidation = false;
            this.btnAddClient.Location = new System.Drawing.Point(443, 4);
            this.btnAddClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(120, 22);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Создать клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.BtnAddClient_Click);
            // 
            // urgencyCheckBox
            // 
            this.urgencyCheckBox.AutoSize = true;
            this.urgencyCheckBox.CausesValidation = false;
            this.urgencyCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urgencyCheckBox.Location = new System.Drawing.Point(451, 36);
            this.urgencyCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urgencyCheckBox.Name = "urgencyCheckBox";
            this.urgencyCheckBox.Size = new System.Drawing.Size(112, 19);
            this.urgencyCheckBox.TabIndex = 3;
            this.urgencyCheckBox.Text = "Срочный заказ:";
            this.urgencyCheckBox.UseVisualStyleBackColor = true;
            this.urgencyCheckBox.CheckedChanged += new System.EventHandler(this.UrgencyCheckBox_CheckedChanged);
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.AutoSize = true;
            this.lblOrderItems.Location = new System.Drawing.Point(10, 290);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(96, 15);
            this.lblOrderItems.TabIndex = 24;
            this.lblOrderItems.Text = "Позиции заказа:";
            // 
            // orderItemsGrid
            // 
            this.orderItemsGrid.AllowUserToAddRows = false;
            this.orderItemsGrid.AllowUserToDeleteRows = false;
            this.orderItemsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderItemsGrid.Location = new System.Drawing.Point(10, 307);
            this.orderItemsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderItemsGrid.Name = "orderItemsGrid";
            this.orderItemsGrid.ReadOnly = true;
            this.orderItemsGrid.RowHeadersVisible = false;
            this.orderItemsGrid.RowHeadersWidth = 51;
            this.orderItemsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.orderItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.orderItemsGrid.Size = new System.Drawing.Size(1494, 284);
            this.orderItemsGrid.TabIndex = 25;
            this.orderItemsGrid.Text = "dataGridView1";
            // 
            // btnAddOrderItem
            // 
            this.btnAddOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrderItem.CausesValidation = false;
            this.btnAddOrderItem.Location = new System.Drawing.Point(1510, 192);
            this.btnAddOrderItem.Name = "btnAddOrderItem";
            this.btnAddOrderItem.Size = new System.Drawing.Size(82, 59);
            this.btnAddOrderItem.TabIndex = 15;
            this.btnAddOrderItem.Text = "Добавить позицию в заказ";
            this.btnAddOrderItem.UseVisualStyleBackColor = true;
            this.btnAddOrderItem.Click += new System.EventHandler(this.BtnAddOrderItem_Click);
            // 
            // btnDeleteOrderItem
            // 
            this.btnDeleteOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteOrderItem.CausesValidation = false;
            this.btnDeleteOrderItem.Location = new System.Drawing.Point(1510, 316);
            this.btnDeleteOrderItem.Name = "btnDeleteOrderItem";
            this.btnDeleteOrderItem.Size = new System.Drawing.Size(82, 61);
            this.btnDeleteOrderItem.TabIndex = 17;
            this.btnDeleteOrderItem.Text = "Убрать позицию из заказа";
            this.btnDeleteOrderItem.UseVisualStyleBackColor = true;
            this.btnDeleteOrderItem.Click += new System.EventHandler(this.BtnDeleteOrderItem_Click);
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(10, 63);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(95, 15);
            this.lblDeliveryAddress.TabIndex = 28;
            this.lblDeliveryAddress.Text = "Адрес доставки:";
            // 
            // lblReceiverCredentials
            // 
            this.lblReceiverCredentials.AutoSize = true;
            this.lblReceiverCredentials.Location = new System.Drawing.Point(10, 91);
            this.lblReceiverCredentials.Name = "lblReceiverCredentials";
            this.lblReceiverCredentials.Size = new System.Drawing.Size(104, 15);
            this.lblReceiverCredentials.TabIndex = 29;
            this.lblReceiverCredentials.Text = "ФИО получателя:";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(185, 60);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(378, 23);
            this.txtDeliveryAddress.TabIndex = 4;
            this.txtDeliveryAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDeliveryAddress_Validating);
            // 
            // txtReceiverCredentials
            // 
            this.txtReceiverCredentials.Location = new System.Drawing.Point(185, 88);
            this.txtReceiverCredentials.Name = "txtReceiverCredentials";
            this.txtReceiverCredentials.Size = new System.Drawing.Size(378, 23);
            this.txtReceiverCredentials.TabIndex = 5;
            this.txtReceiverCredentials.Validating += new System.ComponentModel.CancelEventHandler(this.TxtReceiverCredentials_Validating);
            // 
            // txtPostIndex
            // 
            this.txtPostIndex.Location = new System.Drawing.Point(185, 117);
            this.txtPostIndex.Name = "txtPostIndex";
            this.txtPostIndex.Size = new System.Drawing.Size(378, 23);
            this.txtPostIndex.TabIndex = 6;
            this.txtPostIndex.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPostIndex_Validating);
            // 
            // lblPostIndex
            // 
            this.lblPostIndex.AutoSize = true;
            this.lblPostIndex.Location = new System.Drawing.Point(10, 120);
            this.lblPostIndex.Name = "lblPostIndex";
            this.lblPostIndex.Size = new System.Drawing.Size(108, 15);
            this.lblPostIndex.TabIndex = 33;
            this.lblPostIndex.Text = "Почтовый индекс:";
            // 
            // errorDeliveryAddress
            // 
            this.errorDeliveryAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDeliveryAddress.ContainerControl = this;
            // 
            // errorReceiverCredentials
            // 
            this.errorReceiverCredentials.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorReceiverCredentials.ContainerControl = this;
            // 
            // errorPostIndex
            // 
            this.errorPostIndex.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPostIndex.ContainerControl = this;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(10, 178);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(96, 15);
            this.lblPaymentMethod.TabIndex = 34;
            this.lblPaymentMethod.Text = "Способ оплаты:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(185, 175);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(219, 23);
            this.comboBoxPaymentMethod.TabIndex = 8;
            // 
            // deliveryTypeComboBox
            // 
            this.deliveryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryTypeComboBox.FormattingEnabled = true;
            this.deliveryTypeComboBox.Location = new System.Drawing.Point(185, 146);
            this.deliveryTypeComboBox.Name = "deliveryTypeComboBox";
            this.deliveryTypeComboBox.Size = new System.Drawing.Size(219, 23);
            this.deliveryTypeComboBox.TabIndex = 7;
            this.deliveryTypeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.DeliveryTypeComboBox_Validating);
            // 
            // lblDeliveryType
            // 
            this.lblDeliveryType.AutoSize = true;
            this.lblDeliveryType.Location = new System.Drawing.Point(10, 149);
            this.lblDeliveryType.Name = "lblDeliveryType";
            this.lblDeliveryType.Size = new System.Drawing.Size(104, 15);
            this.lblDeliveryType.TabIndex = 37;
            this.lblDeliveryType.Text = "Способ доставки:";
            // 
            // errorDeliveryType
            // 
            this.errorDeliveryType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDeliveryType.ContainerControl = this;
            // 
            // btnСhangeSourceFiles
            // 
            this.btnСhangeSourceFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnСhangeSourceFiles.Location = new System.Drawing.Point(1510, 382);
            this.btnСhangeSourceFiles.Name = "btnСhangeSourceFiles";
            this.btnСhangeSourceFiles.Size = new System.Drawing.Size(82, 47);
            this.btnСhangeSourceFiles.TabIndex = 18;
            this.btnСhangeSourceFiles.Text = "Изменить исходники";
            this.btnСhangeSourceFiles.UseVisualStyleBackColor = true;
            this.btnСhangeSourceFiles.Click += new System.EventHandler(this.BtnСhangeSourceFiles_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(981, 6);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(133, 15);
            this.lblComment.TabIndex = 40;
            this.lblComment.Text = "Комментарий к заказу:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(1134, 3);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(312, 79);
            this.txtComment.TabIndex = 14;
            this.txtComment.Text = "";
            // 
            // lblStickersCost
            // 
            this.lblStickersCost.AutoSize = true;
            this.lblStickersCost.Location = new System.Drawing.Point(582, 91);
            this.lblStickersCost.Name = "lblStickersCost";
            this.lblStickersCost.Size = new System.Drawing.Size(123, 15);
            this.lblStickersCost.TabIndex = 42;
            this.lblStickersCost.Text = "Стоимость стикеров:";
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Location = new System.Drawing.Point(582, 120);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(122, 15);
            this.lblDeliveryCost.TabIndex = 43;
            this.lblDeliveryCost.Text = "Стоимость доставки:";
            // 
            // lblFullCost
            // 
            this.lblFullCost.AutoSize = true;
            this.lblFullCost.Location = new System.Drawing.Point(582, 149);
            this.lblFullCost.Name = "lblFullCost";
            this.lblFullCost.Size = new System.Drawing.Size(113, 15);
            this.lblFullCost.TabIndex = 44;
            this.lblFullCost.Text = "Полная стоимость:";
            // 
            // lblStickersCostValue
            // 
            this.lblStickersCostValue.AutoSize = true;
            this.lblStickersCostValue.Location = new System.Drawing.Point(721, 91);
            this.lblStickersCostValue.Name = "lblStickersCostValue";
            this.lblStickersCostValue.Size = new System.Drawing.Size(38, 15);
            this.lblStickersCostValue.TabIndex = 45;
            this.lblStickersCostValue.Text = "label1";
            // 
            // lblDeliveryCostValue
            // 
            this.lblDeliveryCostValue.AutoSize = true;
            this.lblDeliveryCostValue.Location = new System.Drawing.Point(721, 120);
            this.lblDeliveryCostValue.Name = "lblDeliveryCostValue";
            this.lblDeliveryCostValue.Size = new System.Drawing.Size(38, 15);
            this.lblDeliveryCostValue.TabIndex = 46;
            this.lblDeliveryCostValue.Text = "label1";
            // 
            // lblFullCostValue
            // 
            this.lblFullCostValue.AutoSize = true;
            this.lblFullCostValue.Location = new System.Drawing.Point(721, 149);
            this.lblFullCostValue.Name = "lblFullCostValue";
            this.lblFullCostValue.Size = new System.Drawing.Size(38, 15);
            this.lblFullCostValue.TabIndex = 47;
            this.lblFullCostValue.Text = "label1";
            // 
            // btnOpenContourFolder
            // 
            this.btnOpenContourFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenContourFolder.Location = new System.Drawing.Point(1510, 489);
            this.btnOpenContourFolder.Name = "btnOpenContourFolder";
            this.btnOpenContourFolder.Size = new System.Drawing.Size(82, 44);
            this.btnOpenContourFolder.TabIndex = 20;
            this.btnOpenContourFolder.Text = "Открыть контуры";
            this.btnOpenContourFolder.UseVisualStyleBackColor = true;
            this.btnOpenContourFolder.Click += new System.EventHandler(this.BtnOpenContourFolder_Click);
            // 
            // paymentCheckBox
            // 
            this.paymentCheckBox.AutoSize = true;
            this.paymentCheckBox.Location = new System.Drawing.Point(582, 178);
            this.paymentCheckBox.Name = "paymentCheckBox";
            this.paymentCheckBox.Size = new System.Drawing.Size(66, 19);
            this.paymentCheckBox.TabIndex = 9;
            this.paymentCheckBox.Text = "Оплата";
            this.paymentCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnEditOrderItem
            // 
            this.btnEditOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditOrderItem.Location = new System.Drawing.Point(1510, 256);
            this.btnEditOrderItem.Name = "btnEditOrderItem";
            this.btnEditOrderItem.Size = new System.Drawing.Size(82, 53);
            this.btnEditOrderItem.TabIndex = 16;
            this.btnEditOrderItem.Text = "Изменить позицию";
            this.btnEditOrderItem.UseVisualStyleBackColor = true;
            this.btnEditOrderItem.Click += new System.EventHandler(this.BtnEditOrderItem_Click);
            // 
            // errorClient
            // 
            this.errorClient.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorClient.ContainerControl = this;
            // 
            // btnLoadContour
            // 
            this.btnLoadContour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadContour.Location = new System.Drawing.Point(1510, 436);
            this.btnLoadContour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadContour.Name = "btnLoadContour";
            this.btnLoadContour.Size = new System.Drawing.Size(82, 48);
            this.btnLoadContour.TabIndex = 19;
            this.btnLoadContour.Text = "Загрузить контур";
            this.btnLoadContour.UseVisualStyleBackColor = true;
            this.btnLoadContour.Click += new System.EventHandler(this.BtnLoadContour_Click);
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDialog.Location = new System.Drawing.Point(1510, 538);
            this.btnOpenDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(82, 57);
            this.btnOpenDialog.TabIndex = 21;
            this.btnOpenDialog.Text = "Открыть диалог с заказчиком";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.BtnOpenDialog_Click);
            // 
            // lblOrderInsertInfo
            // 
            this.lblOrderInsertInfo.AutoSize = true;
            this.lblOrderInsertInfo.Location = new System.Drawing.Point(981, 91);
            this.lblOrderInsertInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderInsertInfo.Name = "lblOrderInsertInfo";
            this.lblOrderInsertInfo.Size = new System.Drawing.Size(81, 15);
            this.lblOrderInsertInfo.TabIndex = 53;
            this.lblOrderInsertInfo.Text = "Заказ внесен:";
            // 
            // lblOrderConfirmInfo
            // 
            this.lblOrderConfirmInfo.AutoSize = true;
            this.lblOrderConfirmInfo.Location = new System.Drawing.Point(981, 121);
            this.lblOrderConfirmInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderConfirmInfo.Name = "lblOrderConfirmInfo";
            this.lblOrderConfirmInfo.Size = new System.Drawing.Size(106, 15);
            this.lblOrderConfirmInfo.TabIndex = 54;
            this.lblOrderConfirmInfo.Text = "Заказ согласован:";
            // 
            // lblOrderDoneDate
            // 
            this.lblOrderDoneDate.AutoSize = true;
            this.lblOrderDoneDate.Location = new System.Drawing.Point(981, 149);
            this.lblOrderDoneDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDoneDate.Name = "lblOrderDoneDate";
            this.lblOrderDoneDate.Size = new System.Drawing.Size(105, 15);
            this.lblOrderDoneDate.TabIndex = 55;
            this.lblOrderDoneDate.Text = "Заказ изготовлен:";
            // 
            // lblOrderTrackNumber
            // 
            this.lblOrderTrackNumber.AutoSize = true;
            this.lblOrderTrackNumber.Location = new System.Drawing.Point(981, 175);
            this.lblOrderTrackNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTrackNumber.Name = "lblOrderTrackNumber";
            this.lblOrderTrackNumber.Size = new System.Drawing.Size(75, 15);
            this.lblOrderTrackNumber.TabIndex = 56;
            this.lblOrderTrackNumber.Text = "Трэк номер:";
            // 
            // lblPaymentCheckInfo
            // 
            this.lblPaymentCheckInfo.AutoSize = true;
            this.lblPaymentCheckInfo.Location = new System.Drawing.Point(981, 197);
            this.lblPaymentCheckInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentCheckInfo.Name = "lblPaymentCheckInfo";
            this.lblPaymentCheckInfo.Size = new System.Drawing.Size(106, 15);
            this.lblPaymentCheckInfo.TabIndex = 57;
            this.lblPaymentCheckInfo.Text = "Оплата отмечена:";
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.AutoSize = true;
            this.lblDeliveryDate.Location = new System.Drawing.Point(981, 219);
            this.lblDeliveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(89, 15);
            this.lblDeliveryDate.TabIndex = 58;
            this.lblDeliveryDate.Text = "Дата отправки:";
            // 
            // btnOpenVkGroupLink
            // 
            this.btnOpenVkGroupLink.Location = new System.Drawing.Point(185, 261);
            this.btnOpenVkGroupLink.Name = "btnOpenVkGroupLink";
            this.btnOpenVkGroupLink.Size = new System.Drawing.Size(151, 23);
            this.btnOpenVkGroupLink.TabIndex = 12;
            this.btnOpenVkGroupLink.Text = "Открыть группу";
            this.btnOpenVkGroupLink.UseVisualStyleBackColor = true;
            this.btnOpenVkGroupLink.Click += new System.EventHandler(this.btnOpenVkGroupLink_Click);
            // 
            // txtVkGroupName
            // 
            this.txtVkGroupName.Location = new System.Drawing.Point(185, 232);
            this.txtVkGroupName.Name = "txtVkGroupName";
            this.txtVkGroupName.Size = new System.Drawing.Size(378, 23);
            this.txtVkGroupName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "Название группы VK:";
            // 
            // txtVkLink
            // 
            this.txtVkLink.Location = new System.Drawing.Point(185, 204);
            this.txtVkLink.Name = "txtVkLink";
            this.txtVkLink.Size = new System.Drawing.Size(378, 23);
            this.txtVkLink.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Ссылка VK:";
            // 
            // txtClientComment
            // 
            this.txtClientComment.Location = new System.Drawing.Point(721, 5);
            this.txtClientComment.Name = "txtClientComment";
            this.txtClientComment.Size = new System.Drawing.Size(254, 79);
            this.txtClientComment.TabIndex = 13;
            this.txtClientComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 73;
            this.label1.Text = "Комментарий к клиенту:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1604, 630);
            this.Controls.Add(this.btnOpenVkGroupLink);
            this.Controls.Add(this.txtVkGroupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVkLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblPaymentCheckInfo);
            this.Controls.Add(this.lblOrderTrackNumber);
            this.Controls.Add(this.lblOrderDoneDate);
            this.Controls.Add(this.lblOrderConfirmInfo);
            this.Controls.Add(this.lblOrderInsertInfo);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.btnLoadContour);
            this.Controls.Add(this.btnEditOrderItem);
            this.Controls.Add(this.paymentCheckBox);
            this.Controls.Add(this.btnOpenContourFolder);
            this.Controls.Add(this.lblFullCostValue);
            this.Controls.Add(this.lblDeliveryCostValue);
            this.Controls.Add(this.lblStickersCostValue);
            this.Controls.Add(this.lblFullCost);
            this.Controls.Add(this.lblDeliveryCost);
            this.Controls.Add(this.lblStickersCost);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnСhangeSourceFiles);
            this.Controls.Add(this.lblDeliveryType);
            this.Controls.Add(this.deliveryTypeComboBox);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblPostIndex);
            this.Controls.Add(this.txtPostIndex);
            this.Controls.Add(this.txtReceiverCredentials);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.lblReceiverCredentials);
            this.Controls.Add(this.lblDeliveryAddress);
            this.Controls.Add(this.btnDeleteOrderItem);
            this.Controls.Add(this.btnAddOrderItem);
            this.Controls.Add(this.orderItemsGrid);
            this.Controls.Add(this.lblOrderItems);
            this.Controls.Add(this.urgencyCheckBox);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.approximalDeliveryDatePicker);
            this.Controls.Add(this.lblApproximalDeliveryDate);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderForm";
            this.Text = "Заказ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReceiverCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.Label lblApproximalDeliveryDate;
        private System.Windows.Forms.DateTimePicker approximalDeliveryDatePicker;
        private System.Windows.Forms.ErrorProvider errorDeliveryCost;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.CheckBox urgencyCheckBox;
        private System.Windows.Forms.DataGridView orderItemsGrid;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.Button btnDeleteOrderItem;
        private System.Windows.Forms.Button btnAddOrderItem;
        private System.Windows.Forms.Label lblPostIndex;
        private System.Windows.Forms.TextBox txtPostIndex;
        private System.Windows.Forms.TextBox txtReceiverCredentials;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblReceiverCredentials;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.ErrorProvider errorDeliveryAddress;
        private System.Windows.Forms.ErrorProvider errorReceiverCredentials;
        private System.Windows.Forms.ErrorProvider errorPostIndex;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDeliveryType;
        private System.Windows.Forms.ComboBox deliveryTypeComboBox;
        private System.Windows.Forms.ErrorProvider errorDeliveryType;
        private System.Windows.Forms.Button btnСhangeSourceFiles;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblFullCostValue;
        private System.Windows.Forms.Label lblDeliveryCostValue;
        private System.Windows.Forms.Label lblStickersCostValue;
        private System.Windows.Forms.Label lblFullCost;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.Label lblStickersCost;
        private System.Windows.Forms.Button btnOpenContourFolder;
        private System.Windows.Forms.CheckBox paymentCheckBox;
        private System.Windows.Forms.Button btnEditOrderItem;
        private System.Windows.Forms.ErrorProvider errorClient;
        private System.Windows.Forms.Button btnLoadContour;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblPaymentCheckInfo;
        private System.Windows.Forms.Label lblOrderTrackNumber;
        private System.Windows.Forms.Label lblOrderDoneDate;
        private System.Windows.Forms.Label lblOrderConfirmInfo;
        private System.Windows.Forms.Label lblOrderInsertInfo;
        private System.Windows.Forms.Button btnOpenVkGroupLink;
        private System.Windows.Forms.TextBox txtVkGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVkLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtClientComment;
        private System.Windows.Forms.Label label1;
    }
}