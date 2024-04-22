
namespace HomeChef
{
    partial class ChefsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefsAdmin));
            this.dataGridViewRecipe = new System.Windows.Forms.DataGridView();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.btnAddNewChef = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblChefs = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecipe
            // 
            this.dataGridViewRecipe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.EmailColumn,
            this.NameColumn,
            this.GenderColumn,
            this.BioColumn,
            this.JoinDateColumn,
            this.ShowButton,
            this.UpdateButton,
            this.DeleteButton,
            this.PasswordColumn});
            this.dataGridViewRecipe.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecipe.Location = new System.Drawing.Point(293, 221);
            this.dataGridViewRecipe.Name = "dataGridViewRecipe";
            this.dataGridViewRecipe.Size = new System.Drawing.Size(972, 445);
            this.dataGridViewRecipe.TabIndex = 56;
            this.dataGridViewRecipe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRecipe_CellClick);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNotification.Location = new System.Drawing.Point(736, 38);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(95, 20);
            this.lblNotification.TabIndex = 55;
            this.lblNotification.Text = "Notification";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStats.Location = new System.Drawing.Point(670, 38);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(45, 20);
            this.lblStats.TabIndex = 54;
            this.lblStats.Text = "Stats";
            // 
            // btnAddNewChef
            // 
            this.btnAddNewChef.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewChef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewChef.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewChef.FlatAppearance.BorderSize = 0;
            this.btnAddNewChef.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewChef.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewChef.Location = new System.Drawing.Point(1122, 159);
            this.btnAddNewChef.Name = "btnAddNewChef";
            this.btnAddNewChef.Size = new System.Drawing.Size(146, 38);
            this.btnAddNewChef.TabIndex = 53;
            this.btnAddNewChef.Text = "New Chef";
            this.btnAddNewChef.UseVisualStyleBackColor = false;
            this.btnAddNewChef.Click += new System.EventHandler(this.btnAddNewChef_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(835, 162);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 31);
            this.buttonSearch.TabIndex = 52;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "Ascending (alphabetical)",
            "Descending (alphabetical)"});
            this.comboBoxFilter.Location = new System.Drawing.Point(91, 254);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(166, 26);
            this.comboBoxFilter.TabIndex = 50;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(458, 164);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(375, 27);
            this.textBoxSearch.TabIndex = 51;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLogout.Location = new System.Drawing.Point(1131, 31);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 33);
            this.btnLogout.TabIndex = 49;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(1218, 31);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(91, 34);
            this.btnProfile.TabIndex = 48;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIngredients.Location = new System.Drawing.Point(556, 38);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(92, 20);
            this.lblIngredients.TabIndex = 47;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategories.Location = new System.Drawing.Point(447, 38);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(88, 20);
            this.lblCategories.TabIndex = 46;
            this.lblCategories.Text = "Categories";
            // 
            // lblChefs
            // 
            this.lblChefs.AutoSize = true;
            this.lblChefs.BackColor = System.Drawing.Color.Transparent;
            this.lblChefs.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblChefs.Location = new System.Drawing.Point(365, 38);
            this.lblChefs.Name = "lblChefs";
            this.lblChefs.Size = new System.Drawing.Size(49, 20);
            this.lblChefs.TabIndex = 45;
            this.lblChefs.Text = "Chefs";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHome.Location = new System.Drawing.Point(173, 38);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(54, 20);
            this.lblHome.TabIndex = 43;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecipe.Location = new System.Drawing.Point(261, 38);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(66, 20);
            this.lblRecipe.TabIndex = 44;
            this.lblRecipe.Text = "Recipes";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "CHEF_ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.DataPropertyName = "CHEF_EMAIL";
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "CHEF_NAME";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "CHEF_GENDER";
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            // 
            // BioColumn
            // 
            this.BioColumn.DataPropertyName = "CHEF_BIO";
            this.BioColumn.HeaderText = "Bio";
            this.BioColumn.Name = "BioColumn";
            // 
            // JoinDateColumn
            // 
            this.JoinDateColumn.DataPropertyName = "CHEF_JOINDATE";
            this.JoinDateColumn.HeaderText = "JoinDate";
            this.JoinDateColumn.Name = "JoinDateColumn";
            // 
            // ShowButton
            // 
            this.ShowButton.HeaderText = "Show";
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Text = "Show";
            this.ShowButton.UseColumnTextForButtonValue = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.HeaderText = "Update";
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // PasswordColumn
            // 
            this.PasswordColumn.DataPropertyName = "chef_password";
            this.PasswordColumn.HeaderText = "Password";
            this.PasswordColumn.Name = "PasswordColumn";
            this.PasswordColumn.Visible = false;
            // 
            // ChefsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridViewRecipe);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.btnAddNewChef);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblChefs);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblRecipe);
            this.DoubleBuffered = true;
            this.Name = "ChefsAdmin";
            this.Text = "ChefsAdmin";
            this.Load += new System.EventHandler(this.ChefsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRecipe;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnAddNewChef;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblChefs;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowButton;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
    }
}