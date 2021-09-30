namespace Stickers.WinForms.DeliveryForms
{
    partial class AddDeliveryInfoForm
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
            this.lblTrackIdentifier = new System.Windows.Forms.Label();
            this.txtTrackIdentifier = new System.Windows.Forms.TextBox();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.txtDeliveryCost = new System.Windows.Forms.TextBox();
            this.errorDeliveryCost = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrackIdentifier
            // 
            this.lblTrackIdentifier.AutoSize = true;
            this.lblTrackIdentifier.Location = new System.Drawing.Point(13, 13);
            this.lblTrackIdentifier.Name = "lblTrackIdentifier";
            this.lblTrackIdentifier.Size = new System.Drawing.Size(77, 15);
            this.lblTrackIdentifier.TabIndex = 0;
            this.lblTrackIdentifier.Text = "Трэк-номер:";
            // 
            // txtTrackIdentifier
            // 
            this.txtTrackIdentifier.Location = new System.Drawing.Point(155, 10);
            this.txtTrackIdentifier.Name = "txtTrackIdentifier";
            this.txtTrackIdentifier.Size = new System.Drawing.Size(214, 23);
            this.txtTrackIdentifier.TabIndex = 1;
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Location = new System.Drawing.Point(13, 42);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(122, 15);
            this.lblDeliveryCost.TabIndex = 2;
            this.lblDeliveryCost.Text = "Стоимость доставки:";
            // 
            // txtDeliveryCost
            // 
            this.txtDeliveryCost.Location = new System.Drawing.Point(155, 39);
            this.txtDeliveryCost.Name = "txtDeliveryCost";
            this.txtDeliveryCost.Size = new System.Drawing.Size(214, 23);
            this.txtDeliveryCost.TabIndex = 3;
            this.txtDeliveryCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeliveryCost_Validating);
            // 
            // errorDeliveryCost
            // 
            this.errorDeliveryCost.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorDeliveryCost.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(294, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(191, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // AddDeliveryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(419, 114);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDeliveryCost);
            this.Controls.Add(this.lblDeliveryCost);
            this.Controls.Add(this.txtTrackIdentifier);
            this.Controls.Add(this.lblTrackIdentifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "AddDeliveryInfoForm";
            this.Text = "Заполнить информацию по отправке";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDeliveryInfoForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorDeliveryCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrackIdentifier;
        private System.Windows.Forms.TextBox txtTrackIdentifier;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.TextBox txtDeliveryCost;
        private System.Windows.Forms.ErrorProvider errorDeliveryCost;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}