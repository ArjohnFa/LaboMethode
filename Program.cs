namespace Semaine2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix = choisirOptionMenu();

            Console.WriteLine($"Vous avez choisi l'option {choix}!");
        }

        static int choisirOptionMenu()
        {
            int choix = 0;
            string menu = "Choisir 1 pour un jeu du Pendu, 2 pour TicTacToe et 3 pour quitter le jeu";
            bool valide = false;

            while (!valide)
            {
                Console.Clear();
                Console.WriteLine(menu);
                int.TryParse(Console.ReadLine(), out choix);

                if(choix == 1 || choix ==2 || choix == 3)
                {
                    valide = true;
                }
            }

            return choix;
        }
    }
}