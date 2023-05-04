using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPartie2
{
    static  class FabriqueNom
    {
        static List<string> ListNom = new List<string>();
        static List<string> ListPrenom = new List<string>();
        static Random Rand = new Random();

        static public void RemplirListe()
        {
            AjouterNom();
            AjouterPrenom();
        }

        static void AjouterNom()
        {
            string filePath = "nom_famille.txt";

            using(StreamReader source = new StreamReader(filePath))
            {
                string line;

                while ((line = source.ReadLine()) != null)
                {
                    ListNom.Add(line);
                }
            }
        }

        static void AjouterPrenom()
        {
            string filePath = "Prenom.txt";

            using (StreamReader source = new StreamReader(filePath))
            {
                string line;

                while ((line = source.ReadLine()) != null)
                {
                    ListPrenom.Add(line);
                }
            }
        }

        static public string FabriquerNom()
        {
            int rnd1= Rand.Next(1,ListNom.Count);
            int rnd2= Rand.Next(1,ListPrenom.Count);
            string nom = $"{ListNom[rnd1]} {ListPrenom[rnd2]}";

            return nom;
        }
    }
}
