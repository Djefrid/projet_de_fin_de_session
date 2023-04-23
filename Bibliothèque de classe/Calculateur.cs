namespace Bibliothèque_de_classe
{
    internal class Calculateur
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

        public void Multiplier()
        {
            Console.WriteLine("Entrer un nombre a diviser ");
            int nbre1 = VerifierSaisie();
            Console.WriteLine("Entrer le nombre par lequel vous vouler multiplier le premier");
            int nbre2 = VerifierSaisie();

            try
            {
                int rslt = checked(nbre1 * nbre2);

                Console.WriteLine($"le resultat de la multiplication est : {rslt}");
            }
            catch (OverflowException oEx)
            {
                Console.WriteLine("La multiplication na pas pu etre effectuer car il ya eu un depassementde capacité");
                Console.WriteLine(oEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }
        }

        public void Diviser()
        {
            Console.WriteLine("Entrer un nombre a diviser ");
            int nbre1 = VerifierSaisie();
            Console.WriteLine("Entrer le nombre par lequel vous vouler diviser le premier");
            int nbre2 = VerifierSaisie();

            try
            {
                if (nbre2 == 0)
                    throw new DivideByZeroException();

                int rslt = checked(nbre1 / nbre2);

                Console.WriteLine($"le resultat de la division est : {rslt}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("La division na pas pu etre effectuer car le denominateur est 0");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite ");
                Console.WriteLine(ex.Message);
            }
        }

        public void Exposant()
        {
            Console.WriteLine("Quel nombre vous vouler carluler l'exposant ? :");
            double nbre1 = VerifierSaisieDouble();
            Console.WriteLine("A quel nombre d'exopsant vouler vous calculer le nombre precedant ? :");
            double nbre2 = VerifierSaisieDouble();

            try
            {
                double rslt = checked(Math.Pow(nbre1, nbre2));

                Console.WriteLine($"Le resultat de l'operation est : {rslt}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("L'argument est hors plage : " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("L'argument est invalide : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
            }
        }

        /// <summary>
        /// fonction qui calcule le logarithme d'un nombre 
        /// </summary>
        public void Logarithme()
        {
            Console.WriteLine("Quel nombre vous vouler carluler le logarithme ? :");
            double nbre = VerifierSaisieDouble();

            try
            {
                double rslt = checked(Math.Log(nbre));

                Console.WriteLine($"Le resultat de l'operation est : {rslt}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("L'argument est hors plage : " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("L'argument est invalide : " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
            }
        }
    }
}