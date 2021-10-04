namespace Stickers.WinForms.OrderForms
{
    partial class OrderItemContourForm
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
            this.lblContourLength = new System.Windows.Forms.Label();
            this.txtCuttingLength = new System.Windows.Forms.TextBox();
            this.errorCuttingLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLoadContourFile = new System.Windows.Forms.Button();
            this.errorLoadContour = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.CheckBoxFile = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoadContour)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContourLength
            // 
            this.lblContourLength.AutoSize = true;
            this.lblContourLength.Location = new System.Drawing.Point(13, 12);
            this.lblContourLength.Name = "lblContourLength";
            this.lblContourLength.Size = new System.Drawing.Size(97, 15);
            this.lblContourLength.TabIndex = 0;
            this.lblContourLength.Text = "Длина резки, м :";
            // 
            // txtCuttingLength
            // 
            this.txtCuttingLength.Location = new System.Drawing.Point(116, 9);
            this.txtCuttingLength.Name = "txtCuttingLength";
            this.txtCuttingLength.Size = new System.Drawing.Size(125, 23);
            this.txtCuttingLength.TabIndex = 1;
            this.txtCuttingLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtCuttingLength_Validating);
            // 
            // errorCuttingLength
            // 
            this.errorCuttingLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorCuttingLength.ContainerControl = this;
            // 
            // btnLoadContourFile
            // 
            this.btnLoadContourFile.Location = new System.Drawing.Point(13, 44);
            this.btnLoadContourFile.Name = "btnLoadContourFile";
            this.btnLoadContourFile.Size = new System.Drawing.Size(130, 23);
            this.btnLoadContourFile.TabIndex = 2;
            this.btnLoadContourFile.Text = "Загрузить файл";
            this.btnLoadContourFile.UseVisualStyleBackColor = true;
            this.btnLoadContourFile.Click += new System.EventHandler(this.BtnLoadContourFile_Click);
            this.btnLoadContourFile.Validating += new System.ComponentModel.CancelEventHandler(this.BtnLoadContourFile_Validating);
            // 
            // errorLoadContour
            // 
            this.errorLoadContour.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLoadContour.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(116, 92);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CheckBoxFile
            // 
            this.CheckBoxFile.AutoSize = true;
            this.CheckBoxFile.Location = new System.Drawing.Point(13, 73);
            this.CheckBoxFile.Name = "CheckBoxFile";
            this.CheckBoxFile.Size = new System.Drawing.Size(133, 19);
            this.CheckBoxFile.TabIndex = 50;
            this.CheckBoxFile.Text = "Файл уже загружен";
            this.CheckBoxFile.UseVisualStyleBackColor = true;
            this.CheckBoxFile.CheckedChanged += new System.EventHandler(this.CheckBoxFile_CheckedChanged);
            // 
            // OrderItemContourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(291, 127);
            this.Controls.Add(this.CheckBoxFile);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoadContourFile);
            this.Controls.Add(this.txtCuttingLength);
            this.Controls.Add(this.lblContourLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "OrderItemContourForm";
            this.Text = "Загрузить контур";
            this.Load += new System.EventHandler(this.OrderItemContourForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderItemContourForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorCuttingLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLoadContour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContourLength;
        private System.Windows.Forms.TextBox txtCuttingLength;
        private System.Windows.Forms.ErrorProvider errorCuttingLength;
        private System.Windows.Forms.Button btnLoadContourFile;
        private System.Windows.Forms.ErrorProvider errorLoadContour;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.CheckBox CheckBoxFile;
    }
}