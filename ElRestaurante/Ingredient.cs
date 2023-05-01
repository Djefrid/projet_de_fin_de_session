using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public float Prix { get; set;}       

        [JsonConstructor]
        public Ingredient (string nomI, int calo, string qlt, float prix)
        {
            NomI = nomI;
            Calorie = calo;
            if (qlt.Contains("Moyenne"))
                QualiteIng = Qualite.Moyenne;
            else if (qlt.Contains("Bonne"))
                QualiteIng = Qualite.Bonne;
            else if (qlt.Contains("Excelente"))
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
