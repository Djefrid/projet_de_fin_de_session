namespace MaBlibliotheque
{
    public class Calculateur
    {
        public Calculateur() { }


        public int VerifierSaisie()
        {
            bool estValide = false;
            int nbre = 0;

            do
            {
                try
                {
                    string value = Console.ReadLine();

                    if (!int.TryParse(value, out nbre))
                        throw new MonException("Vous n'avez pas entrer un entier");
                    else
                        estValide = true;
                }
                catch (MonException monEx)
                {
                    Console.WriteLine(monEx.Message);
                }
                finally
                {
                    if (!estValide)
                    {
                        Console.WriteLine("Ressayer");
                    }
                }

            } while (!estValide);

            return nbre;
        }

        public double VerifierSaisieDouble()
        {
            bool estValide = false;
            double nbre = 0;

            do
            {
                try
                {
                    string value = Console.ReadLine();

                    if (!double.TryParse(value, out nbre))
                        throw new MonException("Vous n'avez pas entrer un entier");
                    else
                        estValide = true;
                }
                catch (MonException monEx)
                {
                    Console.WriteLine(monEx.Message);
                }
                finally
                {
                    if (!estValide)
                    {
                        Console.WriteLine("Ressayer");
                    }
                }

            } while (!estValide);

            return nbre;
        }

        public int Multiplier(int nbre1, int nbre2)
        {
            try
            {
                int rslt = checked(nbre1 * nbre2);

                Console.WriteLine($"le resultat de la multiplication est : {rslt}");
                return rslt;
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("La multiplication na pas pu etre effectuer car il ya eu un depassementde capacité");
                Console.WriteLine(oEx.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
                return 0;
            }

        }

        public int Diviser(int nbre1, int nbre2)
        {
            try
            {
                if (nbre2 == 0)
                    throw new DivideByZeroException();

                int rslt = checked(nbre1 / nbre2);

                Console.WriteLine($"le resultat de la division est : {rslt}");
                return rslt;

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("La division na pas pu etre effectuer car le denominateur est 0");
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite ");
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public double Exposant(double nbre1, double nbre2)
        {
            try
            {
                double rslt = checked(Math.Pow(nbre1, nbre2));

                Console.WriteLine($"Le resultat de l'operation est : {rslt}");
                return rslt;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("L'argument est hors plage : " + ex.Message);
                return 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("L'argument est invalide : " + ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
                return 0;
            }
        }

        /// <summary>
        /// fonction qui calcule le logarithme d'un nombre 
        /// </summary>
        public double Logarithme(double nbre)
        {
            try
            {
                double rslt = checked(Math.Log10(nbre));

                Console.WriteLine($"Le resultat de l'operation est : {rslt}");
                return rslt;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("L'argument est hors plage : " + ex.Message);
                return 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("L'argument est invalide : " + ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
                return 0;
            }
        }
    }
}