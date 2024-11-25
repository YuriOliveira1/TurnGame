using System;
using turngame.items;

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
        public string name { get; set; } = "Lonfras Foixt";
        public float experience { get; set; } = 0.0f;
        public int level { get; set; } = 0;
        public string[] inventory { get; set; } = { };
        public Style type { get; set; } = Style.Warrior;
        public int hp { get; set; } = 0;
        public int damage { get; set; } = 0;
        public int shield { get; set; } = 0;

        ItemDatabase items = new ItemDatabase();

        public Lonfras()
        {
            this.name = name;
            this.experience = experience;
            this.level = level;
            generateAtributes();
        }

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

        public void useItem(string name)
        {   
            Items item = items.getItemByName(name);

            if (item == null)
            {
                Console.WriteLine($"{item} does not exist"); return;
            }   
            else if (hp >= 100)
            {
                Console.WriteLine("Lonfras have full HP");            
            }
            else if (shield >= 100)
            {
                Console.WriteLine("Lonfras have full Shield");
            }

            hp += item.gainHp;
            shield += item.gainShield;

            if (hp > 100)
            {
                hp = 100;
            }
            else if (shield > 100)
            {
                shield = 100;
            }
            damage += item.gainDmg;

            Console.WriteLine($"Used Item: {name}");
            displayAtributes();
        }
    }
}