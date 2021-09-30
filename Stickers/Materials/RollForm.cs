using System;
using Stickers.Data.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Stickers.WinForms.Materials
{
    public partial class RollForm : Form
    {
        private const int DefaultLength = 50;

        public Film Film => (Film) filmComboBox.SelectedItem;
        public string Manufacturer => txtManufacturer.Text.Trim();
        public int Thickness => int.Parse(txtThickness.Text.Trim());
        public decimal RollWidth => decimal.Parse(txtWidth.Text.Trim());
        public decimal Length => decimal.Parse(txtLength.Text.Trim());
        public decimal PurchasePrice => decimal.Parse(txtPurchasePrice.Text.Trim());
        public decimal SellingPrice => decimal.Parse(txtSellingPrice.Text.Trim());
        public RollForm(List<Film> films)
        {
            InitializeComponent();
            var filmsWithDefault = new List<Film>
                {
                    new Film { Id = 0, Name = "Не выбрана" }
                };
            filmsWithDefault.AddRange(films);
            filmComboBox.DataSource = new BindingSource(filmsWithDefault, null);
            filmComboBox.DisplayMember = "Name";
        }

        private void FilmComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (filmComboBox.SelectedIndex == 0)
            {
                errorFilm.SetError(filmComboBox, "Выберите пленку");
                e.Cancel = true;
            }
            else
            {
                errorFilm.SetError(filmComboBox, "");
                e.Cancel = false;
            }
        }

        private void TxtManufacturer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtManufacturer.Text.Trim()))
            {
                errorManufacturer.SetError(txtManufacturer, "Введите производителя");
                e.Cancel = true;
            }
            else
            {
                errorManufacturer.SetError(txtManufacturer, "");
                e.Cancel = false;
            }
        }

        private void TxtThickness_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtThickness.Text.Trim()) || !int.TryParse(txtThickness.Text.Trim(), out _) || int.Parse(txtThickness.Text.Trim()) <= 0)
            {
                errorThickness.SetError(txtThickness, "Введите толщину");
                e.Cancel = true;
            }
            else
            {
                errorThickness.SetError(txtThickness, "");
                e.Cancel = false;
            }
        }

        private void TxtWidth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtWidth.Text.Trim()) || !decimal.TryParse(txtWidth.Text.Trim(), out _) || decimal.Parse(txtWidth.Text.Trim()) <= 0)
            {
                errorWidth.SetError(txtWidth, "Введите ширину рулона");
                e.Cancel = true;
            }
            else
            {
                errorWidth.SetError(txtWidth, "");
                e.Cancel = false;
            }
        }

        private void TxtLength_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLength.Text.Trim()) || !decimal.TryParse(txtLength.Text.Trim(), out _) || decimal.Parse(txtLength.Text.Trim()) <= 0)
            {
                errorLength.SetError(txtLength, "Введите длину рулона");
                e.Cancel = true;
            }
            else
            {
                errorLength.SetError(txtLength, "");
                e.Cancel = false;
            }
        }

        private void DefaultLengthCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (defaultLengthCheckbox.Checked)
            {
                txtLength.Text = DefaultLength.ToString();
                txtLength.Enabled = false;
            }
            else
            {
                txtLength.Enabled = true;
            }
        }

        private void TxtPurchasePrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPurchasePrice.Text.Trim()) || !decimal.TryParse(txtPurchasePrice.Text.Trim(), out _) || decimal.Parse(txtPurchasePrice.Text.Trim()) <= 0)
            {
                errorPurchasePrice.SetError(txtPurchasePrice, "Введите цену покупки");
                e.Cancel = true;
            }
            else
            {
                errorPurchasePrice.SetError(txtPurchasePrice, "");
                e.Cancel = false;
            }
        }

        private void TxtSellingPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSellingPrice.Text.Trim()) || !decimal.TryParse(txtSellingPrice.Text.Trim(), out _) || decimal.Parse(txtSellingPrice.Text.Trim()) <= 0)
            {
                errorSellingPrice.SetError(txtSellingPrice, "Введите цену продажи");
                e.Cancel = true;
            }
            else
            {
                errorSellingPrice.SetError(txtSellingPrice, "");
                e.Cancel = false;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void RollForm_KeyDown(object sender, KeyEventArgs e)
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
