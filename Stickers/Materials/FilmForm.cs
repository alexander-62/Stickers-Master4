using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Stickers.Data.Entities;

namespace Stickers.WinForms.Materials
{
    public partial class FilmForm : Form
    {
        private readonly List<string> _filmNames;
        private readonly bool _editMode;
        private readonly string _currentFilmName;
        public string FilmName => txtName.Text.Trim();
        public decimal Price => decimal.Parse(txtPrice.Text.Trim());
        public FilmForm(List<string> filmNames)
        {
            _editMode = false;
            _filmNames = filmNames;
            InitializeComponent();
        }

        public FilmForm(List<string> filmNames, Film film) : this(filmNames)
        {
            _editMode = true;
            _currentFilmName = film.Name;
            txtName.Text = film.Name;
            txtPrice.Text = film.Price.ToString(CultureInfo.CurrentCulture);
        }

        private void TxtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorName.SetError(txtName, "Введите название");
                e.Cancel = true;
            }
            else if (!_editMode && _filmNames.Contains(txtName.Text.Trim()))
            {
                errorName.SetError(txtName, "Пленка с таким названием уже существует");
                e.Cancel = true;
            }
            else if (_editMode && _filmNames.Except(new List<string> { _currentFilmName }).Contains(txtName.Text.Trim()))
            {
                errorName.SetError(txtName, "Пленка с таким названием уже существует");
                e.Cancel = true;
            }
            else
            {
                errorName.SetError(txtName,"");
                e.Cancel = false;
            }
        }

        private void TxtPrice_Validating(object sender, CancelEventArgs e)
{
    if (string.IsNullOrEmpty(txtPrice.Text.Trim()) || !decimal.TryParse(txtPrice.Text.Trim(), out _) || decimal.Parse(txtPrice.Text.Trim()) <= 0)
    {
        errorPrice.SetError(txtPrice, "Введите цену для пленки");
        e.Cancel = true;
    }
    else
    {
        errorPrice.SetError(txtPrice, "");
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

private void FilmForm_KeyDown(object sender, KeyEventArgs e)
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
