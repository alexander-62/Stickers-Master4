using Stickers.Data.Model.Constants;
using System;
using System.Windows.Forms;
using System.Linq;
using Stickers.Core.Utilities;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;

namespace Stickers.WinForms.CostForms
{
    public partial class CostForm : Form
    {
        public CostType CostType => ((KeyValuePair<CostType, string>)costTypeComboBox.SelectedItem).Key;
        public decimal Price => decimal.Parse(txtPrice.Text.Trim(), CultureInfo.CurrentCulture);
        public CostForm()
        {
            InitializeComponent();
            InitializeCostTypeComboBox();
        }

        public CostForm(string costType, decimal price) : this()
        {
            InitializeCostTypeComboBox(costType);
            txtPrice.Text = price.ToString(CultureInfo.InvariantCulture);
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void TxtPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()) || !decimal.TryParse(txtPrice.Text.Trim(), out _))
            {
                errorPrice.SetError(txtPrice, "Неверное значение");
                e.Cancel = true;
            }
            else if (decimal.Parse(txtPrice.Text.Trim()) < 0)
            {
                errorPrice.SetError(txtPrice, "Неверное значение");
                e.Cancel = true;
            }
            else
            {
                errorPrice.SetError(txtPrice, "");
                e.Cancel = false;
            }

        }

        private void InitializeCostTypeComboBox(string currentType = null)
        {
            var enumValues = Enum.GetValues(typeof(CostType)).Cast<CostType>().ToList();
            var enumWithDescription = new Dictionary<CostType, string>();
            foreach (var value in enumValues)
            {
                enumWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }

            costTypeComboBox.DataSource = new BindingSource(enumWithDescription, null);
            costTypeComboBox.DisplayMember = "Value";
            costTypeComboBox.ValueMember = "Key";
            if (currentType == null)
            {
                costTypeComboBox.SelectedItem = costTypeComboBox.Items[0];
            }
            else
            {
                var selected = enumWithDescription.First(x => x.Value == currentType);
                costTypeComboBox.SelectedItem = selected;
                costTypeComboBox.Enabled = false;
            }
        }

        private void CostForm_KeyDown(object sender, KeyEventArgs e)
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
