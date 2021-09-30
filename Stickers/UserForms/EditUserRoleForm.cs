using Stickers.Core.Utilities;
using Stickers.Data.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stickers.WinForms.UserForms
{
    public partial class EditUserRoleForm : Form
    {
        public UserRole UserRole => ((KeyValuePair<UserRole, string>)userRoleComboBox.SelectedItem).Key;

        public EditUserRoleForm(string userName, string currentRole)
        {
            InitializeComponent();
            txtUserName.Text = userName;
            InitializeUserRoleCombobox(currentRole);
        }

        private void InitializeUserRoleCombobox(string currentRole)
        {
            var userRoleValues = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().ToList();
            var userRoleValuesWithDescription = new Dictionary<UserRole, string>();
            foreach (var value in userRoleValues)
            {
                userRoleValuesWithDescription.Add(value, EnumUtility.GetEnumDescription(value));
            }
            userRoleComboBox.DataSource = new BindingSource(userRoleValuesWithDescription, null);
            userRoleComboBox.DisplayMember = "Value";
            userRoleComboBox.ValueMember = "Key";

            var selected = userRoleValuesWithDescription.First(x => x.Value == currentRole);
            userRoleComboBox.SelectedItem = selected;
        }

        private void EditUserRoleForm_KeyDown(object sender, KeyEventArgs e)
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
