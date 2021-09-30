using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using Stickers.WinForms.CostForms;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private List<Cost> _costs;

        private void CreateCostsTable()
        {
            costsGrid.DataSource = null;
            costsGrid.AutoGenerateColumns = false;
            costsGrid.Columns.Clear();
            _costs = _costs.OrderBy(x => x.Id).ToList();
            costsGrid.DataSource = _costs;

            costsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            costsGrid.Columns.Add(ColumnUtility.CreateTableColumn("CostType", "Тип затрат"));
            costsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("Price", "Цена"));

            costsGrid.Columns[0].Visible = false;

            Type dgvType = costsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(costsGrid, true, null);
        }

        private void СostsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = EnumUtility.GetEnumDescription((CostType)e.Value);
            }
        }

        private void BtnAddCost_Click(object sender, EventArgs e)
        {
            var form = new CostForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var cost = new Cost
                {
                    CostType = form.CostType,
                    Price = form.Price,
                };

                try
                {
                    var newCost = _costsService.AddCost(cost);
                    _costs.Add(newCost);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                CreateCostsTable();
            }
        }

        private void BtnEditCost_Click(object sender, EventArgs e)
        {
            if (costsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите цену для изменения.");
            }
            else
            {
                var id = (int)costsGrid.SelectedRows[0].Cells[0].Value;
                var costView = _costs.Find(x => x.Id == id);
                var form = new CostForm(EnumUtility.GetEnumDescription(costView.CostType), costView.Price);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var cost = _costsService.GetCostById(id);
                        cost.Price = form.Price;
                        var newCost = _costsService.UpdateCost(cost);
                        _costs.Remove(costView);
                        _costs.Add(newCost);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    CreateCostsTable();
                }
            }
        }

        private void BtnDeleteCost_Click(object sender, EventArgs e)
        {
            if (costsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите цену для удаления.");
            }
            else
            {
                var id = (int)costsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _costsService.DeleteCost(id);
                    var costRemoved = _costs.Find(x => x.Id == id);
                    _costs.Remove(costRemoved);
                    CreateCostsTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
