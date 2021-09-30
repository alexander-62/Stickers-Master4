using Stickers.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Stickers.WinForms.Materials
{
    public partial class MaterialsForm
    {
        private List<Roll> _rolls;
        private List<Roll> _filteredRolls;

        private void CreateRollsTable()
        {
            rollsGrid.DataSource = null;
            rollsGrid.AutoGenerateColumns = false;
            rollsGrid.Columns.Clear();
            _rolls = _rolls.OrderBy(x => x.Id).ToList();
            rollsGrid.DataSource = _filteredRolls;

            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Номер рулона"));
            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Film", "Вид пленки"));
            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Manufacturer", "Производитель"));
            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Width", "Ширина рулона, м.п."));
            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Length", "Остаток, м.п."));
            rollsGrid.Columns.Add(ColumnUtility.CreateTableColumn("FilmThickness", "Толщина пленки, мкм"));
            rollsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("PurchasePrice", "Цена покупки, руб/м.кв."));
            rollsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("SellingPrice", "Цена продажиб руб/м.кв."));

            Type dgvType = rollsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(rollsGrid, true, null);
        }

        private void InitializeRollFilters()
        {
            InitializeFilmCombobox();
            InitializeManufacturerCombobox();
            InitializeWidthCombobox();
            InitializeLengthCombobox();
            InitializeThicknessCombobox();
        }

        private void InitializeFilmCombobox()
        {
            var filmsWithDefault = new List<Film>
            {
                new Film { Id = 0, Name = "Любая" }
            };
            filmsWithDefault.AddRange(_filmService.GetFilms());
            filmFilterCombobox.DataSource = new BindingSource(filmsWithDefault, null);
            filmFilterCombobox.DisplayMember = "Name";
        }

        private void InitializeManufacturerCombobox()
        {
            var tmp = new List<string> { "Любой" };
            tmp.AddRange(_filteredRolls.Select(c => c.Manufacturer).Distinct().ToList());
            FilterManufacturer.DataSource = new BindingSource(tmp, null);
        }

        private void InitializeWidthCombobox()
        {
            var tmp = new List<string> { "Любая" };
            tmp.AddRange(_filteredRolls.Select(c => c.Width.ToString()).Distinct().ToList());
            FilterWidth.DataSource = new BindingSource(tmp, null);
        }

        private void InitializeLengthCombobox()
        {
            var tmp = new List<string> { "Любой" };
            tmp.AddRange(_filteredRolls.Select(c => c.Length.ToString()).Distinct().ToList());
            FilterLength.DataSource = new BindingSource(tmp, null);
        }

        private void InitializeThicknessCombobox()
        {
            var tmp = new List<string> { "Любая" };
            tmp.AddRange(_filteredRolls.Select(c => c.FilmThickness.ToString()).Distinct().ToList());
            FilterFilmThickness.DataSource = new BindingSource(tmp, null);
        }

        private void FilterRollsEvent(object sender, EventArgs e)
        {
            FilterRolls();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void PriceCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ','))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == ',' && txtDecimal.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void FilterRolls()
        {
            if (filmFilterCombobox.SelectedItem != null)
            {
                var film = (Film)filmFilterCombobox.SelectedItem;

                if (film.Id == 0)
                {
                    _filteredRolls = _rolls;
                }
                else
                {
                    _filteredRolls = _rolls.Where(x => x.FilmId == film.Id).ToList();
                }

                if (hideEmptyRollsCheckbox.Checked)
                {
                    _filteredRolls = _rolls.Where(x => x.Length > 0).ToList();
                }

                if (film.Name != "Любая")
                {
                    _filteredRolls = _filteredRolls.Where(x => x.Film.Name == film.Name).ToList();
                }
            }

            if (textBoxId.Text.Trim() != "")
            {
                _filteredRolls = _filteredRolls.Where(x => x.Id == Convert.ToInt32(textBoxId.Text.Trim())).ToList();
            }

            ////////////////////////////////////////////////////////////////////////////
            if (FilterPriceBuy1.Text.Trim() != "")
            {
                _filteredRolls = _filteredRolls.Where(x => x.PurchasePrice >= Convert.ToDecimal(FilterPriceBuy1.Text.Trim())).ToList();
            }
            if (FilterPriceBuy2.Text.Trim() != "")
            {
                _filteredRolls = _filteredRolls.Where(x => x.PurchasePrice <= Convert.ToDecimal(FilterPriceBuy2.Text.Trim())).ToList();
            }

            if (FilterPriceSale1.Text.Trim() != "")
            {
                _filteredRolls = _filteredRolls.Where(x => x.SellingPrice >= Convert.ToDecimal(FilterPriceSale1.Text.Trim())).ToList();
            }
            if (FilterPriceSale2.Text.Trim() != "")
            {
                _filteredRolls = _filteredRolls.Where(x => x.SellingPrice <= Convert.ToDecimal(FilterPriceSale2.Text.Trim())).ToList();
            }
            ////////////////////////////////////////////////////////////////////////////

            if (FilterManufacturer.SelectedItem != null)
            {
                if (FilterManufacturer.Text != "Любой")
                {
                    _filteredRolls = _filteredRolls.Where(x => x.Manufacturer == FilterManufacturer.Text).ToList();
                }
            }

            if (FilterWidth.SelectedItem != null)
            {
                if (FilterWidth.Text != "Любая")
                {
                    _filteredRolls = _filteredRolls.Where(x => x.Width == Convert.ToDecimal(FilterWidth.Text)).ToList();
                }
            }

            if (FilterLength.SelectedItem != null)
            {
                if (FilterLength.Text != "Любой")
                {
                    _filteredRolls = _filteredRolls.Where(x => x.Length == Convert.ToDecimal(FilterLength.Text)).ToList();
                }
            }

            if (FilterFilmThickness.SelectedItem != null)
            {
                if (FilterFilmThickness.Text != "Любая")
                {
                    _filteredRolls = _filteredRolls.Where(x => x.FilmThickness == Convert.ToInt32(FilterFilmThickness.Text)).ToList();
                }
            }

            _filteredRolls = _filteredRolls.OrderBy(x => x.Id).ToList();
            CreateRollsTable();
        }

        private void RollsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var film = (Film)e.Value;
                if (film != null)
                {
                    e.Value = film.Name;
                }
            }
        }

        private void BtnAddRole_Click(object sender, EventArgs e)
        {
            var form = new RollForm(_filmService.GetFilms());
            if (form.ShowDialog() == DialogResult.OK)
            {
                var roll = new Roll
                {
                    FilmId = form.Film.Id,
                    Manufacturer = form.Manufacturer,
                    FilmThickness = form.Thickness,
                    Width = form.RollWidth,
                    Length = form.Length,
                    PurchasePrice = form.PurchasePrice,
                    SellingPrice = form.SellingPrice
                };

                try
                {
                    var newRoll = _rollService.AddRoll(roll);
                    newRoll.Film = form.Film;
                    _rolls.Add(newRoll);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                FilterRolls();
            }
        }

        private void BtnDeleteRoll_Click(object sender, EventArgs e)
        {
            if (rollsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рулон для удаления.");
            }
            else
            {
                var id = (int)rollsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _rollService.DeleteRoll(id);
                    var rollRemoved = _rolls.Find(x => x.Id == id);
                    _rolls.Remove(rollRemoved);
                    FilterRolls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnExpendFilm_Click(object sender, EventArgs e)
        {
            if (rollsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите рулон для изменения.");
            }
            else
            {
                var id = (int)rollsGrid.SelectedRows[0].Cells[0].Value;
                var roll = _rollService.GetRollById(id);
                var form = new RollExpendForm(roll.Length);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var report = new WorkReport
                        {
                            OrderId = null,
                            PaperCount = 0,
                            PaperParameters = $"{form.Length} метров списано.",
                            User = _currentUser,
                            WorkType = form.WorkType,
                            Date = DateTime.Now
                        };
                        _workReportService.AddReport(report);
                        roll.Length -= form.Length;
                        var oldRoll = _rolls.Find(x => x.Id == id);
                        var newRoll = _rollService.UpdateRoll(roll);
                        _rolls.Remove(oldRoll);
                        _rolls.Add(newRoll);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    FilterRolls();
                }
            }
        }
    }
}