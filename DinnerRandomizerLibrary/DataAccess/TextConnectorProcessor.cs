using DinnerRandomizerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerRandomizerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<RecipeModel> ConvertToRecipeModel(this List<string> lines)
        {
            List<RecipeModel> output = new List<RecipeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                RecipeModel model = new RecipeModel();
                model.Id = int.Parse(cols[0]);
                model.Name = cols[1];
                
                string[] ingredientsList = cols[2].Split('|');

                foreach (string ingredient in ingredientsList)
                {
                    StapleIngredientsEnum ingredientsEnum = (StapleIngredientsEnum)Enum.Parse(typeof(StapleIngredientsEnum), ingredient, true);
                    model.Ingredients.Add(ingredientsEnum);
                }
                output.Add(model);
            }

            return output;
        }

        public static void SaveToRecipeFile(this List<RecipeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (RecipeModel r in models)
            {
                lines.Add($"{r.Id},{r.Name},{ConvertIngredientListToString(r.Ingredients)}");
            }

            File.WriteAllLines(GlobalConfig.RecipeFile.FullFilePath(), lines);
        }

        private static string ConvertIngredientListToString(List<StapleIngredientsEnum> ingredients)
        {
            string output = "";
            if (ingredients.Count == 0)
            {
                return "";
            }

            foreach (StapleIngredientsEnum ig in ingredients)
            {
                output += $"{ig.ToString()}|";
            }
            
            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
