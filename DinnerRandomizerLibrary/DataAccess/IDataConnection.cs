using DinnerRandomizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerRandomizerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateRecipe(RecipeModel model);
        List<RecipeModel> GetAllRecipes();
    }
}
