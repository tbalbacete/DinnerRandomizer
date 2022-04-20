using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerRandomizerLibrary.Models
{
    public class RecipeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StapleIngredientsEnum> Ingredients { get; set; } = new List<StapleIngredientsEnum>();
    }
}
