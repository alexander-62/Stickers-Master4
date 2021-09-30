using System.Windows.Forms;

namespace Stickers.WinForms
{
    public static class ColumnUtility
    {
        public static DataGridViewColumn CreateTableColumn(string dataProperty, string header, bool isCheckbox = false)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            if (isCheckbox)
            {
                column = new DataGridViewCheckBoxColumn();
            }

            column.DataPropertyName = dataProperty;
            column.Name = header;
            column.HeaderText = header;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            return column;
        }

        public static DataGridViewColumn CreateMoneyTableColumn(string dataProperty, string header)
        {
            var column = CreateTableColumn(dataProperty, header);
            column.DefaultCellStyle.Format = "N";
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            return column;
        }

        public static DataGridViewButtonColumn CreateButtonColumn(string name, string text)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.Name = name;
            column.HeaderText = name; 
            column.Text = text;
            column.UseColumnTextForButtonValue = true;
            return column;
        }
    }
}
