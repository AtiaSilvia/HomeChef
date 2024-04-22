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
    public partial class RecipeAdmin : Form
    {
        public RecipeAdmin()
        {
            InitializeComponent();
        }

        private void RecipeAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM Recipe_info";

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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            //string selectedItem = comboBoxCategory.SelectedItem.ToString();
            string categoryID = "";
            string query = "";

            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string selectedCategory = comboBoxCategory.SelectedItem?.ToString();

            if (selectedCategory == null)
            {
                query = "SELECT * FROM Recipe_Info WHERE recipe_name like '%" + name + "%'";

            }
            else
            {

                string queryCategory = "SELECT category_id FROM categories where category_name = '" + selectedCategory + "'";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(queryCategory, connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();

                            // Fill the DataTable with the data from the query
                            adapter.Fill(dataTable);

                            categoryID = dataTable.Rows[0][0].ToString();

                        }
                    }
                }

                query = "SELECT * FROM Recipe_Info WHERE recipe_name like '%" + name + "%' and category_id = '" + categoryID + "'";
            }


            string selectedFilter = comboBoxFilter.SelectedItem?.ToString();

            if (selectedFilter == "Low to High (Views)")
            {
                query = query + "order by recipe_views asc";
            }
            else if (selectedFilter == "High to Low (Views)")
            {
                query = query + " order by recipe_views desc";
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

        private void dataGridViewRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRecipe.Columns[e.ColumnIndex].HeaderText == "Show")
            {

                int id;
                id = Convert.ToInt32(dataGridViewRecipe.Rows[e.RowIndex].Cells["IDColumn"].Value);


                string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
                string query = "BEGIN pr_recipe_views("+id+"); END; ";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                RecipeProfileAdmin recipeProfile = new RecipeProfileAdmin(id);
                recipeProfile.Show();
                this.Hide();
                //MessageBox.Show(id.ToString());

            }
            else if (dataGridViewRecipe.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int id;
                id = Convert.ToInt32(dataGridViewRecipe.Rows[e.RowIndex].Cells["IDColumn"].Value);

                string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
                string query = "DELETE FROM Recipe_Info WHERE RECIPE_ID = "+id+"";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Recipe deleted successfully");
                    }
                }


                //MessageBox.Show(id.ToString());

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM Recipe_info";

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

        private void btnAddNewRecipe_Click(object sender, EventArgs e)
        {
            AddNewRecipeAdmin addNewRecipeAdmin = new AddNewRecipeAdmin();
            addNewRecipeAdmin.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            HomeAdmin recipeProfile = new HomeAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void lblChefs_Click(object sender, EventArgs e)
        {
            ChefsAdmin recipeProfile = new ChefsAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void dataGridViewRecipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

