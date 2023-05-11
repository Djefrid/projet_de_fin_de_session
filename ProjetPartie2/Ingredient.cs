using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ProjetPartie2
{
    enum Qualite
    {
        Moyenne,
        Bonne,
        Excellente,
    }

    internal class Ingredient
    {
        public string Name { get; set; }
        public int Colorie { get; set; }
        public Qualite Qualites { get; set; }
        public float Prix { get; set; }

        [JsonConstructor]
        public Ingredient(string name, int colorie, string qualites, float prix)
        {
            Name = name;
            Colorie = colorie;
            if (qualites.Contains("Moyenne"))
                Qualites = Qualite.Moyenne;
            else if (qualites.Contains("Bonne"))
                Qualites = Qualite.Bonne;
            else if (qualites.Contains("Excellente"))
                Qualites = Qualite.Excellente;
            else
                Qualites = Qualite.Moyenne;
            Prix = prix;
        }
    }
}
