using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json; 

namespace ProjetPartie2
{
    enum Temperament
    {
        cool,

    }

    internal class Client
    {
        public string NomClient { get; set; }
        public Temperament Temperaments { get; set; }
        public Random rand = new Random();


        public Client() 
        {
            int rnd = rand.Next(1, 4);
            NomClient = FabriqueNom.FabriquerNom();
            Temperaments = (Temperament)rnd;
        }
    }
}
