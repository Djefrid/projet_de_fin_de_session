using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    public enum RareteP 
    {
        basse,
        moyenne,
        eleve
    }
    internal class Plat
    {
        public string NomP { get; set; }
        public float PrixA { get; set; }
        public float PrixV { get; set; }
        public RareteP RaretePl { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Plat(string nomp, float prixA, float prixV, RareteP rare )
        {
            NomP = nomp;
            PrixA = prixA;  
            PrixV = prixV;  
            RaretePl = rare;
            Ingredients = new List<Ingredient>();
        }

        public override string ToString()
        {
            string info =$"Nom: {NomP}, prix achat:{PrixA}, prix vente: {PrixV} , Rarete: {RaretePl}" +
                            $"\n Liste des ingredients: ";
            for(int i=0; i<Ingredients.Count(); i++)
            {
                info += $"{Ingredients[i].NomI} \n";
            }
            return info;
        }

    }
}
