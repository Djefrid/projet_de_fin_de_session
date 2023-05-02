using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    internal class GererRestaurant
    {

        public List<Ingredient> listIngredientDispo { get; set;}
        public void Initialiser()
        {
            listIngredientDispo = JsonFileLoader.ChargerFichier<List<Ingredient>>("json_ingredient.json");
        }
    }
}
