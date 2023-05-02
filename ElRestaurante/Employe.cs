namespace ElRestaurante
{
    public enum RareteE
    {
        basse,
        moyenne,
        eleve
    }

    internal class Employe
    {
        public string NomE { get; set; }
        public RareteE RareteEp { get; set; }
        public int Effet { get; set; }

        public Employe(string nomE, RareteE rare, int eff)
        {
            NomE = nomE;
            RareteEp = rare;
            Effet = eff;
        }

        public override string ToString()
        {
            string info = $"Nom Employé: {NomE}, Rareté: {RareteEp}, Effet: {Effet}";
            return info;
        }

    }
}
