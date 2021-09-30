using Stickers.Data.Model.Constants;
using System.ComponentModel;
using System.Windows.Forms;

namespace Stickers.WinForms.Materials
{
    public partial class RollExpendForm : Form
    {
        public decimal Length => decimal.Parse(txtLength.Text.Trim());
        public WorkType WorkType => rdBtnPlottering.Checked ? WorkType.Plottering : WorkType.Failure;
        private decimal _rollLength;
        public RollExpendForm(decimal rollLength)
        {
            _rollLength = rollLength;
            InitializeComponent();
        }

        private void txtLength_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLength.Text.Trim()) || !decimal.TryParse(txtLength.Text.Trim(), out _) || decimal.Parse(txtLength.Text.Trim()) <= 0)
            {
                errorLength.SetError(txtLength, "Введите длину");
                e.Cancel = true;
            }
            else if (decimal.Parse(txtLength.Text.Trim()) > _rollLength)
            {
                errorLength.SetError(txtLength, "В рулоне столько нет");
                e.Cancel = true;
            }
            else
            {
                errorLength.SetError(txtLength, "");
                e.Cancel = false;
            }
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
