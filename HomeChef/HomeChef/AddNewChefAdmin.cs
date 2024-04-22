using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace HomeChef
{
    public partial class AddNewChefAdmin : Form
    {
        public AddNewChefAdmin()
        {
            InitializeComponent();
        }

        private void btnAddNewChef_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string gender = cmbGender.Text;
            string bio = txtBio.Text;


            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "insert into chef_info values(Chef_list.nextval, '"+email+"', '"+password+ "', '" + name + "', '" + gender + "', '" + bio + "', SYSDATE)";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Chef added successfully");
                }
            }
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            HomeAdmin recipeProfile = new HomeAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            RecipeAdmin recipeProfile = new RecipeAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void lblChefs_Click(object sender, EventArgs e)
        {
            ChefsAdmin addNewChefAdmin = new ChefsAdmin();
            addNewChefAdmin.Show();
            this.Hide();
        }
    }
}
