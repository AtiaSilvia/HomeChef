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
    public partial class AddNewIngredientAdmin : Form
    {
        public AddNewIngredientAdmin()
        {
            InitializeComponent();
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

        private void lblCategories_Click(object sender, EventArgs e)
        {
            CategoriesAdmin categoriesAdmin = new CategoriesAdmin();
            categoriesAdmin.Show();
            this.Hide();
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {
            NotificationsAdmin recipeProfile = new NotificationsAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void lblIngredients_Click(object sender, EventArgs e)
        {
            IngredientsAdmin recipeProfile = new IngredientsAdmin();
            recipeProfile.Show();
            this.Hide();
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string brief = txtBrief.Text;
            string desc = txtDesc.Text;


            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "insert into Ingredients_Info values(Ingredients_list.nextval, '"+name+ "', '" + brief + "', '" + desc + "')";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Ingredient added successfully");
                }
            }
        }
    }
}
