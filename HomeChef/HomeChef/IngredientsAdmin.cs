using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace HomeChef
{
    public partial class IngredientsAdmin : Form
    {
        public IngredientsAdmin()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM INGREDIENTS_INFO WHERE INGREDIENT_NAME like '%" + name + "%'";
            string selectedFilter = comboBoxFilter.SelectedItem?.ToString();

            if (selectedFilter == "Ascending (alphabetical)")
            {
                query = query + "order by asc";
            }
            else if (selectedFilter == "Descending (alphabetical)")
            {
                query = query + " order by desc";
            }

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
                        dataGridViewRecipe.DataSource = dataTable;
                    }
                }
            }
        }

        private void IngredientsAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM INGREDIENTS_INFO";

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
                        dataGridViewRecipe.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM INGREDIENTS_INFO";

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
                        dataGridViewRecipe.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            AddNewIngredientAdmin recipeProfile = new AddNewIngredientAdmin();
            recipeProfile.Show();
            this.Hide();

        }
    }
}
