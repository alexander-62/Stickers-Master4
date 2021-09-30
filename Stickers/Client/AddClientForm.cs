using Stickers.Data.Model.Constants;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;
using Stickers.Data.Entities;
using System.Collections.Generic;
using Stickers.Core.Services;

namespace Stickers.WinForms.Client
{
    public partial class AddClientForm : Form
    {
        private readonly BusinessClientsService _clientsService;
        public string VkId => txtVkId.Text.Trim();
        public string ClientName => txtClientName.Text.Trim();
        public string Address => txtAddress.Text.Trim();
        public string PostIndex => txtPostIndex.Text.Trim();
        public string ReceiverCredentials => txtReceiverCredentials.Text.Trim();
        public string Comment => txtComment.Text.Trim();
        public string VkLink => txtVkLink.Text.Trim();
        public string VkGroupName => txtVkGroupName.Text.Trim();
        private bool ClientAdd = true;

        public AddClientForm()
        {
            InitializeComponent(); 
            _clientsService = new BusinessClientsService();
            ClientAdd = true;
        }

        public AddClientForm(BusinessClient client)
        {
            InitializeComponent(); 
            _clientsService = new BusinessClientsService();
            txtClientName.Text = client.Name;
            txtAddress.Text = client.Address;
            txtPostIndex.Text = client.PostIndex;
            txtReceiverCredentials.Text = client.ReceiverCredentials;
            txtVkId.Text = client.VkId;
            txtComment.Text = client.Comment;
            txtVkLink.Text = client.VkLink;
            txtVkGroupName.Text = client.VkGroupName;
            ClientAdd = false; 
        }

        private void TxtClientName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientName.Text.Trim()))
            {
                errorClientName.SetError(txtClientName, "Введите имя/название заказчика");
                e.Cancel = true;
            }
            else
            {
                errorClientName.SetError(txtClientName, "");
                e.Cancel = false;
            }
        }

        private void TxtVkId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVkId.Text.Trim()))
            {
                errorVkId.SetError(txtVkId, "Поле не может быть пустым");
                e.Cancel = true;
                return;
            }
            else
            {
                errorVkId.SetError(txtVkId, "");
                e.Cancel = false;
            }

            if (!string.IsNullOrEmpty(txtVkId.Text.Trim()) && txtVkId.Text.Trim().Length > DatabaseDefaults.FieldMaxLength)
            {
                errorVkId.SetError(txtVkId, "Слишком много символов");
                e.Cancel = true;
            }
            else
            {
                errorVkId.SetError(txtVkId, "");
                e.Cancel = false;
            }
        }

        private void TxtAddress_Validating(object sender, CancelEventArgs e)
        {
          
            if (!string.IsNullOrEmpty(txtAddress.Text.Trim()) && txtAddress.Text.Trim().Length > DatabaseDefaults.FieldMaxLength)
            {
                errorAddress.SetError(txtAddress, "Слишком много символов");
                e.Cancel = true;
            }
            else
            {
                errorAddress.SetError(txtAddress, "");
                e.Cancel = false;
            }
        }

        private void TxtPostIndex_Validating(object sender, CancelEventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtPostIndex.Text.Trim()) && txtPostIndex.Text.Trim().Length != 6)
            {
                errorPostIndex.SetError(txtPostIndex, "Должно быть 6 цифр");
                e.Cancel = true;
            }
            else if (!string.IsNullOrEmpty(txtPostIndex.Text.Trim()) && txtPostIndex.Text.Trim().Any(x => !char.IsDigit(x)))
            {
                errorPostIndex.SetError(txtPostIndex, "Индекс должен содержать только цифры");
                e.Cancel = true;
            }
            else
            {
                errorPostIndex.SetError(txtPostIndex, "");
                e.Cancel = false;
            }
        }

        private void TxtReceiverCredentials_Validating(object sender, CancelEventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txtReceiverCredentials.Text.Trim()) && txtReceiverCredentials.Text.Trim().Length > DatabaseDefaults.FieldMaxLength)
            {
                errorReceiverCredentials.SetError(txtAddress, "Слишком много символов");
                e.Cancel = true;
            }
            else
            {
                errorReceiverCredentials.SetError(txtAddress, "");
                e.Cancel = false;
            }
        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            if (ValidateChildren())
            {
                var clients = _clientsService.GetClients();
                var res1 = clients.Where(c => c.Name.ToLower() == txtClientName.Text.Trim().ToLower()).ToList();
                var res2 = clients.Where(c => c.VkId.ToLower() == txtVkId.Text.Trim().ToLower()).ToList();

                //if (!ClientAdd)
                //{
                //    res1 = res1.Where(c => c.Name.ToLower() != txtClientName.Text.Trim().ToLower()).ToList();
                //    res2 = res2.Where(c => c.Name.ToLower() != txtClientName.Text.Trim().ToLower()).ToList();
                //}

                if (res1.Count > 1 && !ClientAdd || res1.Count > 0 && ClientAdd)
                {
                    MessageBox.Show("Клиент с таким именем уже есть в программе", "", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }

                if (res2.Count > 1 && !ClientAdd || res2.Count > 0 && ClientAdd)
                {
                    var user = res2.Where(c => c.Name.ToLower() != txtClientName.Text.Trim().ToLower()).FirstOrDefault();
                    MessageBox.Show("Такой VK id уже указан у клиента " + user.Name, "", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }

                DialogResult = DialogResult.OK;
            }
        }

        private void AddClientForm_KeyDown(object sender, KeyEventArgs e)
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

        private void txtComment_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtVkLink_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVkLink.Text))
            {
                errorVkLink.SetError(txtVkLink, "Поле не может быть пустым");
                e.Cancel = true;
            }
            else
            {

                errorVkLink.SetError(txtVkLink, "");
                e.Cancel = false;
            }
        }

        private void txtVkGroupName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtVkGroupName.Text))
            {
                errorVkGroupName.SetError(txtVkGroupName, "Поле не может быть пустым");
                e.Cancel = true;
            }
            else
            {

                errorVkGroupName.SetError(txtVkGroupName, "");
                e.Cancel = false;
            }
        }
    }
}
