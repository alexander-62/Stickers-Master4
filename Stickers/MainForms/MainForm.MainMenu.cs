using System;
using System.Windows.Forms;
using Stickers.Data.Model.Constants;
using Stickers.WinForms.ArchiveForms;
using Stickers.WinForms.Materials;
using Stickers.WinForms.UserForms;
using Stickers.WinForms.WorkStatistics;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private void InitializeMenu()
        {
            var materialsMenuItem = new ToolStripMenuItem("Материалы");
            materialsMenuItem.Click += MaterialsMenuItemOnClick;
            var usersMenuItem = new ToolStripMenuItem("Пользователи");
            usersMenuItem.Click += UsersMenuItemOnClick;
            var workReportsMenuItem = new ToolStripMenuItem("Отчеты о работе");
            workReportsMenuItem.Click += WorkReportsMenuItemOnClick;
            var archiveMenuItem = new ToolStripMenuItem("Архив");
            archiveMenuItem.Click += ArchiveMenuItemOnClick;
            var exitMenuItem = new ToolStripMenuItem("Выход");
            exitMenuItem.Click += ExitMenuItemOnClick;
            var mainMenuItem = new ToolStripMenuItem("Главное меню");

            if (_currentUser.UserRole == UserRole.Administrator || _currentUser.UserRole == UserRole.Worker)
            {
                mainMenuItem.DropDownItems.Add(materialsMenuItem);
            }

            mainMenuItem.DropDownItems.Add(workReportsMenuItem);

            if (_currentUser.UserRole == UserRole.Administrator)
            {
                mainMenuItem.DropDownItems.Add(usersMenuItem);
            }

            if (_currentUser.UserRole == UserRole.Administrator || _currentUser.UserRole == UserRole.Manager)
            {
                mainMenuItem.DropDownItems.Add(archiveMenuItem);
            }
            
            mainMenuItem.DropDownItems.Add(exitMenuItem);
            mainMenuStrip.Items.Add(mainMenuItem);
        }

        private void UsersMenuItemOnClick(object sender, EventArgs e)
        {
            new UsersForm(_currentUser).Show();
        }

        private void MaterialsMenuItemOnClick(object sender, EventArgs e)
        {
            new MaterialsForm(_currentUser).Show();
        }

        private void WorkReportsMenuItemOnClick(object sender, EventArgs e)
        {
            new WorkStatisticsForm(_currentUser).Show();
        }

        private void ArchiveMenuItemOnClick(object sender, EventArgs e)
        {
            new ArchiveForm(_currentUser).Show();
        }

        private void ExitMenuItemOnClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
