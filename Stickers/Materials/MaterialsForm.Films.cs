using System;
using Stickers.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Stickers.Core.Utilities;
using Stickers.WinForms.CostForms;

namespace Stickers.WinForms.Materials
{
    public partial class MaterialsForm
    {
        private List<Film> _films;

        private void CreateFilmsTable()
        {
            filmsGrid.DataSource = null;
            filmsGrid.AutoGenerateColumns = false;
            filmsGrid.Columns.Clear();
            _films = _films.OrderBy(x => x.Id).ToList();
            filmsGrid.DataSource = _films;

            filmsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            filmsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Пленка"));
            filmsGrid.Columns.Add(ColumnUtility.CreateMoneyTableColumn("Price", "Цена"));

            filmsGrid.Columns[0].Visible = false;

            Type dgvType = filmsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(filmsGrid, true, null);
        }

        private void BtnAddFilm_Click(object sender, EventArgs e)
        {
            var form = new FilmForm(_filmService.GetFilms().Select(x=>x.Name).ToList());
            if (form.ShowDialog() == DialogResult.OK)
            {
                var film = new Film
                {
                    Name = form.FilmName,
                    Price = form.Price
                };

                try
                {
                    var newFilm = _filmService.AddFilm(film);
                    _films.Add(newFilm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                CreateFilmsTable();
            }
        }

        private void BtnEditFilm_Click(object sender, EventArgs e)
        {
            if (filmsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите цену для изменения.");
            }
            else
            {
                var id = (int)filmsGrid.SelectedRows[0].Cells[0].Value;
                var film = _films.Find(x => x.Id == id);
                var form = new FilmForm(_filmService.GetFilms().Select(x => x.Name).ToList(), film);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        film.Name = form.FilmName;
                        film.Price = form.Price;
                        var newFilm = _filmService.UpdateFilm(film);
                        _films.Remove(film);
                        _films.Add(newFilm);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    CreateFilmsTable();
                }
            }
        }

        private void BtnDeleteFilm_Click(object sender, EventArgs e)
        {
            if (filmsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пленку для удаления.");
            }
            else
            {
                var id = (int)filmsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _filmService.DeleteFilm(id);
                    var filmRemoved = _films.Find(x => x.Id == id);
                    _films.Remove(filmRemoved);
                    CreateFilmsTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
