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

            enemy.displayEnemyAtributes();
            Console.WriteLine(" ");
            lonfras.displayAtributes();
        }
    }
}
