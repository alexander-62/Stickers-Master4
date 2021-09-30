namespace Stickers.WinForms.ArchiveForms
{
    partial class ArchiveForm
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
            this.archiveOrdersGrid = new System.Windows.Forms.DataGridView();
            this.lblClientName = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.lblOrderDateFrom = new System.Windows.Forms.Label();
            this.orderDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDateTill = new System.Windows.Forms.Label();
            this.orderDateTillPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDateFrom = new System.Windows.Forms.Label();
            this.deliveryDateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateTillPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryDateTill = new System.Windows.Forms.Label();
            this.lblOrdersTotal = new System.Windows.Forms.Label();
            this.lblLayoutsTotal = new System.Windows.Forms.Label();
            this.lblPaperTotal = new System.Windows.Forms.Label();
            this.lblPrintArea = new System.Windows.Forms.Label();
            this.lblLaminationArea = new System.Windows.Forms.Label();
            this.lblPlotteringLength = new System.Windows.Forms.Label();
            this.lblCostTotal = new System.Windows.Forms.Label();
            this.lblArchiveOrderIdFilter = new System.Windows.Forms.Label();
            this.txtArchiveOrderIdFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.archiveOrdersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // archiveOrdersGrid
            // 
            this.archiveOrdersGrid.AllowUserToAddRows = false;
            this.archiveOrdersGrid.AllowUserToDeleteRows = false;
            this.archiveOrdersGrid.AllowUserToResizeColumns = false;
            this.archiveOrdersGrid.AllowUserToResizeRows = false;
            this.archiveOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.archiveOrdersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archiveOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archiveOrdersGrid.Location = new System.Drawing.Point(13, 193);
            this.archiveOrdersGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archiveOrdersGrid.Name = "archiveOrdersGrid";
            this.archiveOrdersGrid.ReadOnly = true;
            this.archiveOrdersGrid.RowHeadersVisible = false;
            this.archiveOrdersGrid.RowHeadersWidth = 51;
            this.archiveOrdersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveOrdersGrid.Size = new System.Drawing.Size(1898, 563);
            this.archiveOrdersGrid.TabIndex = 0;
            this.archiveOrdersGrid.Text = "dataGridView1";
            this.archiveOrdersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArchiveOrdersGrid_CellDoubleClick);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(19, 22);
            this.lblClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(119, 25);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Имя клиента:";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(146, 19);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(293, 31);
            this.txtClientName.TabIndex = 2;
            this.txtClientName.TextChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderDateFrom
            // 
            this.lblOrderDateFrom.AutoSize = true;
            this.lblOrderDateFrom.Location = new System.Drawing.Point(14, 63);
            this.lblOrderDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDateFrom.Name = "lblOrderDateFrom";
            this.lblOrderDateFrom.Size = new System.Drawing.Size(123, 25);
            this.lblOrderDateFrom.TabIndex = 3;
            this.lblOrderDateFrom.Text = "Дата заказа с:";
            // 
            // orderDateFromPicker
            // 
            this.orderDateFromPicker.Checked = false;
            this.orderDateFromPicker.Location = new System.Drawing.Point(156, 57);
            this.orderDateFromPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderDateFromPicker.Name = "orderDateFromPicker";
            this.orderDateFromPicker.ShowCheckBox = true;
            this.orderDateFromPicker.Size = new System.Drawing.Size(338, 31);
            this.orderDateFromPicker.TabIndex = 4;
            this.orderDateFromPicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblOrderDateTill
            // 
            this.lblOrderDateTill.AutoSize = true;
            this.lblOrderDateTill.Location = new System.Drawing.Point(504, 63);
            this.lblOrderDateTill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDateTill.Name = "lblOrderDateTill";
            this.lblOrderDateTill.Size = new System.Drawing.Size(44, 25);
            this.lblOrderDateTill.TabIndex = 5;
            this.lblOrderDateTill.Text = "До: ";
            // 
            // orderDateTillPicker
            // 
            this.orderDateTillPicker.Checked = false;
            this.orderDateTillPicker.Location = new System.Drawing.Point(554, 57);
            this.orderDateTillPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.orderDateTillPicker.Name = "orderDateTillPicker";
            this.orderDateTillPicker.ShowCheckBox = true;
            this.orderDateTillPicker.Size = new System.Drawing.Size(338, 31);
            this.orderDateTillPicker.TabIndex = 6;
            this.orderDateTillPicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblDeliveryDateFrom
            // 
            this.lblDeliveryDateFrom.AutoSize = true;
            this.lblDeliveryDateFrom.Location = new System.Drawing.Point(14, 112);
            this.lblDeliveryDateFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryDateFrom.Name = "lblDeliveryDateFrom";
            this.lblDeliveryDateFrom.Size = new System.Drawing.Size(148, 25);
            this.lblDeliveryDateFrom.TabIndex = 7;
            this.lblDeliveryDateFrom.Text = "Дата отправки с:";
            // 
            // deliveryDateFromPicker
            // 
            this.deliveryDateFromPicker.Checked = false;
            this.deliveryDateFromPicker.Location = new System.Drawing.Point(177, 105);
            this.deliveryDateFromPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deliveryDateFromPicker.Name = "deliveryDateFromPicker";
            this.deliveryDateFromPicker.ShowCheckBox = true;
            this.deliveryDateFromPicker.Size = new System.Drawing.Size(338, 31);
            this.deliveryDateFromPicker.TabIndex = 8;
            this.deliveryDateFromPicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // deliveryDateTillPicker
            // 
            this.deliveryDateTillPicker.Checked = false;
            this.deliveryDateTillPicker.Location = new System.Drawing.Point(571, 105);
            this.deliveryDateTillPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deliveryDateTillPicker.Name = "deliveryDateTillPicker";
            this.deliveryDateTillPicker.ShowCheckBox = true;
            this.deliveryDateTillPicker.Size = new System.Drawing.Size(338, 31);
            this.deliveryDateTillPicker.TabIndex = 9;
            this.deliveryDateTillPicker.ValueChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // lblDeliveryDateTill
            // 
            this.lblDeliveryDateTill.AutoSize = true;
            this.lblDeliveryDateTill.Location = new System.Drawing.Point(526, 112);
            this.lblDeliveryDateTill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryDateTill.Name = "lblDeliveryDateTill";
            this.lblDeliveryDateTill.Size = new System.Drawing.Size(39, 25);
            this.lblDeliveryDateTill.TabIndex = 10;
            this.lblDeliveryDateTill.Text = "До:";
            // 
            // lblOrdersTotal
            // 
            this.lblOrdersTotal.AutoSize = true;
            this.lblOrdersTotal.Location = new System.Drawing.Point(19, 163);
            this.lblOrdersTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrdersTotal.Name = "lblOrdersTotal";
            this.lblOrdersTotal.Size = new System.Drawing.Size(130, 25);
            this.lblOrdersTotal.TabIndex = 11;
            this.lblOrdersTotal.Text = "Всего заказов:";
            // 
            // lblLayoutsTotal
            // 
            this.lblLayoutsTotal.AutoSize = true;
            this.lblLayoutsTotal.Location = new System.Drawing.Point(239, 163);
            this.lblLayoutsTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLayoutsTotal.Name = "lblLayoutsTotal";
            this.lblLayoutsTotal.Size = new System.Drawing.Size(134, 25);
            this.lblLayoutsTotal.TabIndex = 12;
            this.lblLayoutsTotal.Text = "Всего макетов:";
            // 
            // lblPaperTotal
            // 
            this.lblPaperTotal.AutoSize = true;
            this.lblPaperTotal.Location = new System.Drawing.Point(486, 163);
            this.lblPaperTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaperTotal.Name = "lblPaperTotal";
            this.lblPaperTotal.Size = new System.Drawing.Size(121, 25);
            this.lblPaperTotal.TabIndex = 13;
            this.lblPaperTotal.Text = "Всего листов:";
            // 
            // lblPrintArea
            // 
            this.lblPrintArea.AutoSize = true;
            this.lblPrintArea.Location = new System.Drawing.Point(750, 163);
            this.lblPrintArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrintArea.Name = "lblPrintArea";
            this.lblPrintArea.Size = new System.Drawing.Size(140, 25);
            this.lblPrintArea.TabIndex = 14;
            this.lblPrintArea.Text = "Метров печати:";
            // 
            // lblLaminationArea
            // 
            this.lblLaminationArea.AutoSize = true;
            this.lblLaminationArea.Location = new System.Drawing.Point(997, 163);
            this.lblLaminationArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaminationArea.Name = "lblLaminationArea";
            this.lblLaminationArea.Size = new System.Drawing.Size(176, 25);
            this.lblLaminationArea.TabIndex = 15;
            this.lblLaminationArea.Text = "Метров ламинации:";
            // 
            // lblPlotteringLength
            // 
            this.lblPlotteringLength.AutoSize = true;
            this.lblPlotteringLength.Location = new System.Drawing.Point(1306, 163);
            this.lblPlotteringLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlotteringLength.Name = "lblPlotteringLength";
            this.lblPlotteringLength.Size = new System.Drawing.Size(113, 25);
            this.lblPlotteringLength.TabIndex = 16;
            this.lblPlotteringLength.Text = "Всего резки:";
            // 
            // lblCostTotal
            // 
            this.lblCostTotal.AutoSize = true;
            this.lblCostTotal.Location = new System.Drawing.Point(1539, 163);
            this.lblCostTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostTotal.Name = "lblCostTotal";
            this.lblCostTotal.Size = new System.Drawing.Size(231, 25);
            this.lblCostTotal.TabIndex = 17;
            this.lblCostTotal.Text = "Общая стоимость заказов:";
            // 
            // lblArchiveOrderIdFilter
            // 
            this.lblArchiveOrderIdFilter.AutoSize = true;
            this.lblArchiveOrderIdFilter.Location = new System.Drawing.Point(446, 22);
            this.lblArchiveOrderIdFilter.Name = "lblArchiveOrderIdFilter";
            this.lblArchiveOrderIdFilter.Size = new System.Drawing.Size(130, 25);
            this.lblArchiveOrderIdFilter.TabIndex = 18;
            this.lblArchiveOrderIdFilter.Text = "Номер заказа:";
            // 
            // txtArchiveOrderIdFilter
            // 
            this.txtArchiveOrderIdFilter.Location = new System.Drawing.Point(582, 19);
            this.txtArchiveOrderIdFilter.Name = "txtArchiveOrderIdFilter";
            this.txtArchiveOrderIdFilter.Size = new System.Drawing.Size(150, 31);
            this.txtArchiveOrderIdFilter.TabIndex = 19;
            this.txtArchiveOrderIdFilter.TextChanged += new System.EventHandler(this.FilterOrdersEvent);
            // 
            // ArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 775);
            this.Controls.Add(this.txtArchiveOrderIdFilter);
            this.Controls.Add(this.lblArchiveOrderIdFilter);
            this.Controls.Add(this.lblCostTotal);
            this.Controls.Add(this.lblPlotteringLength);
            this.Controls.Add(this.lblLaminationArea);
            this.Controls.Add(this.lblPrintArea);
            this.Controls.Add(this.lblPaperTotal);
            this.Controls.Add(this.lblLayoutsTotal);
            this.Controls.Add(this.lblOrdersTotal);
            this.Controls.Add(this.lblDeliveryDateTill);
            this.Controls.Add(this.deliveryDateTillPicker);
            this.Controls.Add(this.deliveryDateFromPicker);
            this.Controls.Add(this.lblDeliveryDateFrom);
            this.Controls.Add(this.orderDateTillPicker);
            this.Controls.Add(this.lblOrderDateTill);
            this.Controls.Add(this.orderDateFromPicker);
            this.Controls.Add(this.lblOrderDateFrom);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.archiveOrdersGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArchiveForm";
            this.Text = "Архив";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.archiveOrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView archiveOrdersGrid;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label lblOrderDateFrom;
        private System.Windows.Forms.DateTimePicker orderDateFromPicker;
        private System.Windows.Forms.Label lblOrderDateTill;
        private System.Windows.Forms.DateTimePicker orderDateTillPicker;
        private System.Windows.Forms.Label lblDeliveryDateFrom;
        private System.Windows.Forms.DateTimePicker deliveryDateFromPicker;
        private System.Windows.Forms.DateTimePicker deliveryDateTillPicker;
        private System.Windows.Forms.Label lblDeliveryDateTill;
        private System.Windows.Forms.Label lblOrdersTotal;
        private System.Windows.Forms.Label lblLayoutsTotal;
        private System.Windows.Forms.Label lblPaperTotal;
        private System.Windows.Forms.Label lblPrintArea;
        private System.Windows.Forms.Label lblLaminationArea;
        private System.Windows.Forms.Label lblPlotteringLength;
        private System.Windows.Forms.Label lblCostTotal;
        private System.Windows.Forms.Label lblArchiveOrderIdFilter;
        private System.Windows.Forms.TextBox txtArchiveOrderIdFilter;
    }
}