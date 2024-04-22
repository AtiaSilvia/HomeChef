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
    public partial class AddNewRecipeAdmin : Form
    {
        public AddNewRecipeAdmin()
        {
            InitializeComponent();
        }

        private void btnAddNewRecipe_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string ingredients = txtIngredients.Text;
            string description = txtDescription.Text;
            string chefId = txtChefID.Text;
            string ItemsName = txtItemsName.Text;
            string CategoryId = txtCategoryID.Text;



            string connectionString = "USER ID=SCOTT;Password=tiger;DATA SOURCE=localhost:1521/XE";
            string query = "insert into recipe_info values(Recipe_list.nextval, '"+name+"', '"+ingredients+"', '"+description+"', '"+chefId+"', '"+ItemsName+"', '"+CategoryId+"', '0')";

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Recipe added successfully");
                }
            }

        }

        private void lblRecipe_Click(object sender, EventArgs e)
        {
            RecipeAdmin RecipeAdmin = new RecipeAdmin();
            RecipeAdmin.Show();
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
    }
}
