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
    public partial class StatsAdmin : Form
    {
        public StatsAdmin()
        {
            InitializeComponent();
        }

        private void StatsAdmin_Load(object sender, EventArgs e)
        {
            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "SELECT * FROM total";

            string recipe = "";
            string chef = "";
            string ingredients = "";
            string user = "";
            string items = "";
            string categories = "";

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
                            recipe = row["RECIPE_COUNT"].ToString();
                            chef = row["CHEF_COUNT"].ToString();
                            user = row["USER_COUNT"].ToString();
                            ingredients = row["INGREDIENTS_COUNT"].ToString();
                            items = row["ITEMS_COUNT"].ToString();
                            categories = row["CATEGORIES_COUNT"].ToString();

                        }

                        lblChef.Text = chef;
                        lblViewrs.Text = user;
                        lblCategorie.Text = categories;
                        lblItems.Text = items;
                        lblRecipes.Text = recipe;
                        lblIngredient.Text = ingredients;
                    }
                }
            }
        }
    }
}
