using System;
using Stickers.Core.Services;
using Stickers.Core.Utilities;
using Stickers.Data.Entities;
using Stickers.Data.Model.Constants;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Stickers.WinForms.UserForms
{
    public partial class UsersForm : Form
    {
        private List<User> _users;
        private UserService _userService;
        private readonly User _currentUser;
        public UsersForm(User user)
        {
            _currentUser = user;
            InitializeComponent();
            _userService = new UserService();
            _users = _userService.GetUsers();
            CreateUsersTable();
        }

        private void CreateUsersTable()
        {
            usersGrid.DataSource = null;
            usersGrid.AutoGenerateColumns = false;
            usersGrid.Columns.Clear();
            _users = _users.Where(x => x.Id != _currentUser.Id).OrderBy(x => x.Id).ToList();
            usersGrid.DataSource = _users;

            usersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            usersGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Имя пользователя"));
            usersGrid.Columns.Add(ColumnUtility.CreateTableColumn("UserRole", "Роль пользователя"));

            usersGrid.Columns[0].Visible = false;

            Type dgvType = usersGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(usersGrid, true, null);
        }

        private void UsersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                e.Value = EnumUtility.GetEnumDescription((UserRole)e.Value);
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для удаления.");
            }
            else
            {
                var id = (int)usersGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _userService.DeleteUser(id);
                    var userRemoved = _users.Find(x => x.Id == id);
                    _users.Remove(userRemoved);
                    CreateUsersTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnEditRole_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите пользователя для изменения.");
            }
            else
            {
                var id = (int)usersGrid.SelectedRows[0].Cells[0].Value;
                var userView = _users.Find(x => x.Id == id);
                var form = new EditUserRoleForm(userView.Name, EnumUtility.GetEnumDescription(userView.UserRole));
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var user = _userService.GetUserById(id);
                        user.UserRole = form.UserRole;
                        var newUser = _userService.UpdateUser(user);
                        _users.Remove(userView);
                        _users.Add(newUser);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    CreateUsersTable();
                }
            }
        }
    }
}
