using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    internal class InventaireIng
    {
        public Ingredient Lingredient { get; set; }
        public int Quantite { get; set; }

        public InventaireIng(Ingredient ingredient, int quantite)
        {
            Lingredient = ingredient;
            Quantite = quantite;
        }

        public override string ToString()
        {
            string info = $"Nom ingredient: {Lingredient.NomI} \n Quantite: {Quantite} "; 
            return info;
        }
    }
}
