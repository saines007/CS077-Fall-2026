using System;

namespace PlanetCereal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine("            PLANET CEREAL");
                Console.WriteLine("========================================");
                Console.WriteLine();

                Console.WriteLine("Select a cereal to reveal its country of origin:");
                Console.WriteLine();

                // Choco Krispies Box
                Console.WriteLine("       +----------------------+");
                Console.WriteLine("       |        CEREAL        |");
                Console.WriteLine("       |----------------------|");
                Console.WriteLine("       |                      |");
                Console.WriteLine("       |      __________      |");
                Console.WriteLine("       |     |          |     |");
                Console.WriteLine("       |     |   CHOCO  |     |");
                Console.WriteLine("       |     | KRISPIES |     |");
                Console.WriteLine("       |     |          |     |");
                Console.WriteLine("       |     |__________|     |");
                Console.WriteLine("       |                      |");
                Console.WriteLine("       |----------------------|");
                Console.WriteLine("       |      ¡DELICIOSO!     |");
                Console.WriteLine("       +----------------------+");

                Console.WriteLine();
                Console.Write("Enter the cereal name: ");
                string choice = Console.ReadLine();

                if (choice.ToUpper() == "CHOCO KRISPIES")
                {
                    Console.Clear();

                    Console.WriteLine("========================================");
                    Console.WriteLine("            GREAT CHOICE!");
                    Console.WriteLine("========================================");
                    Console.WriteLine();

                    Console.WriteLine("You selected Choco Krispies!");
                    Console.WriteLine();
                    Console.WriteLine("Country of Origin: Mexico");
                    Console.WriteLine();

                    Console.WriteLine("Press Enter to return to cereal selection.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, we don't have that cereal yet.");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to return to cereal selection.");
                    Console.ReadLine();
                }
            }
        }
    }
}