using DinnerRandomizerLibrary;
using DinnerRandomizerLibrary.Models;

namespace RandomizerUI
{
    public partial class RandomizerDashboard : Form
    {
        List<RecipeModel> availableRecipes = GlobalConfig.Connection.GetAllRecipes();
        static Random random = new Random();
        public RandomizerDashboard()
        {
            InitializeComponent();
        }

        private void createNewRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipeForm frm = new AddRecipeForm();
            frm.Show();
            //this.Close();
        }

        private void generateRandomRecipeButton_Click(object sender, EventArgs e)
        {
            int r = random.Next(availableRecipes.Count);
            RecipeModel model = availableRecipes[r];

            WireUpBoxes(model);
        }

        private void WireUpBoxes(RecipeModel model)
        {
            recipeNameTextBox.Text = null;
            recipeNameTextBox.Text = model.Name;

            ingredientsListBox.DataSource = null;
            ingredientsListBox.DataSource = model.Ingredients;
        }
    }
}