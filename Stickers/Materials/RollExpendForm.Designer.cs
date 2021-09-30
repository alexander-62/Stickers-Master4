namespace Stickers.WinForms.Materials
{
    partial class RollExpendForm
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
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.rdBtnPlottering = new System.Windows.Forms.RadioButton();
            this.rdBtnFailure = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorLength = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpReasons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).BeginInit();
            this.grpReasons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 9);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(45, 15);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Длина:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(63, 6);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(190, 23);
            this.txtLength.TabIndex = 1;
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtLength_Validating);
            // 
            // rdBtnPlottering
            // 
            this.rdBtnPlottering.AutoSize = true;
            this.rdBtnPlottering.Location = new System.Drawing.Point(18, 22);
            this.rdBtnPlottering.Name = "rdBtnPlottering";
            this.rdBtnPlottering.Size = new System.Drawing.Size(123, 19);
            this.rdBtnPlottering.TabIndex = 2;
            this.rdBtnPlottering.TabStop = true;
            this.rdBtnPlottering.Text = "Плоттерная резка";
            this.rdBtnPlottering.UseVisualStyleBackColor = true;
            // 
            // rdBtnFailure
            // 
            this.rdBtnFailure.AutoSize = true;
            this.rdBtnFailure.Location = new System.Drawing.Point(173, 22);
            this.rdBtnFailure.Name = "rdBtnFailure";
            this.rdBtnFailure.Size = new System.Drawing.Size(51, 19);
            this.rdBtnFailure.TabIndex = 3;
            this.rdBtnFailure.TabStop = true;
            this.rdBtnFailure.Text = "Брак";
            this.rdBtnFailure.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(97, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(178, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorLength
            // 
            this.errorLength.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorLength.ContainerControl = this;
            // 
            // grpReasons
            // 
            this.grpReasons.Controls.Add(this.rdBtnPlottering);
            this.grpReasons.Controls.Add(this.rdBtnFailure);
            this.grpReasons.Location = new System.Drawing.Point(12, 35);
            this.grpReasons.Name = "grpReasons";
            this.grpReasons.Size = new System.Drawing.Size(241, 50);
            this.grpReasons.TabIndex = 6;
            this.grpReasons.TabStop = false;
            this.grpReasons.Text = "Назначение";
            // 
            // RollExpendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(287, 130);
            this.Controls.Add(this.grpReasons);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RollExpendForm";
            this.Text = "Списание пленки";
            ((System.ComponentModel.ISupportInitialize)(this.errorLength)).EndInit();
            this.grpReasons.ResumeLayout(false);
            this.grpReasons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.RadioButton rdBtnPlottering;
        private System.Windows.Forms.RadioButton rdBtnFailure;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorLength;
        private System.Windows.Forms.GroupBox grpReasons;
    }
}