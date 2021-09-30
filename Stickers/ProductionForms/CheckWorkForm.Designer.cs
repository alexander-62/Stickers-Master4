namespace Stickers.WinForms.ProductionForms
{
    partial class CheckWorkForm
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
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblUsedMeters = new System.Windows.Forms.Label();
            this.txtUsedMeters = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorMeters = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrintedPapers = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkPrintingGrid = new System.Windows.Forms.DataGridView();
            this.rollComboBox = new System.Windows.Forms.ComboBox();
            this.errorRoll = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrintedPapers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrintingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRoll)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(19, 28);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(91, 15);
            this.lblRoll.TabIndex = 0;
            this.lblRoll.Text = "Номер рулона:";
            // 
            // lblUsedMeters
            // 
            this.lblUsedMeters.AutoSize = true;
            this.lblUsedMeters.Location = new System.Drawing.Point(19, 63);
            this.lblUsedMeters.Name = "lblUsedMeters";
            this.lblUsedMeters.Size = new System.Drawing.Size(168, 15);
            this.lblUsedMeters.TabIndex = 1;
            this.lblUsedMeters.Text = "Погонные метры потрачено:";
            // 
            // txtUsedMeters
            // 
            this.txtUsedMeters.Location = new System.Drawing.Point(220, 61);
            this.txtUsedMeters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsedMeters.Name = "txtUsedMeters";
            this.txtUsedMeters.Size = new System.Drawing.Size(121, 23);
            this.txtUsedMeters.TabIndex = 3;
            this.txtUsedMeters.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUsedMeters_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(420, 242);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(82, 22);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(571, 242);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorMeters
            // 
            this.errorMeters.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorMeters.ContainerControl = this;
            // 
            // errorPrintedPapers
            // 
            this.errorPrintedPapers.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPrintedPapers.ContainerControl = this;
            // 
            // checkPrintingGrid
            // 
            this.checkPrintingGrid.AllowUserToAddRows = false;
            this.checkPrintingGrid.AllowUserToDeleteRows = false;
            this.checkPrintingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkPrintingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkPrintingGrid.Location = new System.Drawing.Point(16, 101);
            this.checkPrintingGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPrintingGrid.Name = "checkPrintingGrid";
            this.checkPrintingGrid.RowHeadersVisible = false;
            this.checkPrintingGrid.RowHeadersWidth = 51;
            this.checkPrintingGrid.Size = new System.Drawing.Size(637, 115);
            this.checkPrintingGrid.TabIndex = 10;
            this.checkPrintingGrid.Text = "dataGridView1";
            this.checkPrintingGrid.Validating += new System.ComponentModel.CancelEventHandler(this.CheckPrintingGrid_Validating);
            // 
            // rollComboBox
            // 
            this.rollComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rollComboBox.FormattingEnabled = true;
            this.rollComboBox.Location = new System.Drawing.Point(220, 28);
            this.rollComboBox.Name = "rollComboBox";
            this.rollComboBox.Size = new System.Drawing.Size(121, 23);
            this.rollComboBox.TabIndex = 11;
            this.rollComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.RollComboBox_Validating);
            // 
            // errorRoll
            // 
            this.errorRoll.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorRoll.ContainerControl = this;
            // 
            // CheckWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(693, 285);
            this.Controls.Add(this.rollComboBox);
            this.Controls.Add(this.checkPrintingGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtUsedMeters);
            this.Controls.Add(this.lblUsedMeters);
            this.Controls.Add(this.lblRoll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CheckWorkForm";
            this.Text = "CheckPrintingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckWorkForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrintedPapers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPrintingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRoll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblUsedMeters;
        private System.Windows.Forms.TextBox txtUsedMeters;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorMeters;
        private System.Windows.Forms.ErrorProvider errorPrintedPapers;
        private System.Windows.Forms.DataGridView checkPrintingGrid;
        private System.Windows.Forms.ComboBox rollComboBox;
        private System.Windows.Forms.ErrorProvider errorRoll;
    }
}