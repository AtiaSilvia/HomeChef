
namespace HomeChef
{
    partial class NotificationsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsAdmin));
            this.dataGridViewNotificaitions = new System.Windows.Forms.DataGridView();
            this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblChefs = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaitions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNotificaitions
            // 
            this.dataGridViewNotificaitions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewNotificaitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotificaitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.MessageColumn,
            this.DateColumn});
            this.dataGridViewNotificaitions.Location = new System.Drawing.Point(74, 205);
            this.dataGridViewNotificaitions.Name = "dataGridViewNotificaitions";
            this.dataGridViewNotificaitions.Size = new System.Drawing.Size(1204, 462);
            this.dataGridViewNotificaitions.TabIndex = 46;
            // 
            // IDColumn
            // 
            this.IDColumn.DataPropertyName = "Notification_id";
            this.IDColumn.HeaderText = "ID";
            this.IDColumn.Name = "IDColumn";
            // 
            // MessageColumn
            // 
            this.MessageColumn.DataPropertyName = "Message";
            this.MessageColumn.HeaderText = "Message";
            this.MessageColumn.Name = "MessageColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.DataPropertyName = "DateTime";
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNotification.Location = new System.Drawing.Point(733, 38);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(95, 20);
            this.lblNotification.TabIndex = 45;
            this.lblNotification.Text = "Notification";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStats.Location = new System.Drawing.Point(667, 38);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(45, 20);
            this.lblStats.TabIndex = 44;
            this.lblStats.Text = "Stats";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIngredients.Location = new System.Drawing.Point(553, 38);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(92, 20);
            this.lblIngredients.TabIndex = 43;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategories.Location = new System.Drawing.Point(444, 38);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(88, 20);
            this.lblCategories.TabIndex = 42;
            this.lblCategories.Text = "Categories";
            // 
            // lblChefs
            // 
            this.lblChefs.AutoSize = true;
            this.lblChefs.BackColor = System.Drawing.Color.Transparent;
            this.lblChefs.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChefs.Location = new System.Drawing.Point(362, 38);
            this.lblChefs.Name = "lblChefs";
            this.lblChefs.Size = new System.Drawing.Size(49, 20);
            this.lblChefs.TabIndex = 41;
            this.lblChefs.Text = "Chefs";
            this.lblChefs.Click += new System.EventHandler(this.lblChefs_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecipe.Location = new System.Drawing.Point(258, 38);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(66, 20);
            this.lblRecipe.TabIndex = 40;
            this.lblRecipe.Text = "Recipes";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHome.Location = new System.Drawing.Point(170, 38);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(54, 20);
            this.lblHome.TabIndex = 39;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(1118, 30);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 38);
            this.btnLogout.TabIndex = 48;
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
            this.btnProfile.Location = new System.Drawing.Point(1207, 30);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(102, 38);
            this.btnProfile.TabIndex = 47;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // NotificationsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.dataGridViewNotificaitions);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblChefs);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.DoubleBuffered = true;
            this.Name = "NotificationsAdmin";
            this.Text = "NotificationsAdmin";
            this.Load += new System.EventHandler(this.NotificationsAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotificaitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNotificaitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblChefs;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
    }
}