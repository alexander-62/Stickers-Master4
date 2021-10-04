using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using Stickers.Core.Utilities;
using Stickers.Data.Model.Constants;

namespace Stickers.WinForms.OrderForms
{
    public partial class OrderItemContourForm : Form
    {
        public decimal CuttingLength => decimal.Parse(txtCuttingLength.Text.Trim());
        public string ContourFile { get; set; }

        private readonly string _cuttingType;
        public OrderItemContourForm(decimal cuttingLength, string cuttingType)
        {
            InitializeComponent();
            txtCuttingLength.Text = cuttingLength.ToString(CultureInfo.InvariantCulture);
            _cuttingType = cuttingType;
        }

        private void txtCuttingLength_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuttingLength.Text.Trim()) ||
                !decimal.TryParse(txtCuttingLength.Text.Trim(), out _) ||
                decimal.Parse(txtCuttingLength.Text.Trim()) < 0)
            {
                errorCuttingLength.SetError(txtCuttingLength, "Введите длину резки");
                e.Cancel = true;
            }
            else if (_cuttingType == EnumUtility.GetEnumDescription(CuttingType.None) && decimal.Parse(txtCuttingLength.Text.Trim()) != 0)
            {
                errorCuttingLength.SetError(txtCuttingLength, "Для макета без резки длина должна быть 0.");
                e.Cancel = true;
            }
            else if (_cuttingType != EnumUtility.GetEnumDescription(CuttingType.None) &&
                     decimal.Parse(txtCuttingLength.Text.Trim()) == 0)
            {
                errorCuttingLength.SetError(txtCuttingLength, "Для макета с резкой длина не должна быть 0.");
                e.Cancel = true;
            }
            else
            {
                errorCuttingLength.SetError(txtCuttingLength, "");
                e.Cancel = false;
            }
        }

        private void BtnLoadContourFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ContourFile = openFileDialog.FileName;
            }
        }

        private void BtnLoadContourFile_Validating(object sender, CancelEventArgs e)
        {
            if (!CheckBoxFile.Checked)
            {
                if (string.IsNullOrEmpty(ContourFile))
                {
                    errorLoadContour.SetError(btnLoadContourFile, "Загрузите контур");
                    e.Cancel = true;
                }
                else
                {
                    errorLoadContour.SetError(btnLoadContourFile, "");
                    e.Cancel = false;
                }
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void OrderItemContourForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateChildren())
                {
                    DialogResult = DialogResult.OK;
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void CheckBoxFile_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckBoxFile.Checked)
            {
                errorLoadContour.SetError(btnLoadContourFile, "");
                btnLoadContourFile.Enabled = false;
            }
            else
            {
                btnLoadContourFile.Enabled = true;
            }
        }

        private void OrderItemContourForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
