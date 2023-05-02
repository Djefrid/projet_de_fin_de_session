using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElRestaurante
{
    enum Statut
    {
        Open,
        Close
    }

    internal class Restaurant
    {
        public string NomR { get; set; }
        public Statut StatutR { get; set; }
        public int NbreReserv { get; set; }
        public List<Client> Clients { get; set; }
        public Menu MenuR { get; set; }
        public List<Employe> Employes { get; set; }

        public Restaurant (string nomR, Statut statutR, int nbreReserv, Menu menuR, List<Employe> employes)
        {
            NomR = nomR;
            StatutR = statutR;
            Clients = InsererListeClient(nbreReserv);
            MenuR = menuR;
            Employes = employes;
        }  
        
        public List<Client> InsererListeClient(int nbre)
        {
            var list = new List<Client>();
            for(int i = 0; i < nbre; i++)
            {
                list.Add(FabriqueNom());
            }
        }
    }
}
