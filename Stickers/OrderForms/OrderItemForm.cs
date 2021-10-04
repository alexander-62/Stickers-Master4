using Stickers.Core.Services;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Stickers.WinForms.OrderForms
{
    public partial class OrderItemForm : Form
    {
        private readonly char[] SpecialChars = "\\/:?\"<>|".ToCharArray();
        private readonly List<string> _orderItemsNames;
        public string Description => txtDescription.Text.Trim();
        public string CommentForDesigner => txtCommentForDesigner.Text.Trim();
        public string CommentForProduction => txtCommentForProduction.Text.Trim();
        public CuttingType CuttingType => ((KeyValuePair<CuttingType, string>)cuttingTypeComboBox.SelectedItem).Key;
        public decimal CuttingLength { get; set; }
        public Film Film => (Film)filmComboBox.SelectedItem;
        public Lamination Lamination => ((KeyValuePair<Lamination, string>)laminationComboBox.SelectedItem).Key;
        public int PaperCount => int.Parse(txtPaperCount.Text.Trim(), CultureInfo.CurrentCulture);
        public decimal PaperLength =>
            _paperParametersService.GetPaperLength(((KeyValuePair<PaperType, string>)paperTypeComboBox.SelectedItem).Key, txtPaperLength.Text.Trim());
        public decimal PaperWidth =>
            _paperParametersService.GetPaperWidth(((KeyValuePair<PaperType, string>)paperTypeComboBox.SelectedItem).Key, txtPaperWidth.Text.Trim());
        public int Discount => int.Parse(txtDiscount.Text.Trim(), CultureInfo.CurrentCulture);
        public decimal ManualPrice => string.IsNullOrEmpty(txtManualPrice.Text.Trim()) ? -1 : decimal.Parse(txtManualPrice.Text.Trim());

        public List<string> SourceFiles { get; set; }
        public string ContourFile { get; set; }

        private readonly PaperParametersService _paperParametersService;
        private readonly bool _editMode;

        public OrderItemForm(List<string> orderItemsNames, List<Film> films)
        {
            ContourFileStatus = false;
            _orderItemsNames = orderItemsNames;
            SourceFiles = new List<string>();

            InitializeComponent();
            _paperParametersService = new PaperParametersService();
            var cuttingTypeValuesWithDescription = new Dictionary<CuttingType, string>();
            cuttingTypeValuesWithDescription.Add(CuttingType.NotSelected, EnumUtility.GetEnumDescription(CuttingType.NotSelected));
            cuttingTypeValuesWithDescription.Add(CuttingType.Contour, EnumUtility.GetEnumDescription(CuttingType.Contour));
            cuttingTypeValuesWithDescription.Add(CuttingType.Through, EnumUtility.GetEnumDescription(CuttingType.Through));
            cuttingTypeValuesWithDescription.Add(CuttingType.None, EnumUtility.GetEnumDescription(CuttingType.None));
            cuttingTypeComboBox.DataSource = new BindingSource(cuttingTypeValuesWithDescription, null);
            cuttingTypeComboBox.DisplayMember = "Value";
            cuttingTypeComboBox.ValueMember = "Key";
            cuttingTypeComboBox.SelectedItem = cuttingTypeComboBox.Items[0];

            var filmsWithDefault = new List<Film>
            {
                new Film { Id = 0, Name = "Не выбрана" }
            };
            filmsWithDefault.AddRange(films);
            filmComboBox.DataSource = new BindingSource(filmsWithDefault, null);
            filmComboBox.DisplayMember = "Name";
            filmComboBox.ValueMember = "Id";

            var laminationValues = Enum.GetValues(typeof(Lamination)).Cast<Lamination>().ToList();
            var laminationValuesWithDescription = new Dictionary<Lamination, string>();
            foreach (var value in laminationValues)
            {
                laminationValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            laminationComboBox.DataSource = new BindingSource(laminationValuesWithDescription, null);
            laminationComboBox.DisplayMember = "Value";
            laminationComboBox.ValueMember = "Key";
            laminationComboBox.SelectedItem = laminationComboBox.Items[0];

            var paperTypeValues = Enum.GetValues(typeof(PaperType)).Cast<PaperType>().ToList();
            var paperTypeValuesWithDescription = new Dictionary<PaperType, string>();
            foreach (var value in paperTypeValues)
            {
                paperTypeValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            paperTypeComboBox.DataSource = new BindingSource(paperTypeValuesWithDescription, null);
            paperTypeComboBox.DisplayMember = "Value";
            paperTypeComboBox.ValueMember = "Key";
            paperTypeComboBox.SelectedItem = paperTypeComboBox.Items[0];
            txtDiscount.Text = "0";
        }

        public OrderItemForm(List<string> orderItemsNames, List<Film> films, OrderItem orderItem) : this(orderItemsNames, films)
        {
            ContourFileStatus = false;
            _editMode = true;
            btnLoadSources.Enabled = false;
            btnLoadContour.Enabled = false;
            txtDescription.Text = orderItem.Name;
            txtDescription.Enabled = false;
            txtCommentForDesigner.Text = orderItem.CommentForDesigner;
            txtCommentForProduction.Text = orderItem.CommentForProduction;
            CuttingLength = orderItem.CuttingLength;
            txtPaperCount.Text = orderItem.PaperCount.ToString();
            txtManualPrice.Text = orderItem.IsManualPricing ? (orderItem.ItemCost / orderItem.PaperCount).ToString(CultureInfo.InvariantCulture) : string.Empty;
            var cuttingTypeIndex = cuttingTypeComboBox.Items.IndexOf(new KeyValuePair<CuttingType, string>(orderItem.CuttingType,
                EnumUtility.GetEnumDescription(orderItem.CuttingType)));
            cuttingTypeComboBox.SelectedItem = cuttingTypeComboBox.Items[cuttingTypeIndex];
            filmComboBox.SelectedValue = orderItem.Film.Id;
            var laminationTypeIndex = laminationComboBox.Items.IndexOf(new KeyValuePair<Lamination, string>(orderItem.Lamination,
                EnumUtility.GetEnumDescription(orderItem.Lamination)));
            laminationComboBox.SelectedItem = laminationComboBox.Items[laminationTypeIndex];
            var paperType =
                _paperParametersService.GetPaperTypeByLengthAndWidth(orderItem.PaperLength, orderItem.PaperWidth);
            var paperTypeIndex =
                paperTypeComboBox.Items.IndexOf(
                    new KeyValuePair<PaperType, string>(paperType, EnumUtility.GetEnumDescription(paperType)));
            paperTypeComboBox.SelectedItem = paperTypeComboBox.Items[paperTypeIndex];
            if (((KeyValuePair<PaperType, string>)paperTypeComboBox.SelectedItem).Key == PaperType.Other)
            {
                txtPaperLength.Text = orderItem.PaperLength.ToString(CultureInfo.InvariantCulture);
                txtPaperWidth.Text = orderItem.PaperWidth.ToString(CultureInfo.InvariantCulture);
            }
            txtDiscount.Text = orderItem.Discount.ToString();
        }

        private void TxtPaperCount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaperCount.Text.Trim()) || !int.TryParse(txtPaperCount.Text.Trim(), out _) || int.Parse(txtPaperCount.Text.Trim()) <= 0)
            {
                errorPaperCount.SetError(txtPaperCount, "Неверное значение");
                e.Cancel = true;
            }
            else
            {
                errorPaperCount.SetError(txtPaperCount, "");
                e.Cancel = false;
            }
        }

        private void PaperTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paperTypeComboBox.SelectedIndex != 0)
            {
                txtPaperLength.Enabled = false;
                txtPaperWidth.Enabled = false;
            }
            else
            {
                txtPaperLength.Enabled = true;
                txtPaperWidth.Enabled = true;
            }
        }

        private void TxtPaperLength_Validating(object sender, CancelEventArgs e)
        {
            if (paperTypeComboBox.SelectedIndex == 0 && (string.IsNullOrEmpty(txtPaperLength.Text.Trim()) || !decimal.TryParse(txtPaperLength.Text.Trim(), out _) || decimal.Parse(txtPaperLength.Text.Trim()) <= 0))
            {
                errorPaperLength.SetError(txtPaperLength, "Неверное значение");
                e.Cancel = true;
            }
            else
            {
                errorPaperLength.SetError(txtPaperLength, "");
                e.Cancel = false;
            }
        }

        private void TxtPaperWidth_Validating(object sender, CancelEventArgs e)
        {
            if (paperTypeComboBox.SelectedIndex == 0 && (string.IsNullOrEmpty(txtPaperWidth.Text.Trim()) || !decimal.TryParse(txtPaperWidth.Text.Trim(), out _) || decimal.Parse(txtPaperWidth.Text.Trim()) <= 0))
            {
                errorPaperWidth.SetError(txtPaperWidth, "Неверное значение");
                e.Cancel = true;
            }
            else
            {
                errorPaperWidth.SetError(txtPaperWidth, "");
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

        private void FilmComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (filmComboBox.SelectedIndex == 0)
            {
                errorFilmType.SetError(filmComboBox, "Выберите пленку");
                e.Cancel = true;
            }
            else
            {
                errorFilmType.SetError(filmComboBox, "");
                e.Cancel = false;
            }
        }

        private void LaminationComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (laminationComboBox.SelectedIndex == 0)
            {
                errorLaminationType.SetError(laminationComboBox, "Выберите ламинацию");
                e.Cancel = true;
            }
            else
            {
                errorLaminationType.SetError(laminationComboBox, "");
                e.Cancel = false;
            }
        }

        private void TxtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (!_editMode)
            {
                if (string.IsNullOrEmpty(txtDescription.Text.Trim()) ||
                    _orderItemsNames.Contains(txtDescription.Text.Trim()))
                {
                    errorLayoutName.SetError(txtDescription, "Макет с таким именем уже есть в этом заказе");
                    e.Cancel = true;
                }
                else if (txtDescription.Text.Trim().IndexOfAny(SpecialChars) != -1)
                {
                    errorLayoutName.SetError(txtDescription, "В названии макета не должно быть спецсимволов.");
                    e.Cancel = true;
                }
                else
                {
                    errorLayoutName.SetError(txtDescription, "");
                    e.Cancel = false;
                }
            }
        }

        private void BtnLoadSources_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text.Trim()) && !_orderItemsNames.Contains(txtDescription.Text.Trim()))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.CheckFileExists = true;
                openFileDialog.AddExtension = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        SourceFiles.Add(fileName);
                    }
                    btnLoadContour.Enabled = false;
                }
            }
        }

        private void BtnLoadSources_Validating(object sender, CancelEventArgs e)
        {
            if (SourceFiles.Count == 0 && string.IsNullOrEmpty(ContourFile) && !_editMode && !ContourFileStatus)
            {
                errorLoadContour.SetError(btnLoadSources, "Загрузите исходники или контур");
                e.Cancel = true;
            }
            else
            {
                errorLoadContour.SetError(btnLoadSources, "");
                e.Cancel = false;
            }
        }

        private void CuttingTypeComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (cuttingTypeComboBox.SelectedIndex == 0)
            {
                errorCuttingType.SetError(cuttingTypeComboBox, "Выберите тип резки");
                e.Cancel = true;
            }
            else
            {
                errorCuttingType.SetError(cuttingTypeComboBox, "");
                e.Cancel = false;
            }
        }

        private void OrderItemForm_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtDiscount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text.Trim()) ||
                !int.TryParse(txtDiscount.Text.Trim(), out _) ||
                int.Parse(txtDiscount.Text.Trim()) < 0 ||
                int.Parse(txtDiscount.Text.Trim()) > 100)
            {
                errorDiscount.SetError(txtDiscount, "Неверное значение");
                e.Cancel = true;
            }
            else
            {
                errorDiscount.SetError(txtDiscount, "");
                e.Cancel = false;
            }
        }

        private void TxtManualPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtManualPrice.Text.Trim()) && !decimal.TryParse(txtManualPrice.Text.Trim(), out _))
            {
                errorManualPrice.SetError(txtDiscount, "Введите число");
                e.Cancel = true;
            }
            else
            {
                errorManualPrice.SetError(txtDiscount, "");
                e.Cancel = false;
            }
        }

        public bool ContourFileStatus = false;
        private void BtnLoadContour_Click(object sender, EventArgs e)
        {
            if (CuttingType != CuttingType.NotSelected)
            {
                OrderItemContourForm form = new OrderItemContourForm(0, EnumUtility.GetEnumDescription(CuttingType));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ContourFile = form.ContourFile;
                    CuttingLength = form.CuttingLength;
                    ContourFileStatus = form.CheckBoxFile.Checked;
                }
                btnLoadSources.Enabled = false;
            }
            else
            {
                MessageBox.Show("Выберите тип резки.");
            }
        }

        private void OrderItemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
