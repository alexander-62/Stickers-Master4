using Stickers.Core.Services;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using System;
using System.Windows.Forms;

namespace Stickers.WinForms.WorkStatistics
{
    public partial class WorkStatisticsForm : Form
    {
        private readonly WorkReportService _workReportService;
        private readonly UserService _userService;
        private readonly User _currentUser;
        private readonly OrdersService _ordersService;
        public WorkStatisticsForm(User user)
        {
            _currentUser = user;
            _workReportService = new WorkReportService();
            _userService = new UserService();
            _ordersService = new OrdersService();
            InitializeComponent();
            ConfigurePermissions();
            _reports = _workReportService.GetReportViewsForUser(_currentUser);
            _filteredReports = _reports;
            InitializeReportFilters();
            CreateReportsTable();
        }

        private void ConfigurePermissions()
        {
            if (_currentUser.UserRole != UserRole.Administrator)
            {
                tabControlWorkStatistics.TabPages.RemoveAt(1);
            }
        }

        private void TabControlWorkStatistics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlWorkStatistics.SelectedTab.Name == "workReportsTab")
            {
                _reports = _workReportService.GetReportViewsForUser(_currentUser);
                _filteredReports = _reports;
                InitializeReportFilters();
                CreateReportsTable();
            }
            else if (tabControlWorkStatistics.SelectedTab.Name == "salaryTab")
            {
            }
        }

        private void WorkStatisticsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
