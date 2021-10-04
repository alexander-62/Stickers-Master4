namespace Stickers.WinForms.WorkStatistics
{
    partial class WorkStatisticsForm
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
            this.tabControlWorkStatistics = new System.Windows.Forms.TabControl();
            this.workReportsTab = new System.Windows.Forms.TabPage();
            this.txtWorkStatisticsOrderIdFilter = new System.Windows.Forms.TextBox();
            this.lblWorkStaticticsOrderIdFilter = new System.Windows.Forms.Label();
            this.lblOverallCost = new System.Windows.Forms.Label();
            this.lblWorkReportsAmount = new System.Windows.Forms.Label();
            this.deliveryEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryEndDate = new System.Windows.Forms.Label();
            this.deliveryStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDeliveryStartDate = new System.Windows.Forms.Label();
            this.lblPlotteredLength = new System.Windows.Forms.Label();
            this.lblPrintedArea = new System.Windows.Forms.Label();
            this.lblPaperCutCount = new System.Windows.Forms.Label();
            this.lblLaminatedArea = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.workTypeCombobox = new System.Windows.Forms.ComboBox();
            this.lblWorkType = new System.Windows.Forms.Label();
            this.userNameCombobox = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.workReportsGrid = new System.Windows.Forms.DataGridView();
            this.salaryTab = new System.Windows.Forms.TabPage();
            this.tabControlWorkStatistics.SuspendLayout();
            this.workReportsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workReportsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlWorkStatistics
            // 
            this.tabControlWorkStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlWorkStatistics.Controls.Add(this.workReportsTab);
            this.tabControlWorkStatistics.Controls.Add(this.salaryTab);
            this.tabControlWorkStatistics.Location = new System.Drawing.Point(12, 12);
            this.tabControlWorkStatistics.Name = "tabControlWorkStatistics";
            this.tabControlWorkStatistics.SelectedIndex = 0;
            this.tabControlWorkStatistics.Size = new System.Drawing.Size(1187, 545);
            this.tabControlWorkStatistics.TabIndex = 0;
            this.tabControlWorkStatistics.SelectedIndexChanged += new System.EventHandler(this.TabControlWorkStatistics_SelectedIndexChanged);
            // 
            // workReportsTab
            // 
            this.workReportsTab.Controls.Add(this.txtWorkStatisticsOrderIdFilter);
            this.workReportsTab.Controls.Add(this.lblWorkStaticticsOrderIdFilter);
            this.workReportsTab.Controls.Add(this.lblOverallCost);
            this.workReportsTab.Controls.Add(this.lblWorkReportsAmount);
            this.workReportsTab.Controls.Add(this.deliveryEndDatePicker);
            this.workReportsTab.Controls.Add(this.lblDeliveryEndDate);
            this.workReportsTab.Controls.Add(this.deliveryStartDatePicker);
            this.workReportsTab.Controls.Add(this.lblDeliveryStartDate);
            this.workReportsTab.Controls.Add(this.lblPlotteredLength);
            this.workReportsTab.Controls.Add(this.lblPrintedArea);
            this.workReportsTab.Controls.Add(this.lblPaperCutCount);
            this.workReportsTab.Controls.Add(this.lblLaminatedArea);
            this.workReportsTab.Controls.Add(this.endDateTimePicker);
            this.workReportsTab.Controls.Add(this.lblEndDate);
            this.workReportsTab.Controls.Add(this.startDateTimePicker);
            this.workReportsTab.Controls.Add(this.lblStartDate);
            this.workReportsTab.Controls.Add(this.workTypeCombobox);
            this.workReportsTab.Controls.Add(this.lblWorkType);
            this.workReportsTab.Controls.Add(this.userNameCombobox);
            this.workReportsTab.Controls.Add(this.lblUserName);
            this.workReportsTab.Controls.Add(this.workReportsGrid);
            this.workReportsTab.Location = new System.Drawing.Point(4, 24);
            this.workReportsTab.Name = "workReportsTab";
            this.workReportsTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.workReportsTab.Size = new System.Drawing.Size(1179, 517);
            this.workReportsTab.TabIndex = 0;
            this.workReportsTab.Text = "Отчеты о работе";
            this.workReportsTab.UseVisualStyleBackColor = true;
            // 
            // txtWorkStatisticsOrderIdFilter
            // 
            this.txtWorkStatisticsOrderIdFilter.Location = new System.Drawing.Point(736, 35);
            this.txtWorkStatisticsOrderIdFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWorkStatisticsOrderIdFilter.Name = "txtWorkStatisticsOrderIdFilter";
            this.txtWorkStatisticsOrderIdFilter.Size = new System.Drawing.Size(106, 23);
            this.txtWorkStatisticsOrderIdFilter.TabIndex = 20;
            this.txtWorkStatisticsOrderIdFilter.TextChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblWorkStaticticsOrderIdFilter
            // 
            this.lblWorkStaticticsOrderIdFilter.AutoSize = true;
            this.lblWorkStaticticsOrderIdFilter.Location = new System.Drawing.Point(641, 36);
            this.lblWorkStaticticsOrderIdFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkStaticticsOrderIdFilter.Name = "lblWorkStaticticsOrderIdFilter";
            this.lblWorkStaticticsOrderIdFilter.Size = new System.Drawing.Size(85, 15);
            this.lblWorkStaticticsOrderIdFilter.TabIndex = 19;
            this.lblWorkStaticticsOrderIdFilter.Text = "Номер заказа:";
            // 
            // lblOverallCost
            // 
            this.lblOverallCost.AutoSize = true;
            this.lblOverallCost.Location = new System.Drawing.Point(846, 10);
            this.lblOverallCost.Name = "lblOverallCost";
            this.lblOverallCost.Size = new System.Drawing.Size(163, 15);
            this.lblOverallCost.TabIndex = 18;
            this.lblOverallCost.Text = "Общая стоимость стикеров:";
            // 
            // lblWorkReportsAmount
            // 
            this.lblWorkReportsAmount.AutoSize = true;
            this.lblWorkReportsAmount.Location = new System.Drawing.Point(641, 10);
            this.lblWorkReportsAmount.Name = "lblWorkReportsAmount";
            this.lblWorkReportsAmount.Size = new System.Drawing.Size(98, 15);
            this.lblWorkReportsAmount.TabIndex = 17;
            this.lblWorkReportsAmount.Text = "Всего операций:";
            // 
            // deliveryEndDatePicker
            // 
            this.deliveryEndDatePicker.Checked = false;
            this.deliveryEndDatePicker.Location = new System.Drawing.Point(388, 65);
            this.deliveryEndDatePicker.Name = "deliveryEndDatePicker";
            this.deliveryEndDatePicker.ShowCheckBox = true;
            this.deliveryEndDatePicker.Size = new System.Drawing.Size(231, 23);
            this.deliveryEndDatePicker.TabIndex = 16;
            this.deliveryEndDatePicker.ValueChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblDeliveryEndDate
            // 
            this.lblDeliveryEndDate.AutoSize = true;
            this.lblDeliveryEndDate.Location = new System.Drawing.Point(354, 70);
            this.lblDeliveryEndDate.Name = "lblDeliveryEndDate";
            this.lblDeliveryEndDate.Size = new System.Drawing.Size(25, 15);
            this.lblDeliveryEndDate.TabIndex = 15;
            this.lblDeliveryEndDate.Text = "До:";
            // 
            // deliveryStartDatePicker
            // 
            this.deliveryStartDatePicker.Checked = false;
            this.deliveryStartDatePicker.Location = new System.Drawing.Point(119, 65);
            this.deliveryStartDatePicker.Name = "deliveryStartDatePicker";
            this.deliveryStartDatePicker.ShowCheckBox = true;
            this.deliveryStartDatePicker.Size = new System.Drawing.Size(228, 23);
            this.deliveryStartDatePicker.TabIndex = 14;
            this.deliveryStartDatePicker.ValueChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblDeliveryStartDate
            // 
            this.lblDeliveryStartDate.AutoSize = true;
            this.lblDeliveryStartDate.Location = new System.Drawing.Point(0, 71);
            this.lblDeliveryStartDate.Name = "lblDeliveryStartDate";
            this.lblDeliveryStartDate.Size = new System.Drawing.Size(113, 15);
            this.lblDeliveryStartDate.TabIndex = 13;
            this.lblDeliveryStartDate.Text = "Заказ отправлен с: ";
            // 
            // lblPlotteredLength
            // 
            this.lblPlotteredLength.AutoSize = true;
            this.lblPlotteredLength.Location = new System.Drawing.Point(522, 103);
            this.lblPlotteredLength.Name = "lblPlotteredLength";
            this.lblPlotteredLength.Size = new System.Drawing.Size(180, 15);
            this.lblPlotteredLength.TabIndex = 12;
            this.lblPlotteredLength.Text = "Всего порезано на плоттере м: ";
            // 
            // lblPrintedArea
            // 
            this.lblPrintedArea.AutoSize = true;
            this.lblPrintedArea.Location = new System.Drawing.Point(3, 103);
            this.lblPrintedArea.Name = "lblPrintedArea";
            this.lblPrintedArea.Size = new System.Drawing.Size(138, 15);
            this.lblPrintedArea.TabIndex = 11;
            this.lblPrintedArea.Text = "Всего напечатано кв.м.:";
            // 
            // lblPaperCutCount
            // 
            this.lblPaperCutCount.AutoSize = true;
            this.lblPaperCutCount.Location = new System.Drawing.Point(833, 103);
            this.lblPaperCutCount.Name = "lblPaperCutCount";
            this.lblPaperCutCount.Size = new System.Drawing.Size(139, 15);
            this.lblPaperCutCount.TabIndex = 10;
            this.lblPaperCutCount.Text = "Всего нарезано листов: ";
            // 
            // lblLaminatedArea
            // 
            this.lblLaminatedArea.AutoSize = true;
            this.lblLaminatedArea.Location = new System.Drawing.Point(249, 103);
            this.lblLaminatedArea.Name = "lblLaminatedArea";
            this.lblLaminatedArea.Size = new System.Drawing.Size(174, 15);
            this.lblLaminatedArea.TabIndex = 9;
            this.lblLaminatedArea.Text = "Всего заламинировано, кв.м.: ";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Checked = false;
            this.endDateTimePicker.Location = new System.Drawing.Point(350, 35);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowCheckBox = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(232, 23);
            this.endDateTimePicker.TabIndex = 8;
            this.endDateTimePicker.ValueChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(318, 39);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(25, 15);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "До:";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Checked = false;
            this.startDateTimePicker.Location = new System.Drawing.Point(76, 36);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.ShowCheckBox = true;
            this.startDateTimePicker.Size = new System.Drawing.Size(235, 23);
            this.startDateTimePicker.TabIndex = 6;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(3, 39);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(67, 15);
            this.lblStartDate.TabIndex = 5;
            this.lblStartDate.Text = "Начиная с:";
            // 
            // workTypeCombobox
            // 
            this.workTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workTypeCombobox.FormattingEnabled = true;
            this.workTypeCombobox.Location = new System.Drawing.Point(342, 7);
            this.workTypeCombobox.Name = "workTypeCombobox";
            this.workTypeCombobox.Size = new System.Drawing.Size(169, 23);
            this.workTypeCombobox.TabIndex = 4;
            this.workTypeCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblWorkType
            // 
            this.lblWorkType.AutoSize = true;
            this.lblWorkType.Location = new System.Drawing.Point(270, 10);
            this.lblWorkType.Name = "lblWorkType";
            this.lblWorkType.Size = new System.Drawing.Size(65, 15);
            this.lblWorkType.TabIndex = 3;
            this.lblWorkType.Text = "Операция:";
            // 
            // userNameCombobox
            // 
            this.userNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userNameCombobox.FormattingEnabled = true;
            this.userNameCombobox.Location = new System.Drawing.Point(104, 7);
            this.userNameCombobox.Name = "userNameCombobox";
            this.userNameCombobox.Size = new System.Drawing.Size(160, 23);
            this.userNameCombobox.TabIndex = 2;
            this.userNameCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterReportsEvent);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 15);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Имя работника:";
            // 
            // workReportsGrid
            // 
            this.workReportsGrid.AllowUserToAddRows = false;
            this.workReportsGrid.AllowUserToDeleteRows = false;
            this.workReportsGrid.AllowUserToResizeColumns = false;
            this.workReportsGrid.AllowUserToResizeRows = false;
            this.workReportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workReportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workReportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workReportsGrid.Location = new System.Drawing.Point(3, 121);
            this.workReportsGrid.Name = "workReportsGrid";
            this.workReportsGrid.ReadOnly = true;
            this.workReportsGrid.RowHeadersVisible = false;
            this.workReportsGrid.RowHeadersWidth = 62;
            this.workReportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.workReportsGrid.Size = new System.Drawing.Size(1173, 393);
            this.workReportsGrid.TabIndex = 0;
            this.workReportsGrid.Text = "dataGridView1";
            // 
            // salaryTab
            // 
            this.salaryTab.Location = new System.Drawing.Point(4, 24);
            this.salaryTab.Name = "salaryTab";
            this.salaryTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.salaryTab.Size = new System.Drawing.Size(1179, 517);
            this.salaryTab.TabIndex = 1;
            this.salaryTab.Text = "Зарплата";
            this.salaryTab.UseVisualStyleBackColor = true;
            // 
            // WorkStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 569);
            this.Controls.Add(this.tabControlWorkStatistics);
            this.Name = "WorkStatisticsForm";
            this.Text = "Рабочая статистика";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkStatisticsForm_Load);
            this.tabControlWorkStatistics.ResumeLayout(false);
            this.workReportsTab.ResumeLayout(false);
            this.workReportsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workReportsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWorkStatistics;
        private System.Windows.Forms.TabPage workReportsTab;
        private System.Windows.Forms.TabPage salaryTab;
        private System.Windows.Forms.ComboBox workTypeCombobox;
        private System.Windows.Forms.Label lblWorkType;
        private System.Windows.Forms.ComboBox userNameCombobox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.DataGridView workReportsGrid;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblPrintedArea;
        private System.Windows.Forms.Label lblPaperCutCount;
        private System.Windows.Forms.Label lblLaminatedArea;
        private System.Windows.Forms.Label lblPlotteredLength;
        private System.Windows.Forms.DateTimePicker deliveryEndDatePicker;
        private System.Windows.Forms.Label lblDeliveryEndDate;
        private System.Windows.Forms.DateTimePicker deliveryStartDatePicker;
        private System.Windows.Forms.Label lblDeliveryStartDate;
        private System.Windows.Forms.Label lblWorkReportsAmount;
        private System.Windows.Forms.Label lblOverallCost;
        private System.Windows.Forms.TextBox txtWorkStatisticsOrderIdFilter;
        private System.Windows.Forms.Label lblWorkStaticticsOrderIdFilter;
    }
}