using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ElRestaurante
{
    public enum Qualite
    {
        Moyenne,
        Bonne,
        Excellente
    }
    class Ingredient
    {
        public string NomI { get; set; }
        public int Calorie { get; set; }
        public Qualite QualiteIng { get; set; }
        public double Prix { get; set; }

        [JsonConstructor]
        public Ingredient(string nom, int calories, string qualite, double prix)
        {
            NomI = nom;
            Calorie = calories;
            if (qualite.Contains("Moyenne"))
                QualiteIng = Qualite.Moyenne;
            else if (qualite.Contains("Bonne"))
                QualiteIng = Qualite.Bonne;
            else if (qualite.Contains("Excelente"))
                QualiteIng = Qualite.Excellente;
            else
                QualiteIng = Qualite.Moyenne;
            Prix = prix;
        }

        public override string ToString()
        {
            string info = $"Nom: {NomI},  Calorie: {Calorie}, Qualité ingredient: {QualiteIng}, Prix:{Prix} ";
            return info;
        }

    }
}
