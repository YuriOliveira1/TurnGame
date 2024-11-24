using System;

namespace turngame.lonfras
{
    public enum Style
    {
        Warrior,
        Mage,
        Archer
    }
    public class Lonfras
    {
        string name { get; set; } = "Lonfras Foixt";
        float experience { get; set; } = 0.0f;
        int level { get; set; } = 0;
        string[] inventory { get; set; } = { };
        Style type { get; set; } = Style.Warrior;
        int hp { get; set; } = 0;
        int damage { get; set; } = 0;
        int shield { get; set; } = 0;

        public void generateAtributes()
        {
            if (type == Style.Warrior)
            {
                damage = 10;
                hp = 100;
                shield = 0;
            }
            else if (type == Style.Mage)
            {
                damage = 15;
                hp = 75;
                shield = 25;
            }
            else if (type == Style.Archer)
            {
                damage = 15;
                hp = 75;
                shield = 0;
            }
        }

        public void displayAtributes()
        {
            Console.WriteLine($"Experience: {experience}xp");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Type: {type}");
            Console.WriteLine($"Life: {hp}HP");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"Shield: {shield}");
        }
    }
}