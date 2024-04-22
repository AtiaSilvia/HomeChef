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
    public partial class RecipeProfileAdmin : Form
    {
        public int receivedValue;
        public RecipeProfileAdmin(int value)
        {
            InitializeComponent();
            receivedValue = value;
        }

        private void RecipeProfileAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM recipe_info where recipe_id="+ receivedValue+ "";

            string name = "";
            string chefId = "";
            string ingredients = "";
            string description = "";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
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
                            name = row["RECIPE_NAME"].ToString();
                            chefId = row["CHEF_ID"].ToString();
                            ingredients = row["RECIPE_INGREDIENTS"].ToString();
                            description = row["RECIPE_DESC"].ToString();

                        }

                        lblRecipeName.Text = name;
                        
                        txtIngredients.Text = ingredients;
                        txtDesc.Text = description;

                        
                    }

                    
                }
            }




            string chefName = "";
            string queryCategory = "SELECT chef_name FROM chef_info where chef_id = " + chefId + "";

            using (OracleConnection connections = new OracleConnection(connectionString))
            {
                //connection.Open();

                using (OracleCommand commands = new OracleCommand(queryCategory, connections))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(commands))
                    {
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the data from the query
                        adapter.Fill(dataTable);

                        chefName = dataTable.Rows[0][0].ToString();

                    }
                }
            }

            lblChefName.Text = chefName;






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
    }
}
