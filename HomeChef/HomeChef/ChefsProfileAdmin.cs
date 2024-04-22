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
    public partial class ChefsProfileAdmin : Form
    {
        public int receivedValue;

        public ChefsProfileAdmin(int value)
        {
            InitializeComponent();
            receivedValue = value;

        }

        private void ChefsProfileAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM recipe_info where chef_id=" + receivedValue + "";

            string name = "";
            string email = "";
            string bio = "";

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


            string queryChef = "select * from chef_info where chef_id = " + receivedValue + "";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                //connection.Open();

                using (OracleCommand command = new OracleCommand(queryChef, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the query
                        adapter.Fill(dataTable);

                        // Use the returned data from the DataTable as needed
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Access the columns of each row
                            name = row["CHEF_NAME"].ToString();
                            email = row["CHEF_EMAIL"].ToString();
                            bio = row["CHEF_BIO"].ToString();

                        }

                        lblChefName.Text = name;

                        txtBio.Text = bio;
                        lblChefEmail.Text = email;


                    }


                }
            }
        }
    }
}
