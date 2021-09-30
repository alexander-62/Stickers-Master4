namespace Stickers.WinForms.Materials
{
    partial class RollForm
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
            this.lblFilm = new System.Windows.Forms.Label();
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lblThickness = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.defaultLengthCheckbox = new System.Windows.Forms.CheckBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorFilm = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorManufacturer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorThickness = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPurchasePrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSellingPrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorFilm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManufacturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSellingPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(12, 9);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(51, 15);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Пленка:";
            // 
            // filmComboBox
            // 
            this.filmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.Location = new System.Drawing.Point(121, 6);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(235, 23);
            this.filmComboBox.TabIndex = 1;
            this.filmComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.FilmComboBox_Validating);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(12, 38);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(95, 15);
            this.lblManufacturer.TabIndex = 2;
            this.lblManufacturer.Text = "Производитель:";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(121, 35);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(235, 23);
            this.txtManufacturer.TabIndex = 3;
            this.txtManufacturer.Validating += new System.ComponentModel.CancelEventHandler(this.TxtManufacturer_Validating);
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(12, 68);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(92, 15);
            this.lblThickness.TabIndex = 4;
            this.lblThickness.Text = "Толщина, мкм:";
            // 
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(121, 65);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.Size = new System.Drawing.Size(235, 23);
            this.txtThickness.TabIndex = 5;
            this.txtThickness.Validating += new System.ComponentModel.CancelEventHandler(this.TxtThickness_Validating);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(121, 95);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(235, 23);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TxtWidth_Validating);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(12, 98);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(98, 15);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Ширина рулона:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 128);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(88, 15);
            this.lblLength.TabIndex = 8;
            this.lblLength.Text = "Длина рулона:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(121, 125);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(235, 23);
            this.txtLength.TabIndex = 9;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.TxtLength_Validating);
            // 
            // defaultLengthCheckbox
            // 
            this.defaultLengthCheckbox.AutoSize = true;
            this.defaultLengthCheckbox.Location = new System.Drawing.Point(362, 128);
            this.defaultLengthCheckbox.Name = "defaultLengthCheckbox";
            this.defaultLengthCheckbox.Size = new System.Drawing.Size(111, 19);
            this.defaultLengthCheckbox.TabIndex = 10;
            this.defaultLengthCheckbox.Text = "По умолчанию";
            this.defaultLengthCheckbox.UseVisualStyleBackColor = true;
            this.defaultLengthCheckbox.CheckedChanged += new System.EventHandler(this.DefaultLengthCheckbox_CheckedChanged);
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(121, 154);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(235, 23);
            this.txtPurchasePrice.TabIndex = 11;
            this.txtPurchasePrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPurchasePrice_Validating);
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(121, 184);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(235, 23);
            this.txtSellingPrice.TabIndex = 12;
            this.txtSellingPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSellingPrice_Validating);
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(12, 157);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(87, 15);
            this.lblPurchasePrice.TabIndex = 13;
            this.lblPurchasePrice.Text = "Цена покупки:";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Location = new System.Drawing.Point(12, 187);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(90, 15);
            this.lblSellingPrice.TabIndex = 14;
            this.lblSellingPrice.Text = "Цена продажи:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(187, 243);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorFilm
            // 
            this.errorFilm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorFilm.ContainerControl = this;
            // 
            // errorManufacturer
            // 
            this.errorManufacturer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorManufacturer.ContainerControl = this;
            // 
            // errorThickness
            // 
            this.errorThickness.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorThickness.ContainerControl = this;
            // 
            // errorWidth
            // 
            this.errorWidth.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorWidth.ContainerControl = this;
            // 
            // errorLength
            // 
            this.errorLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLength.ContainerControl = this;
            // 
            // errorPurchasePrice
            // 
            this.errorPurchasePrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPurchasePrice.ContainerControl = this;
            // 
            // errorSellingPrice
            // 
            this.errorSellingPrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorSellingPrice.ContainerControl = this;
            // 
            // RollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(536, 306);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblSellingPrice);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.defaultLengthCheckbox);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.filmComboBox);
            this.Controls.Add(this.lblFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "RollForm";
            this.Text = "Рулон";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RollForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorFilm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManufacturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSellingPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.ComboBox filmComboBox;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.CheckBox defaultLengthCheckbox;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorFilm;
        private System.Windows.Forms.ErrorProvider errorManufacturer;
        private System.Windows.Forms.ErrorProvider errorThickness;
        private System.Windows.Forms.ErrorProvider errorWidth;
        private System.Windows.Forms.ErrorProvider errorLength;
        private System.Windows.Forms.ErrorProvider errorPurchasePrice;
        private System.Windows.Forms.ErrorProvider errorSellingPrice;
    }
}