using System;
using turngame.enemy;
using turngame.lonfras;

namespace turngame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            Lonfras lonfras = new Lonfras();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Bem Vindo Ao Lonfras Turn Game");
            Console.WriteLine("O Inimigo que irá enfrentar será: ");

            Console.ForegroundColor = ConsoleColor.Red;
            enemy.displayEnemyAtributes();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Você será o Lonfras, um grande guerreiro.");
            Console.WriteLine("Seus Atributos: ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            lonfras.displayAtributes();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Agora é a sua missão matar esse Monstro");

            Console.ForegroundColor = ConsoleColor.White;
            displayMenu();

            while (true)
            {
                Console.WriteLine("Digite uma opção: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number >= 1 && number <= 6)
                    {
                        switch (number)
                        {
                            case 1:
                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            case 4:
                                break;

                            case 5:
                                break;

                            case 6:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Digite um valor valido entre 1 e 6.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada Invalida! Por favor, digite um número");
                }
            }
        }

        static void displayMenu()
        {
            Console.WriteLine("1. Attack Enemy");
            Console.WriteLine("2. Use Item");
            Console.WriteLine("3. Display Atributes");
            Console.WriteLine("4. Display Enemy Atributes");
            Console.WriteLine("5. Display Menu");
            Console.WriteLine("6. Exit");
        }

        static void displayEnemyInformation()
        {

        }
    }
}
