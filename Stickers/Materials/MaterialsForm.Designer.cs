namespace Stickers.WinForms.Materials
{
    partial class MaterialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMaterials = new System.Windows.Forms.TabControl();
            this.rollsTab = new System.Windows.Forms.TabPage();
            this.FilterPriceSale2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FilterPriceSale1 = new System.Windows.Forms.TextBox();
            this.FilterPriceBuy2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FilterPriceBuy1 = new System.Windows.Forms.TextBox();
            this.FilterFilmThickness = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FilterLength = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterWidth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FilterManufacturer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.hideEmptyRollsCheckbox = new System.Windows.Forms.CheckBox();
            this.filmFilterCombobox = new System.Windows.Forms.ComboBox();
            this.lblFilmFilter = new System.Windows.Forms.Label();
            this.btnExpendFilm = new System.Windows.Forms.Button();
            this.btnDeleteRoll = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.rollsGrid = new System.Windows.Forms.DataGridView();
            this.filmsTab = new System.Windows.Forms.TabPage();
            this.btnDeleteFilm = new System.Windows.Forms.Button();
            this.btnEditFilm = new System.Windows.Forms.Button();
            this.btnAddFilm = new System.Windows.Forms.Button();
            this.filmsGrid = new System.Windows.Forms.DataGridView();
            this.tabControlMaterials.SuspendLayout();
            this.rollsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollsGrid)).BeginInit();
            this.filmsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMaterials
            // 
            this.tabControlMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMaterials.Controls.Add(this.rollsTab);
            this.tabControlMaterials.Controls.Add(this.filmsTab);
            this.tabControlMaterials.Location = new System.Drawing.Point(12, 12);
            this.tabControlMaterials.Name = "tabControlMaterials";
            this.tabControlMaterials.SelectedIndex = 0;
            this.tabControlMaterials.Size = new System.Drawing.Size(1403, 426);
            this.tabControlMaterials.TabIndex = 0;
            this.tabControlMaterials.SelectedIndexChanged += new System.EventHandler(this.TabControlMaterials_SelectedIndexChanged);
            // 
            // rollsTab
            // 
            this.rollsTab.Controls.Add(this.FilterPriceSale2);
            this.rollsTab.Controls.Add(this.label8);
            this.rollsTab.Controls.Add(this.label9);
            this.rollsTab.Controls.Add(this.FilterPriceSale1);
            this.rollsTab.Controls.Add(this.FilterPriceBuy2);
            this.rollsTab.Controls.Add(this.label7);
            this.rollsTab.Controls.Add(this.label6);
            this.rollsTab.Controls.Add(this.FilterPriceBuy1);
            this.rollsTab.Controls.Add(this.FilterFilmThickness);
            this.rollsTab.Controls.Add(this.label5);
            this.rollsTab.Controls.Add(this.FilterLength);
            this.rollsTab.Controls.Add(this.label4);
            this.rollsTab.Controls.Add(this.FilterWidth);
            this.rollsTab.Controls.Add(this.label3);
            this.rollsTab.Controls.Add(this.FilterManufacturer);
            this.rollsTab.Controls.Add(this.label2);
            this.rollsTab.Controls.Add(this.label1);
            this.rollsTab.Controls.Add(this.textBoxId);
            this.rollsTab.Controls.Add(this.hideEmptyRollsCheckbox);
            this.rollsTab.Controls.Add(this.filmFilterCombobox);
            this.rollsTab.Controls.Add(this.lblFilmFilter);
            this.rollsTab.Controls.Add(this.btnExpendFilm);
            this.rollsTab.Controls.Add(this.btnDeleteRoll);
            this.rollsTab.Controls.Add(this.btnAddRole);
            this.rollsTab.Controls.Add(this.rollsGrid);
            this.rollsTab.Location = new System.Drawing.Point(4, 24);
            this.rollsTab.Name = "rollsTab";
            this.rollsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rollsTab.Size = new System.Drawing.Size(1395, 398);
            this.rollsTab.TabIndex = 0;
            this.rollsTab.Text = "Рулоны";
            this.rollsTab.UseVisualStyleBackColor = true;
            // 
            // FilterPriceSale2
            // 
            this.FilterPriceSale2.Location = new System.Drawing.Point(451, 32);
            this.FilterPriceSale2.Name = "FilterPriceSale2";
            this.FilterPriceSale2.Size = new System.Drawing.Size(53, 23);
            this.FilterPriceSale2.TabIndex = 24;
            this.FilterPriceSale2.TextChanged += new System.EventHandler(this.FilterRollsEvent);
            this.FilterPriceSale2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceCheck_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "до";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Цена продажи: от";
            // 
            // FilterPriceSale1
            // 
            this.FilterPriceSale1.Location = new System.Drawing.Point(366, 32);
            this.FilterPriceSale1.Name = "FilterPriceSale1";
            this.FilterPriceSale1.Size = new System.Drawing.Size(53, 23);
            this.FilterPriceSale1.TabIndex = 21;
            this.FilterPriceSale1.TextChanged += new System.EventHandler(this.FilterRollsEvent);
            this.FilterPriceSale1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceCheck_KeyPress);
            // 
            // FilterPriceBuy2
            // 
            this.FilterPriceBuy2.Location = new System.Drawing.Point(199, 30);
            this.FilterPriceBuy2.Name = "FilterPriceBuy2";
            this.FilterPriceBuy2.Size = new System.Drawing.Size(53, 23);
            this.FilterPriceBuy2.TabIndex = 20;
            this.FilterPriceBuy2.TextChanged += new System.EventHandler(this.FilterRollsEvent);
            this.FilterPriceBuy2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceCheck_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "до";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Цена покупки: от";
            // 
            // FilterPriceBuy1
            // 
            this.FilterPriceBuy1.Location = new System.Drawing.Point(114, 30);
            this.FilterPriceBuy1.Name = "FilterPriceBuy1";
            this.FilterPriceBuy1.Size = new System.Drawing.Size(53, 23);
            this.FilterPriceBuy1.TabIndex = 17;
            this.FilterPriceBuy1.TextChanged += new System.EventHandler(this.FilterRollsEvent);
            this.FilterPriceBuy1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceCheck_KeyPress);
            // 
            // FilterFilmThickness
            // 
            this.FilterFilmThickness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterFilmThickness.FormattingEnabled = true;
            this.FilterFilmThickness.Location = new System.Drawing.Point(1308, 5);
            this.FilterFilmThickness.Name = "FilterFilmThickness";
            this.FilterFilmThickness.Size = new System.Drawing.Size(77, 23);
            this.FilterFilmThickness.TabIndex = 16;
            this.FilterFilmThickness.SelectedIndexChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1198, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Толщина пленки:";
            // 
            // FilterLength
            // 
            this.FilterLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterLength.FormattingEnabled = true;
            this.FilterLength.Location = new System.Drawing.Point(1112, 4);
            this.FilterLength.Name = "FilterLength";
            this.FilterLength.Size = new System.Drawing.Size(77, 23);
            this.FilterLength.TabIndex = 14;
            this.FilterLength.SelectedIndexChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1024, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Остаток, м.п.:";
            // 
            // FilterWidth
            // 
            this.FilterWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterWidth.FormattingEnabled = true;
            this.FilterWidth.Location = new System.Drawing.Point(942, 4);
            this.FilterWidth.Name = "FilterWidth";
            this.FilterWidth.Size = new System.Drawing.Size(77, 23);
            this.FilterWidth.TabIndex = 12;
            this.FilterWidth.SelectedIndexChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(838, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ширина рулона:";
            // 
            // FilterManufacturer
            // 
            this.FilterManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterManufacturer.FormattingEnabled = true;
            this.FilterManufacturer.Location = new System.Drawing.Point(708, 4);
            this.FilterManufacturer.Name = "FilterManufacturer";
            this.FilterManufacturer.Size = new System.Drawing.Size(124, 23);
            this.FilterManufacturer.TabIndex = 10;
            this.FilterManufacturer.SelectedIndexChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Производитель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Номер рулона:";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(548, 4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(53, 23);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextChanged += new System.EventHandler(this.FilterRollsEvent);
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // hideEmptyRollsCheckbox
            // 
            this.hideEmptyRollsCheckbox.AutoSize = true;
            this.hideEmptyRollsCheckbox.Checked = true;
            this.hideEmptyRollsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hideEmptyRollsCheckbox.Location = new System.Drawing.Point(288, 6);
            this.hideEmptyRollsCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hideEmptyRollsCheckbox.Name = "hideEmptyRollsCheckbox";
            this.hideEmptyRollsCheckbox.Size = new System.Drawing.Size(157, 19);
            this.hideEmptyRollsCheckbox.TabIndex = 6;
            this.hideEmptyRollsCheckbox.Text = "Скрыть закончившиеся";
            this.hideEmptyRollsCheckbox.UseVisualStyleBackColor = true;
            this.hideEmptyRollsCheckbox.CheckedChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // filmFilterCombobox
            // 
            this.filmFilterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filmFilterCombobox.FormattingEnabled = true;
            this.filmFilterCombobox.Location = new System.Drawing.Point(82, 3);
            this.filmFilterCombobox.Name = "filmFilterCombobox";
            this.filmFilterCombobox.Size = new System.Drawing.Size(200, 23);
            this.filmFilterCombobox.TabIndex = 5;
            this.filmFilterCombobox.SelectedIndexChanged += new System.EventHandler(this.FilterRollsEvent);
            // 
            // lblFilmFilter
            // 
            this.lblFilmFilter.AutoSize = true;
            this.lblFilmFilter.Location = new System.Drawing.Point(3, 6);
            this.lblFilmFilter.Name = "lblFilmFilter";
            this.lblFilmFilter.Size = new System.Drawing.Size(73, 15);
            this.lblFilmFilter.TabIndex = 4;
            this.lblFilmFilter.Text = "Вид пленки:";
            // 
            // btnExpendFilm
            // 
            this.btnExpendFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpendFilm.Location = new System.Drawing.Point(1283, 88);
            this.btnExpendFilm.Name = "btnExpendFilm";
            this.btnExpendFilm.Size = new System.Drawing.Size(106, 23);
            this.btnExpendFilm.TabIndex = 3;
            this.btnExpendFilm.Text = "Списать пленку";
            this.btnExpendFilm.UseVisualStyleBackColor = true;
            this.btnExpendFilm.Click += new System.EventHandler(this.BtnExpendFilm_Click);
            // 
            // btnDeleteRoll
            // 
            this.btnDeleteRoll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRoll.Location = new System.Drawing.Point(1283, 116);
            this.btnDeleteRoll.Name = "btnDeleteRoll";
            this.btnDeleteRoll.Size = new System.Drawing.Size(106, 23);
            this.btnDeleteRoll.TabIndex = 2;
            this.btnDeleteRoll.Text = "Удалить рулон";
            this.btnDeleteRoll.UseVisualStyleBackColor = true;
            this.btnDeleteRoll.Click += new System.EventHandler(this.BtnDeleteRoll_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRole.Location = new System.Drawing.Point(1283, 59);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(106, 23);
            this.btnAddRole.TabIndex = 1;
            this.btnAddRole.Text = "Добавить рулон";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.BtnAddRole_Click);
            // 
            // rollsGrid
            // 
            this.rollsGrid.AllowUserToAddRows = false;
            this.rollsGrid.AllowUserToDeleteRows = false;
            this.rollsGrid.AllowUserToResizeColumns = false;
            this.rollsGrid.AllowUserToResizeRows = false;
            this.rollsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rollsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rollsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rollsGrid.Location = new System.Drawing.Point(3, 59);
            this.rollsGrid.MultiSelect = false;
            this.rollsGrid.Name = "rollsGrid";
            this.rollsGrid.ReadOnly = true;
            this.rollsGrid.RowHeadersVisible = false;
            this.rollsGrid.RowHeadersWidth = 51;
            this.rollsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rollsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rollsGrid.Size = new System.Drawing.Size(1277, 336);
            this.rollsGrid.TabIndex = 0;
            this.rollsGrid.Text = "dataGridView1";
            this.rollsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RollsGrid_CellFormatting);
            // 
            // filmsTab
            // 
            this.filmsTab.Controls.Add(this.btnDeleteFilm);
            this.filmsTab.Controls.Add(this.btnEditFilm);
            this.filmsTab.Controls.Add(this.btnAddFilm);
            this.filmsTab.Controls.Add(this.filmsGrid);
            this.filmsTab.Location = new System.Drawing.Point(4, 24);
            this.filmsTab.Name = "filmsTab";
            this.filmsTab.Padding = new System.Windows.Forms.Padding(3);
            this.filmsTab.Size = new System.Drawing.Size(1395, 398);
            this.filmsTab.TabIndex = 1;
            this.filmsTab.Text = "Виды пленок";
            this.filmsTab.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFilm
            // 
            this.btnDeleteFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFilm.Location = new System.Drawing.Point(659, 97);
            this.btnDeleteFilm.Name = "btnDeleteFilm";
            this.btnDeleteFilm.Size = new System.Drawing.Size(106, 39);
            this.btnDeleteFilm.TabIndex = 3;
            this.btnDeleteFilm.Text = "Удалить пленку";
            this.btnDeleteFilm.UseVisualStyleBackColor = true;
            this.btnDeleteFilm.Click += new System.EventHandler(this.BtnDeleteFilm_Click);
            // 
            // btnEditFilm
            // 
            this.btnEditFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFilm.Location = new System.Drawing.Point(659, 52);
            this.btnEditFilm.Name = "btnEditFilm";
            this.btnEditFilm.Size = new System.Drawing.Size(106, 39);
            this.btnEditFilm.TabIndex = 2;
            this.btnEditFilm.Text = "Изменить пленку";
            this.btnEditFilm.UseVisualStyleBackColor = true;
            this.btnEditFilm.Click += new System.EventHandler(this.BtnEditFilm_Click);
            // 
            // btnAddFilm
            // 
            this.btnAddFilm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFilm.Location = new System.Drawing.Point(659, 3);
            this.btnAddFilm.Name = "btnAddFilm";
            this.btnAddFilm.Size = new System.Drawing.Size(106, 43);
            this.btnAddFilm.TabIndex = 1;
            this.btnAddFilm.Text = "Добавить пленку";
            this.btnAddFilm.UseVisualStyleBackColor = true;
            this.btnAddFilm.Click += new System.EventHandler(this.BtnAddFilm_Click);
            // 
            // filmsGrid
            // 
            this.filmsGrid.AllowUserToAddRows = false;
            this.filmsGrid.AllowUserToDeleteRows = false;
            this.filmsGrid.AllowUserToResizeColumns = false;
            this.filmsGrid.AllowUserToResizeRows = false;
            this.filmsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filmsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmsGrid.Location = new System.Drawing.Point(3, 3);
            this.filmsGrid.MultiSelect = false;
            this.filmsGrid.Name = "filmsGrid";
            this.filmsGrid.ReadOnly = true;
            this.filmsGrid.RowHeadersVisible = false;
            this.filmsGrid.RowHeadersWidth = 51;
            this.filmsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filmsGrid.Size = new System.Drawing.Size(650, 392);
            this.filmsGrid.TabIndex = 0;
            this.filmsGrid.Text = "dataGridView1";
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 450);
            this.Controls.Add(this.tabControlMaterials);
            this.Name = "MaterialsForm";
            this.Text = "Учет материалов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlMaterials.ResumeLayout(false);
            this.rollsTab.ResumeLayout(false);
            this.rollsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollsGrid)).EndInit();
            this.filmsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filmsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMaterials;
        private System.Windows.Forms.TabPage rollsTab;
        private System.Windows.Forms.TabPage filmsTab;
        private System.Windows.Forms.DataGridView rollsGrid;
        private System.Windows.Forms.Button btnDeleteRoll;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnDeleteFilm;
        private System.Windows.Forms.Button btnEditFilm;
        private System.Windows.Forms.Button btnAddFilm;
        private System.Windows.Forms.DataGridView filmsGrid;
        private System.Windows.Forms.Button btnExpendFilm;
        private System.Windows.Forms.ComboBox filmFilterCombobox;
        private System.Windows.Forms.Label lblFilmFilter;
        private System.Windows.Forms.CheckBox hideEmptyRollsCheckbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox FilterManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FilterWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FilterLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FilterFilmThickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FilterPriceBuy2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FilterPriceBuy1;
        private System.Windows.Forms.TextBox FilterPriceSale2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FilterPriceSale1;
    }
}