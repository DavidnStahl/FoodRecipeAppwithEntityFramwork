using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam1.entityFramwork_gorom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetsearchedTitles();
        }
        public void GetsearchedTitles()
        {
            lstBoxRecipe.Items.Clear();
            var dbm = new DBmanager();
            if (cBoxCategorys.SelectedIndex <= -1 || cBoxCategorys.Text == "No Category")
            {
                var recipies = dbm.GetSearchedRecipes(tBoxSearchField.Text);
                foreach (var recipe in recipies)
                {
                    lstBoxRecipe.Items.Add(recipe.Titel.ToString());
                }
            }
            else
            {
                var recipies = dbm.GetSearchedRecipesWith(cBoxCategorys.Text, tBoxSearchField.Text);
                foreach (var recipe in recipies)
                {
                    lstBoxRecipe.Items.Add(recipe.Titel.ToString());
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cBoxCategorys.Items.Add("No Category");
            FillComboBox();
            
        }
        public void FillComboBox()
        {
            cBoxCategorys.Items.Clear();
            var dbm = new DBmanager();
            var categories = dbm.GetCategories();
            foreach (var category in categories)
            {
                cBoxCategorys.Items.Add(category.KategoriBeskrivning.ToString());
                cBoxCategoriesNewAddDelete.Items.Add(category.KategoriBeskrivning.ToString());
            }
        }

        private void lstBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxCategoriesNewAddDelete.Items.Clear();
            var dbm = new DBmanager();
            var recipe = dbm.GetSelectedRecipe(lstBoxRecipe.SelectedItem.ToString());
            tBoxTitle.Text = recipe.Titel.ToString();
            richTextDescription.Text = recipe.Beskrivning.ToString();
            richTextIngrediens.Text = recipe.Ingredienser.ToString();
            FillComboBox();
            var selectedCategory = dbm.GetSelectedCategory(lstBoxRecipe.SelectedItem.ToString());
            cBoxCategoriesNewAddDelete.SelectedItem = selectedCategory.KategoriBeskrivning.ToString();
        }
        public void ResetTextBox()
        {
            tBoxTitle.Clear();
            richTextDescription.Clear();
            richTextIngrediens.Clear();
            cBoxCategoriesNewAddDelete.SelectedIndex = -1;
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            var dbm = new DBmanager();
            if (lstBoxRecipe.SelectedIndex > -1)
            {               
                dbm.DeleteRecipe(lstBoxRecipe.SelectedItem.ToString());
                ResetTextBox();
                GetsearchedTitles();
            }
            else
            {
                MessageBox.Show("You haven´t selected a recipe to delete");
            }
            
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            var dbm = new DBmanager();
            if (lstBoxRecipe.SelectedIndex > -1)
            {
                
                dbm.UpdateRecipe(lstBoxRecipe.SelectedItem.ToString(),tBoxTitle.Text,richTextDescription.Text,richTextIngrediens.Text,cBoxCategoriesNewAddDelete.SelectedItem.ToString());
                GetsearchedTitles();
            }
            else
            {
                MessageBox.Show("You haven´t selected a recipe to update");
            }

            
        }

        private void btnCreateNewRecipe_Click(object sender, EventArgs e)
        {
            var dbm = new DBmanager();
            if (tBoxTitle.Text.Length >= 1 && richTextDescription.Text.Length > 1 && richTextIngrediens.Text.Length > 1 && cBoxCategoriesNewAddDelete.SelectedIndex > -1)
            {
                dbm.CreateNewRecipe(tBoxTitle.Text, richTextDescription.Text, richTextIngrediens.Text, cBoxCategoriesNewAddDelete.SelectedItem.ToString());
                ResetTextBox();
                GetsearchedTitles();
            }
            else
            {
                MessageBox.Show("You have not filled all boxes");
            }
            
        }
    }
}
