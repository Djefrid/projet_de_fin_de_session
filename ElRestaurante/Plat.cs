using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ElRestaurante
{
    public enum RareteP
    {
        Basse,
        Moyenne,
        Eleve
    }
    internal class Plat
    {
        public string NomP { get; set; }
        public double PrixA { get; set; }
        public double PrixV { get; set; }
        public RareteP RaretePl { get; set; }
        public List<string> Ingredients { get; set; }

        [JsonConstructor]
        public Plat(string nom, double prix_achat, double prix_vente, string rarete, List<string> ingredients)
        {
            NomP = nom;
            PrixA = prix_achat;
            PrixV = prix_vente;
            if (rarete.Contains("Moyenne"))
                RaretePl = RareteP.Moyenne;
            else if (rarete.Contains("Basse"))
                RaretePl = RareteP.Basse;
            else if (rarete.Contains("Eleve"))
                RaretePl = RareteP.Eleve;
            else
                RaretePl = RareteP.Moyenne;
            
            Ingredients = ingredients;
        }

        public Plat()
        {

        }

        public void AjouterIngredient(string ing)
        {
            Ingredients.Add(ing);
        }
        public void SupprimerIngredient(string ing)
        {
            Ingredients.Remove(ing);
        }

        public override string ToString()
        {
            string info = $"Nom: {NomP} \n prix achat:{PrixA} \n prix vente: {PrixV} \n Rarete: {RaretePl}" +
                            $"\n Liste des ingredients: ";
            for (int i = 0; i < Ingredients.Count(); i++)
            {
                info += $"\n {Ingredients[i]} ";
            }
            return info;
        }

    }
}
