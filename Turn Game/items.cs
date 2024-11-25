using System;

namespace turngame.items
{
    public class Items
    {
        public string name { get; set; }
        public string description { get; set; }
        public int gainHp { get; set; }
        public int gainDmg { get; set; }
        public int gainShield { get; set; }
        public float price { get; set; }

        public Items(string name, string description, int gainHp, int gainDmg, int gainShield, float price)
        {
            this.name = name;
            this.description = description;
            this.gainHp = gainHp;
            this.gainDmg = gainDmg;
            this.gainShield = gainShield;
            this.price = price;
        }
    }

    public class ItemDatabase
    {
        public List<Items> Items { get; private set; }

        public ItemDatabase()
        {
            Items = new List<Items>
            {
                new Items("Potion", "Restaura 50 pontos de vida.", 50, 0, 0, 1.50f),
                new Items("Elixir", "Nothing to now.", 10, 10, 10, 1.50f),
                new Items("Shield", "Dá 30 pontos de escudo.",  0, 0, 30, 1.50f)
            };
        }

        public Items getItemByName(string name)
        {
            return Items.Find(item => item.name.ToLower() == name.ToLower());
        }
    }
}