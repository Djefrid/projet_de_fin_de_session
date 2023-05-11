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
        public double PrixAchat { get; set; } 

        public InventaireIng(Ingredient ingredient, int quantite)
        {
            Lingredient = ingredient;
            Quantite = quantite;
            PrixAchat = CalculerPrixAchatIng();
        }
        public double CalculerPrixAchatIng()
        { 
            double total = Quantite * Lingredient.Prix;
            return total;   
        }

        public override string ToString()
        {
            string info = $"Nom ingredient: {Lingredient.NomI} \n Prix :{Lingredient.Prix}\n Quantité acheté: {Quantite} \n Montant achat: {PrixAchat} $"; 
            return info;
        }
    }
}
