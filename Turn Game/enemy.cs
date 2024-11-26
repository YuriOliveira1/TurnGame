using System;

namespace turngame.enemy
{
    public enum Monster
    {
        Freit,
        Kraizk,
        Blagus,
        Frorus,
        Oriak,
        Tylut
    }
    public class Enemy
    {
        Monster monster;
        public int damage = 0;
        public int hp = 0;
        public int shield = 0;
        Random random = new Random();

        public Enemy()
        {
            spawnEnemy();
            generateEnemyAtributes();
        }

        public void spawnEnemy()
        {
            int randomMonster = random.Next(0, Enum.GetValues(typeof(Monster)).Length);
            monster = (Monster)randomMonster;
        }

        public void generateEnemyAtributes()
        {
            if (monster == Monster.Freit)
            {
                damage = 50;
                hp = 25;
                shield = 25;
            }
            else if (monster == Monster.Kraizk)
            {
                damage = 35;
                hp = 40;
                shield = 10;
            }
            else if (monster == Monster.Blagus)
            {
                damage = 15;
                hp = 60;
                shield = 0;
            }
            else if (monster == Monster.Frorus)
            {
                damage = 70;
                hp = 10;
                shield = 15;
            }
            else if (monster == Monster.Oriak)
            {
                damage = 25;
                hp = 25;
                shield = 25;
            }
            else
            {
                damage = 80;
                hp = 10;
                shield = 10;
            }
        }

        public void displayEnemyAtributes()
        {
            Console.WriteLine($"Monster: {monster}");
            Console.WriteLine($"Damage: {damage}");
            Console.WriteLine($"Life: {hp}HP");
            Console.WriteLine($"Shield: {shield}");
        }
    }
}