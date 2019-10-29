using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlam1.entityFramwork_gorom
{
    class DBmanager
    {
        public DBmanager()
        {

        }
        public Kategorier GetSelectedCategory(string recipeTitle)
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var recipe = db.Recepts.SingleOrDefault(r => r.Titel == recipeTitle);
                var category = db.Kategoriers.SingleOrDefault(r => r.KategoriID == recipe.kategoriID);
                return category;
            }
        }
        public Recept GetSelectedRecipe(string recipeTitle)
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var recipe = db.Recepts.SingleOrDefault(r => r.Titel == recipeTitle);
                return recipe;
            }
        }
        public List<Kategorier> GetCategories()
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var categories = db.Kategoriers.OrderBy(r => r.KategoriID).ToList();
                return categories;
            }
        }
        public List<Recept> GetSearchedRecipes(string searchWord)
        {
            using(MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var recipes = db.Recepts.Where(r => r.Titel.StartsWith(searchWord)).ToList();
                return recipes;
            }
        }
        public List<Recept> GetSearchedRecipesWith(string categoryDescription, string searchWord)
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var category = db.Kategoriers.FirstOrDefault(c => c.KategoriBeskrivning == categoryDescription);
                var recipes = db.Recepts.Where(r => r.Titel.StartsWith(searchWord) && r.kategoriID == category.KategoriID).ToList();
                return recipes;
            }
        }
        public void DeleteRecipe(string recipeTitle)
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var recipe = db.Recepts.SingleOrDefault(r => r.Titel == recipeTitle);
                db.Entry(recipe).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public void UpdateRecipe(string selectedTitle,string title, string description, string ingrediens, string categoryDescription)
        { 
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var category = db.Kategoriers.SingleOrDefault(r => r.KategoriBeskrivning == categoryDescription);
                var recipe = db.Recepts.SingleOrDefault(r => r.Titel == selectedTitle);
                var existingRecipe = db.Recepts.SingleOrDefault(r => r.Titel == title);

                if (existingRecipe == null)
                {
                    recipe.Titel = title;
                    recipe.Beskrivning = description;
                    recipe.Ingredienser = ingrediens;
                    recipe.kategoriID = category.KategoriID;
                    db.SaveChanges();
                    MessageBox.Show("Recipe Updated!");
                }
                else
                {
                    MessageBox.Show("Recipe title already exists");
                }
                
            }
        }
        public void CreateNewRecipe(string title, string description, string ingrediens, string categoryDescription)
        {
            using (MatReceptDBEntities db = new MatReceptDBEntities())
            {
                var category = db.Kategoriers.SingleOrDefault(r => r.KategoriBeskrivning == categoryDescription);
                var existingRecipe = db.Recepts.SingleOrDefault(r => r.Titel == title);
                if (existingRecipe == null)
                {
                    var recipe = new Recept
                    {
                        Titel = title,
                        Beskrivning = description,
                        Ingredienser = ingrediens,
                        kategoriID = category.KategoriID
                    };
                    db.Recepts.Add(recipe);
                    db.SaveChanges();
                    MessageBox.Show("Recipe is created!");
                }
                else
                {
                    MessageBox.Show("Recipe title already exists");
                }
                
            }
        }
    }
}
