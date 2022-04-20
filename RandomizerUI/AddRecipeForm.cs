using DinnerRandomizerLibrary;
using DinnerRandomizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomizerUI
{
    public partial class AddRecipeForm : Form
    {
        private List<RecipeModel> existingRecipes = GlobalConfig.Connection.GetAllRecipes();
        //private List<RecipeModel> existingRecipes = new List<RecipeModel>();
        private List<string> selectedIngredients = new List<string>();
        public AddRecipeForm()
        {
            InitializeComponent();

            //CreateSampleData();

            availableIngredientsDropDown.DataSource = null;
            availableIngredientsDropDown.DataSource = Enum.GetValues(typeof(StapleIngredientsEnum));

            WireUpRecipeLists();
        }

        private void CreateSampleData()
        {
            existingRecipes.Add(new RecipeModel { Name = "Fettucine Alfredo", Ingredients = new List<StapleIngredientsEnum>{ StapleIngredientsEnum.Fettucini, StapleIngredientsEnum.OliveOil } });
        }

        private void WireUpRecipeLists()
        {
            existingRecipesListBox.DataSource = null;
            existingRecipesListBox.DataSource = existingRecipes;
            existingRecipesListBox.DisplayMember = "Name";
        }

        private void WireUpIngredients()
        {
            addedIngredientsListBox.DataSource = null;
            addedIngredientsListBox.DataSource = selectedIngredients;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            string output;

            if (availableIngredientsDropDown.SelectedItem != null)
            {
                output = availableIngredientsDropDown.SelectedItem.ToString();
                selectedIngredients.Add(output);
                WireUpIngredients();
            }
            else
            {
                MessageBox.Show("Please select an ingredient before hitting this button.");
            }
        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                RecipeModel r = new RecipeModel();
                r.Name = newRecipeNameTextBox.Text;
                r.Ingredients = selectedIngredients.Select(x => (StapleIngredientsEnum)Enum.Parse(typeof(StapleIngredientsEnum), x)).ToList();
                GlobalConfig.Connection.CreateRecipe(r);
                existingRecipes.Add(r);
                MessageBox.Show("Recipe successfully added!");
                WireUpRecipeLists();
            }
            else
            {
                MessageBox.Show("Your team could not be added. Please ensure all inputs are valid.");
            }
        }
            
        private bool ValidateForm()
        {
            if (addedIngredientsListBox.Items.Count == 0)
            {
                MessageBox.Show("Please add ingredients prior to submitting a new recipe.");
                return false;
            }
            if (newRecipeNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please add a recipe name prior to submitting a new recipe.");
                return false;
            }
            bool contains = existingRecipes.Any(p => p.Name == newRecipeNameTextBox.Text);
            if (contains)
            {
                return false;
            }
            return true;
        }
    }
}
