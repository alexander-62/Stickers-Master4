namespace Stickers.WinForms.Client
{
    partial class AddClientForm
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblVkId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPostIndex = new System.Windows.Forms.Label();
            this.lblReceiverCredentials = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtVkId = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPostIndex = new System.Windows.Forms.TextBox();
            this.txtReceiverCredentials = new System.Windows.Forms.TextBox();
            this.errorClientName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorVkId = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPostIndex = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorReceiverCredentials = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtVkLink = new System.Windows.Forms.TextBox();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.errorComment = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorVkLink = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtVkGroupName = new System.Windows.Forms.TextBox();
            this.lblVkGroupName = new System.Windows.Forms.Label();
            this.errorVkGroupName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtComment = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorClientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReceiverCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkGroupName)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(12, 9);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(78, 15);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Имя клиента";
            // 
            // lblVkId
            // 
            this.lblVkId.AutoSize = true;
            this.lblVkId.Location = new System.Drawing.Point(12, 40);
            this.lblVkId.Name = "lblVkId";
            this.lblVkId.Size = new System.Drawing.Size(34, 15);
            this.lblVkId.TabIndex = 1;
            this.lblVkId.Text = "VK Id";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 134);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 15);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Адрес";
            // 
            // lblPostIndex
            // 
            this.lblPostIndex.AutoSize = true;
            this.lblPostIndex.Location = new System.Drawing.Point(12, 166);
            this.lblPostIndex.Name = "lblPostIndex";
            this.lblPostIndex.Size = new System.Drawing.Size(105, 15);
            this.lblPostIndex.TabIndex = 1;
            this.lblPostIndex.Text = "Почтовый индекс";
            // 
            // lblReceiverCredentials
            // 
            this.lblReceiverCredentials.AutoSize = true;
            this.lblReceiverCredentials.Location = new System.Drawing.Point(12, 197);
            this.lblReceiverCredentials.Name = "lblReceiverCredentials";
            this.lblReceiverCredentials.Size = new System.Drawing.Size(103, 15);
            this.lblReceiverCredentials.TabIndex = 1;
            this.lblReceiverCredentials.Text = "ФИО Получателя";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(166, 6);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(421, 23);
            this.txtClientName.TabIndex = 0;
            this.txtClientName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClientName_Validating);
            // 
            // txtVkId
            // 
            this.txtVkId.Location = new System.Drawing.Point(166, 37);
            this.txtVkId.Name = "txtVkId";
            this.txtVkId.Size = new System.Drawing.Size(421, 23);
            this.txtVkId.TabIndex = 1;
            this.txtVkId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtVkId_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 131);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(421, 23);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.TxtAddress_Validating);
            // 
            // txtPostIndex
            // 
            this.txtPostIndex.Location = new System.Drawing.Point(166, 163);
            this.txtPostIndex.Name = "txtPostIndex";
            this.txtPostIndex.Size = new System.Drawing.Size(421, 23);
            this.txtPostIndex.TabIndex = 5;
            this.txtPostIndex.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPostIndex_Validating);
            // 
            // txtReceiverCredentials
            // 
            this.txtReceiverCredentials.Location = new System.Drawing.Point(166, 193);
            this.txtReceiverCredentials.Name = "txtReceiverCredentials";
            this.txtReceiverCredentials.Size = new System.Drawing.Size(421, 23);
            this.txtReceiverCredentials.TabIndex = 6;
            this.txtReceiverCredentials.Validating += new System.ComponentModel.CancelEventHandler(this.TxtReceiverCredentials_Validating);
            // 
            // errorClientName
            // 
            this.errorClientName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorClientName.ContainerControl = this;
            // 
            // errorVkId
            // 
            this.errorVkId.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorVkId.ContainerControl = this;
            // 
            // errorAddress
            // 
            this.errorAddress.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorAddress.ContainerControl = this;
            // 
            // errorPostIndex
            // 
            this.errorPostIndex.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPostIndex.ContainerControl = this;
            // 
            // errorReceiverCredentials
            // 
            this.errorReceiverCredentials.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorReceiverCredentials.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(377, 334);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(512, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtVkLink
            // 
            this.txtVkLink.Location = new System.Drawing.Point(166, 68);
            this.txtVkLink.Name = "txtVkLink";
            this.txtVkLink.Size = new System.Drawing.Size(421, 23);
            this.txtVkLink.TabIndex = 2;
            this.txtVkLink.Validating += new System.ComponentModel.CancelEventHandler(this.txtVkLink_Validating);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(12, 72);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(123, 15);
            this.lblLink.TabIndex = 7;
            this.lblLink.Text = "Ссылка на группу ВК";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 225);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(140, 15);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Комментарий к клиенту";
            // 
            // errorComment
            // 
            this.errorComment.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorComment.ContainerControl = this;
            // 
            // errorVkLink
            // 
            this.errorVkLink.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorVkLink.ContainerControl = this;
            // 
            // txtVkGroupName
            // 
            this.txtVkGroupName.Location = new System.Drawing.Point(166, 99);
            this.txtVkGroupName.Name = "txtVkGroupName";
            this.txtVkGroupName.Size = new System.Drawing.Size(421, 23);
            this.txtVkGroupName.TabIndex = 3;
            this.txtVkGroupName.Validating += new System.ComponentModel.CancelEventHandler(this.txtVkGroupName_Validating);
            // 
            // lblVkGroupName
            // 
            this.lblVkGroupName.AutoSize = true;
            this.lblVkGroupName.Location = new System.Drawing.Point(12, 104);
            this.lblVkGroupName.Name = "lblVkGroupName";
            this.lblVkGroupName.Size = new System.Drawing.Size(120, 15);
            this.lblVkGroupName.TabIndex = 11;
            this.lblVkGroupName.Text = "Название группы ВК";
            // 
            // errorVkGroupName
            // 
            this.errorVkGroupName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorVkGroupName.ContainerControl = this;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(166, 222);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(421, 96);
            this.txtComment.TabIndex = 12;
            this.txtComment.Text = "";
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(618, 381);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtVkGroupName);
            this.Controls.Add(this.lblVkGroupName);
            this.Controls.Add(this.txtVkLink);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtReceiverCredentials);
            this.Controls.Add(this.txtPostIndex);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtVkId);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.lblReceiverCredentials);
            this.Controls.Add(this.lblPostIndex);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblVkId);
            this.Controls.Add(this.lblClientName);
            this.KeyPreview = true;
            this.Name = "AddClientForm";
            this.Text = "Клиент";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddClientForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorClientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPostIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorReceiverCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVkGroupName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblVkId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostIndex;
        private System.Windows.Forms.Label lblReceiverCredentials;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtVkId;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPostIndex;
        private System.Windows.Forms.TextBox txtReceiverCredentials;
        private System.Windows.Forms.ErrorProvider errorClientName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorVkId;
        private System.Windows.Forms.ErrorProvider errorAddress;
        private System.Windows.Forms.ErrorProvider errorPostIndex;
        private System.Windows.Forms.ErrorProvider errorReceiverCredentials;
        private System.Windows.Forms.TextBox txtVkLink;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.ErrorProvider errorComment;
        private System.Windows.Forms.ErrorProvider errorVkLink;
        private System.Windows.Forms.TextBox txtVkGroupName;
        private System.Windows.Forms.Label lblVkGroupName;
        private System.Windows.Forms.ErrorProvider errorVkGroupName;
        private System.Windows.Forms.RichTextBox txtComment;
    }
}