using Stickers.Core.Services;
using System;
using System.Windows.Forms;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;

namespace Stickers.WinForms.Materials
{
    public partial class MaterialsForm : Form
    {
        private readonly RollService _rollService;
        private readonly FilmService _filmService;
        private readonly WorkReportService _workReportService;
        private readonly User _currentUser;
        public MaterialsForm(User user)
        {
            _currentUser = user;
            _rollService = new RollService();
            _filmService = new FilmService();
            _workReportService = new WorkReportService();
            InitializeComponent();
            ConfigurePermissions();
            _rolls = _rollService.GetRolls();
            _filteredRolls = _rolls;
            InitializeRollFilters();
            CreateRollsTable();
        }

        private void ConfigurePermissions()
        {
            if (_currentUser.UserRole == UserRole.Worker)
            {
                tabControlMaterials.TabPages.RemoveAt(1);
                btnDeleteRoll.Visible = false;
            }
        }

        private void TabControlMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMaterials.SelectedTab.Name == "rollsTab")
            {
                _rolls = _rollService.GetRolls();
                _filteredRolls = _rolls;
                InitializeRollFilters();
                CreateRollsTable();
            }
            else if (tabControlMaterials.SelectedTab.Name == "filmsTab")
            {
                _films = _filmService.GetFilms();
                CreateFilmsTable();
            }
        }
    }
}