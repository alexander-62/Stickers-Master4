using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.WinForms.ProductionForms
{
    public partial class CheckWorkForm : Form
    {
        private readonly List<OrderItem> _orderItems;
        private readonly WorkType _workType;
        public Roll Roll => (Roll)rollComboBox.SelectedItem;
        public decimal UsedMeters => decimal.Parse(txtUsedMeters.Text.Trim());

        public List<KeyValuePair<int, int>> DoneLists = new List<KeyValuePair<int, int>>();

        public CheckWorkForm(List<OrderItem> orderItems, List<Roll> rolls, WorkType workType)
        {
            _workType = workType;
            InitializeComponent();
            _orderItems = orderItems;
            checkPrintingGrid.DataSource = null;
            checkPrintingGrid.AutoGenerateColumns = false;
            checkPrintingGrid.Columns.Clear();
            checkPrintingGrid.DataSource = orderItems;

            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn("OrderId", "Номер заказа"));
            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Название макета"));
            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn("PaperCount", "Количество листов"));
            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn(GetPropertyName(), GetColumnHeader()));
            checkPrintingGrid.Columns.Add(ColumnUtility.CreateTableColumn("DoneCount", "Сделано"));

            checkPrintingGrid.Columns[0].Visible = false;
            checkPrintingGrid.Columns[1].ReadOnly = true;
            checkPrintingGrid.Columns[2].ReadOnly = true;
            checkPrintingGrid.Columns[3].ReadOnly = true;
            checkPrintingGrid.Columns[4].ReadOnly = true;
            checkPrintingGrid.Columns[5].ReadOnly = false;

            Type dgvType = checkPrintingGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(checkPrintingGrid, true, null);

            if (_workType == WorkType.Printing || _workType == WorkType.Lamination)
            {
                InitializeRollCombobox(rolls);
            }
            else
            {
                rollComboBox.Enabled = false;
                txtUsedMeters.Enabled = false;
            }
        }

        private string GetPropertyName()
        {
            return _workType == WorkType.Printing ? "PrintedCount" :
                _workType == WorkType.Lamination ? "LaminatedCount" :
                _workType == WorkType.Plottering ? "PlotteredCount" :
                "CutCount";
        }

        private string GetColumnHeader()
        {
            return _workType == WorkType.Printing ? "Напечатано" :
                _workType == WorkType.Lamination ? "Заламинировано" :
                _workType == WorkType.Plottering ? "Порезано на плоттере" :
                "Порезано на листы";
        }

        private void InitializeRollCombobox(List<Roll> rolls)
        {
            rollComboBox.DataSource = new BindingSource(rolls, null);
            rollComboBox.DisplayMember = "Id";
            rollComboBox.SelectedItem = null;
            rollComboBox.SelectedText = "Не выбран";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                foreach (DataGridViewRow row in checkPrintingGrid.Rows)
                {
                    DoneLists.Add(new KeyValuePair<int, int>(int.Parse(row.Cells[0].Value.ToString()), int.Parse(row.Cells[5].Value.ToString())));
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void TxtUsedMeters_Validating(object sender, CancelEventArgs e)
        {
            if (_workType == WorkType.Printing || _workType == WorkType.Lamination)
            {
                if (string.IsNullOrEmpty(txtUsedMeters.Text.Trim()) || !decimal.TryParse(txtUsedMeters.Text.Trim(), out _))
                {
                    errorMeters.SetError(txtUsedMeters, "Введите число метров");
                    e.Cancel = true;
                }
                else
                {
                    var roll = (Roll)rollComboBox.SelectedItem;
                    if (roll != null)
                    {
                        var usedArea = decimal.Parse(txtUsedMeters.Text.Trim()) * roll.Width;
                        var neededArea = 0m;
                        foreach (DataGridViewRow row in checkPrintingGrid.Rows)
                        {
                            if (!string.IsNullOrEmpty((string)row.Cells[5].Value) &&
                                int.TryParse((string)row.Cells[5].Value, out _))
                            {
                                var id = (int)row.Cells[0].Value;
                                var orderItem = _orderItems.Find(x => x.Id == id);
                                neededArea += int.Parse((string)row.Cells[5].Value) * orderItem.PaperLength / 1000 *
                                    orderItem.PaperWidth / 1000;
                            }
                        }

                        if (usedArea < neededArea)
                        {
                            errorMeters.SetError(txtUsedMeters, "Вы не могли столько напечатать, потратив так мало пленки");
                        }
                    }
                    else
                    {
                        errorMeters.SetError(txtUsedMeters, "");
                        e.Cancel = false;
                    }
                }
            }
        }

        private void CheckPrintingGrid_Validating(object sender, CancelEventArgs e)
        {
            foreach (DataGridViewRow row in checkPrintingGrid.Rows)
            {
                int id = (int)row.Cells[0].Value;
                var orderItem = _orderItems.Find(x => x.Id == id);
                if (row.Cells[5].Value == null || !int.TryParse(row.Cells[5].Value.ToString(), out _) || int.Parse(row.Cells[5].Value.ToString()) <= 0)
                {
                    errorPrintedPapers.SetError(checkPrintingGrid, "Заполните все ячейки правильно");
                    e.Cancel = true;
                }
                else
                {
                    var inputValue = int.Parse(row.Cells[5].Value.ToString());
                    if (_workType == WorkType.Printing)
                    {
                        if (inputValue > orderItem.PaperCount - orderItem.PrintedCount)
                        {
                            errorPrintedPapers.SetError(checkPrintingGrid, "Слишком большое число листов");
                            e.Cancel = true;
                        }
                    }
                    else if (_workType == WorkType.Lamination)
                    {
                        if (orderItem.LaminatedCount + inputValue > orderItem.PrintedCount)
                        {
                            errorPrintedPapers.SetError(checkPrintingGrid, "Столько листов еще не напечатано");
                            e.Cancel = true;
                        }
                    }
                    else if (_workType == WorkType.Plottering)
                    {
                        if (orderItem.PlotteredCount + inputValue > orderItem.LaminatedCount ||
                            orderItem.PlotteredCount + inputValue > orderItem.PrintedCount)
                        {
                            errorPrintedPapers.SetError(checkPrintingGrid, "Столько листов еще не готово к плоттерной резке");
                            e.Cancel = true;
                        }
                    }
                    else if (_workType == WorkType.Cutting)
                    {
                        if (orderItem.CutCount + inputValue > orderItem.PlotteredCount ||
                            orderItem.CutCount + inputValue > orderItem.LaminatedCount ||
                            orderItem.CutCount + inputValue > orderItem.PrintedCount)
                        {
                            errorPrintedPapers.SetError(checkPrintingGrid, "Столько листов еще не готово к нарезке");
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        errorPrintedPapers.SetError(checkPrintingGrid, "");
                        e.Cancel = false;
                    }
                }
            }
        }

        private void RollComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (_workType == WorkType.Printing || _workType == WorkType.Lamination)
            {
                if (rollComboBox.SelectedItem == null)
                {
                    errorRoll.SetError(rollComboBox, "Выберите рулон");
                    e.Cancel = true;
                }
                else
                {
                    errorRoll.SetError(rollComboBox, "");
                    e.Cancel = false;
                }
            }
        }

        private void CheckWorkForm_KeyDown(object sender, KeyEventArgs e)
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
