using DinnerRandomizerLibrary.DataAccess.TextHelpers;
using DinnerRandomizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerRandomizerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreateRecipe(RecipeModel model)
        {
            List<RecipeModel> recipes = GlobalConfig.RecipeFile.FullFilePath().LoadFile().ConvertToRecipeModel();

            int currentId = 1;

            if (recipes.Count > 0)
            {
                currentId = recipes.OrderByDescending(p => p.Id).First().Id + 1;
            }

            model.Id = currentId;

            recipes.Add(model);

            recipes.SaveToRecipeFile();
        }

        public List<RecipeModel> GetAllRecipes()
        {
            return GlobalConfig.RecipeFile.FullFilePath().LoadFile().ConvertToRecipeModel();
        }
    }
}
