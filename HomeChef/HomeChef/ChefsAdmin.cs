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
    public partial class ChefsAdmin : Form
    {
        public ChefsAdmin()
        {
            InitializeComponent();
        }

        private void ChefsAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM Chef_info";

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
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM Chef_Info WHERE chef_name like '%" + name + "%'";
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

        private void btnAddNewChef_Click(object sender, EventArgs e)
        {
            AddNewChefAdmin addNewChefAdmin = new AddNewChefAdmin();
            addNewChefAdmin.Show();
            this.Hide();
        }

        private void dataGridViewRecipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRecipe.Columns[e.ColumnIndex].HeaderText == "Show")
            {

                int id;
                id = Convert.ToInt32(dataGridViewRecipe.Rows[e.RowIndex].Cells["IDColumn"].Value);

                ChefsProfileAdmin recipeProfile = new ChefsProfileAdmin(id);
                recipeProfile.Show();
                this.Hide();
                //MessageBox.Show(id.ToString());

            }
            else if (dataGridViewRecipe.Columns[e.ColumnIndex].HeaderText == "Delete")
            {

                int id;
                id = Convert.ToInt32(dataGridViewRecipe.Rows[e.RowIndex].Cells["IDColumn"].Value);

                string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
                string query = "DELETE FROM Chef_Info WHERE Chef_ID = " + id + "";

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Chef deleted successfully");
                    }
                }


                //MessageBox.Show(id.ToString());

            }
        }
    }
}
