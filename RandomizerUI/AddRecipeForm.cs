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
        //private List<RecipeModel> existingRecipes = GlobalConfig.Connection.GetAllRecipes();
        private List<RecipeModel> existingRecipes = new List<RecipeModel>();
        public AddRecipeForm()
        {
            InitializeComponent();

            CreateSampleData();

            WireUpLists();
        }

        private void CreateSampleData()
        {
            existingRecipes.Add(new RecipeModel { Name = "Fettucine Alfredo", Ingredients = new List<StapleIngredientsEnum>{ StapleIngredientsEnum.Fettucini, StapleIngredientsEnum.OliveOil } });
        }

        private void WireUpLists()
        {
            existingRecipesListBox.DataSource = null;
            existingRecipesListBox.DataSource = existingRecipes;
            existingRecipesListBox.DisplayMember = "Name";
        }
    }
}
