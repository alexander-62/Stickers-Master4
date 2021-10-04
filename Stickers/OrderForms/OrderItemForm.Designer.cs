namespace Stickers.WinForms.OrderForms
{
    partial class OrderItemForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCommentForDesigner = new System.Windows.Forms.Label();
            this.txtCommentForDesigner = new System.Windows.Forms.TextBox();
            this.errorCuttingLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.cuttingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblCuttingType = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.filmComboBox = new System.Windows.Forms.ComboBox();
            this.lblLamination = new System.Windows.Forms.Label();
            this.laminationComboBox = new System.Windows.Forms.ComboBox();
            this.lblPaperCount = new System.Windows.Forms.Label();
            this.txtPaperCount = new System.Windows.Forms.TextBox();
            this.errorPaperCount = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPaperType = new System.Windows.Forms.Label();
            this.paperTypeComboBox = new System.Windows.Forms.ComboBox();
            this.lblPaperLength = new System.Windows.Forms.Label();
            this.txtPaperLength = new System.Windows.Forms.TextBox();
            this.lblPaperWidth = new System.Windows.Forms.Label();
            this.txtPaperWidth = new System.Windows.Forms.TextBox();
            this.errorPaperLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPaperWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorCuttingType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilmType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLaminationType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLayoutName = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadSources = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.errorDiscount = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCommentForProduction = new System.Windows.Forms.Label();
            this.txtCommentForProduction = new System.Windows.Forms.TextBox();
            this.lblManualPricing = new System.Windows.Forms.Label();
            this.txtManualPrice = new System.Windows.Forms.TextBox();
            this.errorManualPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadContour = new System.Windows.Forms.Button();
            this.errorLoadContour = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilmType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLaminationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLayoutName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManualPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoadContour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(103, 15);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Название макета:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(205, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDescription_Validating);
            // 
            // lblCommentForDesigner
            // 
            this.lblCommentForDesigner.AutoSize = true;
            this.lblCommentForDesigner.Location = new System.Drawing.Point(12, 38);
            this.lblCommentForDesigner.Name = "lblCommentForDesigner";
            this.lblCommentForDesigner.Size = new System.Drawing.Size(169, 15);
            this.lblCommentForDesigner.TabIndex = 2;
            this.lblCommentForDesigner.Text = "Комментарий для дизайнера:";
            // 
            // txtCommentForDesigner
            // 
            this.txtCommentForDesigner.CausesValidation = false;
            this.txtCommentForDesigner.Location = new System.Drawing.Point(205, 35);
            this.txtCommentForDesigner.Name = "txtCommentForDesigner";
            this.txtCommentForDesigner.Size = new System.Drawing.Size(267, 23);
            this.txtCommentForDesigner.TabIndex = 2;
            // 
            // errorCuttingLength
            // 
            this.errorCuttingLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCuttingLength.ContainerControl = this;
            // 
            // cuttingTypeComboBox
            // 
            this.cuttingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuttingTypeComboBox.FormattingEnabled = true;
            this.cuttingTypeComboBox.Location = new System.Drawing.Point(205, 94);
            this.cuttingTypeComboBox.Name = "cuttingTypeComboBox";
            this.cuttingTypeComboBox.Size = new System.Drawing.Size(267, 23);
            this.cuttingTypeComboBox.TabIndex = 4;
            this.cuttingTypeComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.CuttingTypeComboBox_Validating);
            // 
            // lblCuttingType
            // 
            this.lblCuttingType.AutoSize = true;
            this.lblCuttingType.Location = new System.Drawing.Point(12, 97);
            this.lblCuttingType.Name = "lblCuttingType";
            this.lblCuttingType.Size = new System.Drawing.Size(65, 15);
            this.lblCuttingType.TabIndex = 7;
            this.lblCuttingType.Text = "Тип резки:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(12, 126);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(74, 15);
            this.lblFilm.TabIndex = 8;
            this.lblFilm.Text = "Тип пленки:";
            // 
            // filmComboBox
            // 
            this.filmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmComboBox.FormattingEnabled = true;
            this.filmComboBox.Location = new System.Drawing.Point(205, 123);
            this.filmComboBox.Name = "filmComboBox";
            this.filmComboBox.Size = new System.Drawing.Size(267, 23);
            this.filmComboBox.TabIndex = 5;
            this.filmComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.FilmComboBox_Validating);
            // 
            // lblLamination
            // 
            this.lblLamination.AutoSize = true;
            this.lblLamination.Location = new System.Drawing.Point(12, 155);
            this.lblLamination.Name = "lblLamination";
            this.lblLamination.Size = new System.Drawing.Size(73, 15);
            this.lblLamination.TabIndex = 10;
            this.lblLamination.Text = "Ламинация:";
            // 
            // laminationComboBox
            // 
            this.laminationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.laminationComboBox.FormattingEnabled = true;
            this.laminationComboBox.Location = new System.Drawing.Point(205, 152);
            this.laminationComboBox.Name = "laminationComboBox";
            this.laminationComboBox.Size = new System.Drawing.Size(267, 23);
            this.laminationComboBox.TabIndex = 6;
            this.laminationComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.LaminationComboBox_Validating);
            // 
            // lblPaperCount
            // 
            this.lblPaperCount.AutoSize = true;
            this.lblPaperCount.Location = new System.Drawing.Point(12, 185);
            this.lblPaperCount.Name = "lblPaperCount";
            this.lblPaperCount.Size = new System.Drawing.Size(116, 15);
            this.lblPaperCount.TabIndex = 14;
            this.lblPaperCount.Text = "Количество листов:";
            // 
            // txtPaperCount
            // 
            this.txtPaperCount.Location = new System.Drawing.Point(205, 182);
            this.txtPaperCount.Name = "txtPaperCount";
            this.txtPaperCount.Size = new System.Drawing.Size(267, 23);
            this.txtPaperCount.TabIndex = 7;
            this.txtPaperCount.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPaperCount_Validating);
            // 
            // errorPaperCount
            // 
            this.errorPaperCount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPaperCount.ContainerControl = this;
            // 
            // lblPaperType
            // 
            this.lblPaperType.AutoSize = true;
            this.lblPaperType.Location = new System.Drawing.Point(12, 275);
            this.lblPaperType.Name = "lblPaperType";
            this.lblPaperType.Size = new System.Drawing.Size(84, 15);
            this.lblPaperType.TabIndex = 17;
            this.lblPaperType.Text = "Размер листа:";
            // 
            // paperTypeComboBox
            // 
            this.paperTypeComboBox.CausesValidation = false;
            this.paperTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paperTypeComboBox.FormattingEnabled = true;
            this.paperTypeComboBox.Location = new System.Drawing.Point(205, 272);
            this.paperTypeComboBox.Name = "paperTypeComboBox";
            this.paperTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.paperTypeComboBox.TabIndex = 10;
            this.paperTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.PaperTypeComboBox_SelectedIndexChanged);
            // 
            // lblPaperLength
            // 
            this.lblPaperLength.AutoSize = true;
            this.lblPaperLength.Location = new System.Drawing.Point(12, 304);
            this.lblPaperLength.Name = "lblPaperLength";
            this.lblPaperLength.Size = new System.Drawing.Size(103, 15);
            this.lblPaperLength.TabIndex = 19;
            this.lblPaperLength.Text = "Длина листа, мм:";
            // 
            // txtPaperLength
            // 
            this.txtPaperLength.Location = new System.Drawing.Point(205, 301);
            this.txtPaperLength.Name = "txtPaperLength";
            this.txtPaperLength.Size = new System.Drawing.Size(121, 23);
            this.txtPaperLength.TabIndex = 11;
            this.txtPaperLength.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPaperLength_Validating);
            // 
            // lblPaperWidth
            // 
            this.lblPaperWidth.AutoSize = true;
            this.lblPaperWidth.Location = new System.Drawing.Point(12, 333);
            this.lblPaperWidth.Name = "lblPaperWidth";
            this.lblPaperWidth.Size = new System.Drawing.Size(113, 15);
            this.lblPaperWidth.TabIndex = 21;
            this.lblPaperWidth.Text = "Ширина листа, мм:";
            // 
            // txtPaperWidth
            // 
            this.txtPaperWidth.Location = new System.Drawing.Point(205, 330);
            this.txtPaperWidth.Name = "txtPaperWidth";
            this.txtPaperWidth.Size = new System.Drawing.Size(121, 23);
            this.txtPaperWidth.TabIndex = 12;
            this.txtPaperWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPaperWidth_Validating);
            // 
            // errorPaperLength
            // 
            this.errorPaperLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPaperLength.ContainerControl = this;
            // 
            // errorPaperWidth
            // 
            this.errorPaperWidth.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPaperWidth.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(302, 428);
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
            this.btnCancel.Location = new System.Drawing.Point(396, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorCuttingType
            // 
            this.errorCuttingType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCuttingType.ContainerControl = this;
            // 
            // errorFilmType
            // 
            this.errorFilmType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorFilmType.ContainerControl = this;
            // 
            // errorLaminationType
            // 
            this.errorLaminationType.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLaminationType.ContainerControl = this;
            // 
            // errorLayoutName
            // 
            this.errorLayoutName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLayoutName.ContainerControl = this;
            // 
            // btnLoadSources
            // 
            this.btnLoadSources.Location = new System.Drawing.Point(12, 365);
            this.btnLoadSources.Name = "btnLoadSources";
            this.btnLoadSources.Size = new System.Drawing.Size(121, 40);
            this.btnLoadSources.TabIndex = 13;
            this.btnLoadSources.Text = "Загрузить исходники";
            this.btnLoadSources.UseVisualStyleBackColor = true;
            this.btnLoadSources.Click += new System.EventHandler(this.BtnLoadSources_Click);
            this.btnLoadSources.Validating += new System.ComponentModel.CancelEventHandler(this.BtnLoadSources_Validating);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(12, 214);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 15);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "Скидка:";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(205, 211);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(267, 23);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDiscount_Validating);
            // 
            // errorDiscount
            // 
            this.errorDiscount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDiscount.ContainerControl = this;
            // 
            // lblCommentForProduction
            // 
            this.lblCommentForProduction.AutoSize = true;
            this.lblCommentForProduction.Location = new System.Drawing.Point(12, 67);
            this.lblCommentForProduction.Name = "lblCommentForProduction";
            this.lblCommentForProduction.Size = new System.Drawing.Size(187, 15);
            this.lblCommentForProduction.TabIndex = 24;
            this.lblCommentForProduction.Text = "Комментарий для производства:";
            // 
            // txtCommentForProduction
            // 
            this.txtCommentForProduction.CausesValidation = false;
            this.txtCommentForProduction.Location = new System.Drawing.Point(205, 64);
            this.txtCommentForProduction.Name = "txtCommentForProduction";
            this.txtCommentForProduction.Size = new System.Drawing.Size(267, 23);
            this.txtCommentForProduction.TabIndex = 3;
            // 
            // lblManualPricing
            // 
            this.lblManualPricing.AutoSize = true;
            this.lblManualPricing.Location = new System.Drawing.Point(12, 245);
            this.lblManualPricing.Name = "lblManualPricing";
            this.lblManualPricing.Size = new System.Drawing.Size(80, 15);
            this.lblManualPricing.TabIndex = 25;
            this.lblManualPricing.Text = "Цена за лист:";
            // 
            // txtManualPrice
            // 
            this.txtManualPrice.Location = new System.Drawing.Point(205, 241);
            this.txtManualPrice.Name = "txtManualPrice";
            this.txtManualPrice.Size = new System.Drawing.Size(267, 23);
            this.txtManualPrice.TabIndex = 9;
            this.txtManualPrice.Validating += new System.ComponentModel.CancelEventHandler(this.TxtManualPrice_Validating);
            // 
            // errorManualPrice
            // 
            this.errorManualPrice.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorManualPrice.ContainerControl = this;
            // 
            // btnLoadContour
            // 
            this.btnLoadContour.Location = new System.Drawing.Point(205, 365);
            this.btnLoadContour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadContour.Name = "btnLoadContour";
            this.btnLoadContour.Size = new System.Drawing.Size(121, 40);
            this.btnLoadContour.TabIndex = 14;
            this.btnLoadContour.Text = "Загрузить контур";
            this.btnLoadContour.UseVisualStyleBackColor = true;
            this.btnLoadContour.Click += new System.EventHandler(this.BtnLoadContour_Click);
            // 
            // errorLoadContour
            // 
            this.errorLoadContour.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLoadContour.ContainerControl = this;
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(514, 458);
            this.Controls.Add(this.btnLoadContour);
            this.Controls.Add(this.txtManualPrice);
            this.Controls.Add(this.lblManualPricing);
            this.Controls.Add(this.txtCommentForProduction);
            this.Controls.Add(this.lblCommentForProduction);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnLoadSources);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtPaperWidth);
            this.Controls.Add(this.lblPaperWidth);
            this.Controls.Add(this.txtPaperLength);
            this.Controls.Add(this.lblPaperLength);
            this.Controls.Add(this.paperTypeComboBox);
            this.Controls.Add(this.lblPaperType);
            this.Controls.Add(this.txtPaperCount);
            this.Controls.Add(this.lblPaperCount);
            this.Controls.Add(this.laminationComboBox);
            this.Controls.Add(this.lblLamination);
            this.Controls.Add(this.filmComboBox);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblCuttingType);
            this.Controls.Add(this.cuttingTypeComboBox);
            this.Controls.Add(this.txtCommentForDesigner);
            this.Controls.Add(this.lblCommentForDesigner);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "OrderItemForm";
            this.Text = "Макет";
            this.Load += new System.EventHandler(this.OrderItemForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderItemForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPaperWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilmType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLaminationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLayoutName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorManualPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoadContour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCommentForDesigner;
        private System.Windows.Forms.TextBox txtCommentForDesigner;
        private System.Windows.Forms.ErrorProvider errorCuttingLength;
        private System.Windows.Forms.Label lblCuttingType;
        private System.Windows.Forms.ComboBox cuttingTypeComboBox;
        private System.Windows.Forms.ComboBox filmComboBox;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.ComboBox laminationComboBox;
        private System.Windows.Forms.Label lblLamination;
        private System.Windows.Forms.TextBox txtPaperCount;
        private System.Windows.Forms.Label lblPaperCount;
        private System.Windows.Forms.ErrorProvider errorPaperCount;
        private System.Windows.Forms.ComboBox paperTypeComboBox;
        private System.Windows.Forms.Label lblPaperType;
        private System.Windows.Forms.TextBox txtPaperWidth;
        private System.Windows.Forms.Label lblPaperWidth;
        private System.Windows.Forms.TextBox txtPaperLength;
        private System.Windows.Forms.Label lblPaperLength;
        private System.Windows.Forms.ErrorProvider errorPaperLength;
        private System.Windows.Forms.ErrorProvider errorPaperWidth;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorCuttingType;
        private System.Windows.Forms.ErrorProvider errorFilmType;
        private System.Windows.Forms.ErrorProvider errorLaminationType;
        private System.Windows.Forms.ErrorProvider errorLayoutName;
        private System.Windows.Forms.Button btnLoadSources;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ErrorProvider errorDiscount;
        private System.Windows.Forms.TextBox txtCommentForProduction;
        private System.Windows.Forms.Label lblCommentForProduction;
        private System.Windows.Forms.TextBox txtManualPrice;
        private System.Windows.Forms.Label lblManualPricing;
        private System.Windows.Forms.ErrorProvider errorManualPrice;
        private System.Windows.Forms.Button btnLoadContour;
        private System.Windows.Forms.ErrorProvider errorLoadContour;
    }
}