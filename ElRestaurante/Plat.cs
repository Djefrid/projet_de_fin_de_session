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
        public double PrixA { get; set; }
        public double PrixV { get; set; }
        public RareteP RaretePl { get; set; }
        public List<Ingredient> Ingredients { get; set; }

        public Plat(string nomp, double prixA, double prixV, RareteP rare)
        {
            NomP = nomp;
            PrixA = prixA;
            PrixV = prixV;
            RaretePl = rare;
            Ingredients = new List<Ingredient>();
        }

        public void AjouterIngerdient(Ingredient ing)
        {
            Ingredients.Add(ing);
        }
        public void SupprimerIngredient(Ingredient ing)
        {
            Ingredients.Remove(ing);
        }

        public override string ToString()
        {
            string info = $"Nom: {NomP}, prix achat:{PrixA}, prix vente: {PrixV} , Rarete: {RaretePl}" +
                            $"\n Liste des ingredients: ";
            for (int i = 0; i < Ingredients.Count(); i++)
            {
                info += $"{Ingredients[i].NomI} \n";
            }
            return info;
        }

    }
}
