using Stickers.Core.Services;
using Stickers.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Stickers.Data.Model.Constants;

namespace Stickers.WinForms.UserForms
{
    public partial class LoginForm : Form
    {
        public User User { get; set; }

        private readonly UserService _userService;

        private List<User> _users;

        public LoginForm()
        {
            _userService = new UserService();
            _users = _userService.GetUsers();
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (_users.Exists(x => x.Name == txtUserName.Text.Trim()))
                {
                    MessageBox.Show(txtUserName, "Пользователь с таким именем уже существует");
                }
                else
                {
                    User = _userService.RegisterUser(new User
                    {
                        Name = txtUserName.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        UserRole = UserRole.Guest
                    });
                    _users = _userService.GetUsers();
                    MessageBox.Show("Пользователь зарегистрирован.");
                }
            }
        }

        private void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                errorUserName.SetError(txtUserName, "Введите имя пользователя");
                e.Cancel = true;
            }
            else
            {
                errorUserName.SetError(txtUserName, "");
                e.Cancel = false;
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                errorPassword.SetError(txtPassword, "Введите пароль");
                e.Cancel = true;
            }
            else
            {
                errorPassword.SetError(txtPassword, "");
                e.Cancel = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User = _users.FirstOrDefault(
                x => x.Name == txtUserName.Text.Trim() && x.Password == txtPassword.Text.Trim());
            if (User != null)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль.");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                User = _users.FirstOrDefault(
                    x => x.Name == txtUserName.Text.Trim() && x.Password == txtPassword.Text.Trim());
                if (User != null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неправильное имя пользователя или пароль.");
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
