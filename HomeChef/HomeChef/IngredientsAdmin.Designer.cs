
namespace HomeChef
{
    partial class IngredientsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsAdmin));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblChefs = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewRecipe = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BriefColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1042, 160);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 34);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNotification.Location = new System.Drawing.Point(745, 39);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(95, 20);
            this.lblNotification.TabIndex = 57;
            this.lblNotification.Text = "Notification";
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewIngredient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewIngredient.FlatAppearance.BorderSize = 0;
            this.btnAddNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewIngredient.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewIngredient.Location = new System.Drawing.Point(1129, 160);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(142, 34);
            this.btnAddNewIngredient.TabIndex = 55;
            this.btnAddNewIngredient.Text = "New Ingredient";
            this.btnAddNewIngredient.UseVisualStyleBackColor = false;
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(1134, 33);
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
            this.btnProfile.Location = new System.Drawing.Point(1221, 33);
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
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIngredients.Location = new System.Drawing.Point(565, 39);
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
            this.lblCategories.Location = new System.Drawing.Point(456, 39);
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
            this.lblChefs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChefs.Location = new System.Drawing.Point(374, 39);
            this.lblChefs.Name = "lblChefs";
            this.lblChefs.Size = new System.Drawing.Size(49, 20);
            this.lblChefs.TabIndex = 45;
            this.lblChefs.Text = "Chefs";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecipe.Location = new System.Drawing.Point(270, 39);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(66, 20);
            this.lblRecipe.TabIndex = 44;
            this.lblRecipe.Text = "Recipes";
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHome.Location = new System.Drawing.Point(182, 39);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(54, 20);
            this.lblHome.TabIndex = 43;
            this.lblHome.Text = "Home";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStats.Location = new System.Drawing.Point(679, 39);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(45, 20);
            this.lblStats.TabIndex = 56;
            this.lblStats.Text = "Stats";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(831, 162);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(84, 31);
            this.buttonSearch.TabIndex = 54;
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
            this.comboBoxFilter.Location = new System.Drawing.Point(93, 267);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(166, 26);
            this.comboBoxFilter.TabIndex = 51;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(455, 164);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(375, 27);
            this.textBoxSearch.TabIndex = 53;
            // 
            // dataGridViewRecipe
            // 
            this.dataGridViewRecipe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecipe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.NameColumn,
            this.BriefColumn,
            this.DescriptionColumn,
            this.ShowButton,
            this.UpdateButton,
            this.DeleteButton});
            this.dataGridViewRecipe.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecipe.Location = new System.Drawing.Point(294, 223);
            this.dataGridViewRecipe.Name = "dataGridViewRecipe";
            this.dataGridViewRecipe.Size = new System.Drawing.Size(975, 443);
            this.dataGridViewRecipe.TabIndex = 50;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "INGREDIENT_ID";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "INGREDIENT_NAME";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // BriefColumn
            // 
            this.BriefColumn.DataPropertyName = "INGREDIENT_BRIEF";
            this.BriefColumn.HeaderText = "Brief";
            this.BriefColumn.Name = "BriefColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.DataPropertyName = "INGREDIENT_DESC";
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
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
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.HeaderText = "Delete";
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseColumnTextForButtonValue = true;
            // 
            // IngredientsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnAddNewIngredient);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblChefs);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewRecipe);
            this.DoubleBuffered = true;
            this.Name = "IngredientsAdmin";
            this.Text = "IngredientsAdmin";
            this.Load += new System.EventHandler(this.IngredientsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Button btnAddNewIngredient;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblChefs;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewRecipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BriefColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ShowButton;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButton;
    }
}