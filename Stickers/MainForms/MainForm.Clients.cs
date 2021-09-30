using Stickers.Data.Entities;
using Stickers.WinForms.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Stickers.WinForms.MainForms
{
    public partial class MainForm
    {
        private List<BusinessClient> _businessClients;
        private List<BusinessClient> _filteredClients;
        private void CreateBusinessClientsTable(bool flag = false)
        {
            clientsGrid.DataSource = null;
            clientsGrid.AutoGenerateColumns = false;
            clientsGrid.Columns.Clear();

            if (flag)
            {
                flag = false;
                var orders = _ordersService.GetAllOrderViews();
                foreach (var ord in _filteredClients)
                {
                    var tmp = orders.Where(c => c.ClientName == ord.Name).ToList();
                    if (tmp.Count > 0)
                    {
                        ord.N1 = tmp.Min(c => c.OrderDate).ToString("dd/MM/yyyy");
                        ord.N2 = tmp.Max(c => c.OrderDate).ToString("dd/MM/yyyy");
                        ord.N3 = tmp.Count.ToString();
                        ord.N4 = tmp.Sum(c => c.StickersCost).ToString();
                    }
                }
            }

            clientsGrid.DataSource = _filteredClients.OrderBy(x => x.Name, StringComparer.OrdinalIgnoreCase).ToList();

            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Id", "Id"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Name", "Имя клиента"));
            clientsGrid.Columns.Add(ColumnUtility.CreateButtonColumn("VkId", "Открыть диалог"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("VkGroupName", "Название группы ВК"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("VkLink", "Ссылка на группу ВК"));

            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Address", "Адрес"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("PostIndex", "Индекс"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("ReceiverCredentials", "ФИО Получателя"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("Comment", "Комментарий к клиенту"));

            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("N1", "Дата первого заказа"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("N2", "Дата последнего заказа"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("N3", "Количество заказов"));
            clientsGrid.Columns.Add(ColumnUtility.CreateTableColumn("N4", "Общая сумма заказов "));

            clientsGrid.Columns[0].Visible = false;
            clientsGrid.Columns[2].Visible = false;

            Type dgvType = clientsGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(clientsGrid, true, null);
        }

        private void FilterClientsEvent(object sender, EventArgs e)
        {
            FilterClients();
        }

        private void FilterClients()
        {
            _filteredClients = _businessClients;
            if (!string.IsNullOrEmpty(txtClientFilterByName.Text))
            {
                _filteredClients = _filteredClients
                .Where(x => !string.IsNullOrEmpty(x.Name) && x.Name.Contains(txtClientFilterByName.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                .ToList();
            }
            if (!string.IsNullOrEmpty(textBoxGrVk.Text))
            {
                _filteredClients = _filteredClients
                   .Where(x => !string.IsNullOrEmpty(x.VkGroupName) && x.VkGroupName.Contains(textBoxGrVk.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
                   .ToList();
            }
            if (!string.IsNullOrEmpty(textBoxVkGrLnk.Text))
            {
                _filteredClients = _filteredClients
               .Where(x => !string.IsNullOrEmpty(x.VkLink) && x.VkLink.Contains(textBoxVkGrLnk.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
               .ToList();
            }
            if (!string.IsNullOrEmpty(textBoxFio.Text))
            {
                _filteredClients = _filteredClients
               .Where(x => !string.IsNullOrEmpty(x.ReceiverCredentials) && x.ReceiverCredentials.Contains(textBoxFio.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
               .ToList();
            }
            if (!string.IsNullOrEmpty(textBoxCom.Text))
            {
                _filteredClients = _filteredClients
               .Where(x => !string.IsNullOrEmpty(x.Comment) && x.Comment.Contains(textBoxCom.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
               .ToList();
            }

            _filteredOrders = _filteredOrders.OrderBy(x => x.Id).ToList();
            CreateBusinessClientsTable();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            var form = new AddClientForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                BusinessClient newClient = new BusinessClient()
                {
                    Name = form.ClientName,
                    VkId = form.VkId,
                    PostIndex = form.PostIndex,
                    Address = form.Address,
                    ReceiverCredentials = form.ReceiverCredentials,
                    Comment = form.Comment,
                    VkLink = form.VkLink,
                    VkGroupName = form.VkGroupName
                };
                newClient = _businessClientsService.AddClient(newClient);
                _businessClients.Add(newClient);
                FilterClients();
            }
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            if (clientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для изменения.");
            }
            else
            {
                var id = (int)clientsGrid.SelectedRows[0].Cells[0].Value;
                var client = _businessClients.FirstOrDefault(x => x.Id == id);
                if (client == null)
                {
                    MessageBox.Show("Выберите клиента для изменения.");
                }
                else
                {
                    var form = new AddClientForm(client);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        client.Name = form.ClientName;
                        client.VkId = form.VkId;
                        client.Address = form.Address;
                        client.PostIndex = form.PostIndex;
                        client.ReceiverCredentials = form.ReceiverCredentials;
                        client.VkLink = form.VkLink;
                        client.Comment = form.Comment;
                        client.VkGroupName = form.VkGroupName;
                        _businessClientsService.UpdateClient(client);
                        FilterClients();
                    }
                }
            }
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            if (clientsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
            else
            {
                var id = (int)clientsGrid.SelectedRows[0].Cells[0].Value;
                try
                {
                    _businessClientsService.DeleteClient(id);
                    var clientRemoved = _businessClients.Find(x => x.Id == id);
                    _businessClients.Remove(clientRemoved);
                    FilterClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ClientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clientsGrid.Columns["VkId"].Index)
            {
                var id = (int)clientsGrid.Rows[e.RowIndex].Cells[0].Value;
                var client = _businessClients.FirstOrDefault(x => x.Id == id);
                if (!string.IsNullOrEmpty(client.VkId))
                {
                    var url = client.VkId.Contains("vk.com") ? client.VkId : @"https://vk.com/gim161594158?sel=" + client.VkId;
                    try
                    {
                        Process.Start(url);
                    }
                    catch
                    {
                        // hack because of this: https://github.com/dotnet/corefx/issues/10361
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            url = url.Replace("&", "^&");
                            Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        {
                            Process.Start("xdg-open", url);
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        {
                            Process.Start("open", url);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"У клиента {client.Name} не указана информация о ВКонтакте.");
                }
            }
        }
        private void btnOpenVkGroupLink_Click(object sender, EventArgs e)
        {
            var url = btnOpenVkGroupLink.Tag?.ToString();
            if (string.IsNullOrEmpty(url))
                return;
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }

        private void Clients_DlgClick(object sender, EventArgs e)//
        {
            var id = (int)buttonDlg.Tag;
            var client = _businessClients.FirstOrDefault(x => x.Id == id);
            if (!string.IsNullOrEmpty(client.VkId))
            {
                var url = client.VkId.Contains("vk.com") ? client.VkId : @"https://vk.com/gim161594158?sel=" + client.VkId;
                try
                {
                    Process.Start(url);
                }
                catch
                {
                    // hack because of this: https://github.com/dotnet/corefx/issues/10361
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        url = url.Replace("&", "^&");
                        Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    {
                        Process.Start("xdg-open", url);
                    }
                    else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                    {
                        Process.Start("open", url);
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            else
            {
                MessageBox.Show($"У клиента {client.Name} не указана информация о ВКонтакте.");
            }

        }

        private void clientsGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (clientsGrid.CurrentCell == null || clientsGrid.CurrentCell.RowIndex == -1)
                return;
            var id = (int)clientsGrid.Rows[clientsGrid.CurrentCell.RowIndex].Cells[0].Value;
            var client = _businessClients.FirstOrDefault(x => x.Id == id);
            btnOpenVkGroupLink.Tag = client.VkLink;
            buttonDlg.Tag = client.Id;
        }
    }
}
