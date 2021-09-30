using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace Stickers.WinForms.DeliveryForms
{
    public partial class AddDeliveryInfoForm : Form
    {
        public string TrackIdentifier => txtTrackIdentifier.Text.Trim();
        public decimal DeliveryCost => decimal.Parse(txtDeliveryCost.Text.Trim());

        public AddDeliveryInfoForm(string trackIdentifier, decimal deliveryCost)
        {
            InitializeComponent();
            txtTrackIdentifier.Text = trackIdentifier;
            txtDeliveryCost.Text = deliveryCost.ToString(CultureInfo.InvariantCulture);
        }

        private void txtDeliveryCost_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeliveryCost.Text.Trim()) || !decimal.TryParse(txtDeliveryCost.Text.Trim(), out _))
            {
                errorDeliveryCost.SetError(txtDeliveryCost, "Введите стоимость");
                e.Cancel = true;
            }
            else if (decimal.Parse(txtDeliveryCost.Text.Trim()) < 0)
            {
                errorDeliveryCost.SetError(txtDeliveryCost, "Введите стоимость");
                e.Cancel = true;
            }
            else
            {
                errorDeliveryCost.SetError(txtDeliveryCost, "");
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

        private void AddDeliveryInfoForm_KeyDown(object sender, KeyEventArgs e)
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
    }
}
