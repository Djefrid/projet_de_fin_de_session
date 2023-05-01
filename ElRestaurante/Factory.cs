using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ElRestaurante
{
    static class Factory
    {
        static List<string> listNom = new List<string>();
        static List<string> listPrenom = new List<string>();
        static Random rand = new Random();

        static public void RemplirListe()
        {
            AjouterNom();
            AjouterPrenom();
        }

        static void AjouterNom()
        {
            string fichierNomFamille = "nom_famille.txt";
           using (StreamReader reader = new StreamReader(fichierNomFamille))
            {
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    listNom.Add(line);
                }
            }
        }

        static void AjouterPrenom()
        {
            string fichierPrenom = "prenom.txt";
            using (StreamReader reader = new StreamReader(fichierPrenom))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    listPrenom.Add(line);
                }
            }
        }
        public static string FabriquerNom()
        {
            int rndnom = rand.Next(1, listNom.Count());
            int rndprenom = rand.Next(1, listPrenom.Count());
            string nom = $"{listNom[rndnom]} {listPrenom[rndprenom]} ";
            return nom;
        }
    }
}
