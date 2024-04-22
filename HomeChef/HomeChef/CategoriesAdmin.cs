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
    public partial class CategoriesAdmin : Form
    {
        public CategoriesAdmin()
        {
            InitializeComponent();
        }

        private void CategoriesAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM Recipe_info where category_id='CT0001'";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Create a new DataTable
                        DataTable dataTable = new DataTable();

                        // Load the data from the reader into the DataTable
                        dataTable.Load(reader);

                        // Bind the DataTable to the DataGridView
                        dataGridViewRecipeB.DataSource = dataTable;
                    }
                }
            }



            query = "SELECT * FROM Recipe_info where category_id='CT0002'";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Create a new DataTable
                        DataTable dataTable = new DataTable();

                        // Load the data from the reader into the DataTable
                        dataTable.Load(reader);

                        // Bind the DataTable to the DataGridView
                        dataGridViewRecipeL.DataSource = dataTable;
                    }
                }
            }


            query = "SELECT * FROM Recipe_info where category_id='CT0003'";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        // Create a new DataTable
                        DataTable dataTable = new DataTable();

                        // Load the data from the reader into the DataTable
                        dataTable.Load(reader);

                        // Bind the DataTable to the DataGridView
                        dataGridViewRecipeD.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RecipeAdmin recipeProfile = new RecipeAdmin();
            recipeProfile.Show();
            this.Hide();
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
            ChefsAdmin recipeProfile = new ChefsAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {
            NotificationsAdmin recipeProfile = new NotificationsAdmin();
            recipeProfile.Show();
            this.Hide();
        }
    }
}
