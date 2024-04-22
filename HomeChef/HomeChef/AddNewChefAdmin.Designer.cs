
namespace HomeChef
{
    partial class AddNewChefAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewChefAdmin));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnAddNewChef = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblNotification = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblCategories = new System.Windows.Forms.Label();
            this.lblChefs = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(467, 375);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(552, 31);
            this.txtName.TabIndex = 82;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(467, 331);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(552, 31);
            this.txtPassword.TabIndex = 81;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(467, 286);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(552, 31);
            this.txtEmail.TabIndex = 80;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(467, 465);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(552, 118);
            this.txtBio.TabIndex = 79;
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGender.Location = new System.Drawing.Point(467, 419);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(552, 32);
            this.cmbGender.TabIndex = 78;
            // 
            // btnAddNewChef
            // 
            this.btnAddNewChef.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewChef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddNewChef.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNewChef.FlatAppearance.BorderSize = 0;
            this.btnAddNewChef.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewChef.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewChef.Location = new System.Drawing.Point(1144, 150);
            this.btnAddNewChef.Name = "btnAddNewChef";
            this.btnAddNewChef.Size = new System.Drawing.Size(139, 41);
            this.btnAddNewChef.TabIndex = 77;
            this.btnAddNewChef.Text = "Add Chef";
            this.btnAddNewChef.UseVisualStyleBackColor = false;
            this.btnAddNewChef.Click += new System.EventHandler(this.btnAddNewChef_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(1121, 29);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 38);
            this.btnLogout.TabIndex = 76;
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
            this.btnProfile.Location = new System.Drawing.Point(1210, 29);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(102, 38);
            this.btnProfile.TabIndex = 75;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.BackColor = System.Drawing.Color.Transparent;
            this.lblNotification.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNotification.Location = new System.Drawing.Point(739, 38);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(95, 20);
            this.lblNotification.TabIndex = 74;
            this.lblNotification.Text = "Notification";
            // 
            // lblStats
            // 
            this.lblStats.AutoSize = true;
            this.lblStats.BackColor = System.Drawing.Color.Transparent;
            this.lblStats.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStats.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStats.Location = new System.Drawing.Point(673, 38);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(45, 20);
            this.lblStats.TabIndex = 73;
            this.lblStats.Text = "Stats";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.Transparent;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblIngredients.Location = new System.Drawing.Point(559, 38);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(92, 20);
            this.lblIngredients.TabIndex = 72;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.BackColor = System.Drawing.Color.Transparent;
            this.lblCategories.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategories.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCategories.Location = new System.Drawing.Point(450, 38);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(88, 20);
            this.lblCategories.TabIndex = 71;
            this.lblCategories.Text = "Categories";
            // 
            // lblChefs
            // 
            this.lblChefs.AutoSize = true;
            this.lblChefs.BackColor = System.Drawing.Color.Transparent;
            this.lblChefs.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChefs.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChefs.Location = new System.Drawing.Point(368, 38);
            this.lblChefs.Name = "lblChefs";
            this.lblChefs.Size = new System.Drawing.Size(49, 20);
            this.lblChefs.TabIndex = 70;
            this.lblChefs.Text = "Chefs";
            this.lblChefs.Click += new System.EventHandler(this.lblChefs_Click);
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.BackColor = System.Drawing.Color.Transparent;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecipe.Location = new System.Drawing.Point(264, 38);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(66, 20);
            this.lblRecipe.TabIndex = 69;
            this.lblRecipe.Text = "Recipes";
            this.lblRecipe.Click += new System.EventHandler(this.lblRecipe_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Transparent;
            this.lblHome.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHome.Location = new System.Drawing.Point(176, 38);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(54, 20);
            this.lblHome.TabIndex = 68;
            this.lblHome.Text = "Home";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // AddNewChefAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnAddNewChef);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.lblChefs);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblHome);
            this.DoubleBuffered = true;
            this.Name = "AddNewChefAdmin";
            this.Text = "AddNewChefAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnAddNewChef;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblNotification;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label lblChefs;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblHome;
    }
}