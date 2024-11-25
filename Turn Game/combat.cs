using System;
using turngame.enemy;
using turngame.lonfras;

namespace turngame.combat
{
    public class Combat
    {
        Lonfras lonfras = new Lonfras();
        Enemy enemy = new Enemy();

        public void attackEnemy(Enemy enemy)
        {
            if (enemy == null)
            {
                Console.WriteLine("O Inimigo é invalido!!!");
            }

            int lonfrasDamage = lonfras.damage;
            int enemyShield = enemy.shield;

            if (enemyShield > 0)
            {
                if (lonfrasDamage > enemyShield)
                {
                    int damageRemaning = lonfrasDamage - enemyShield;
                    enemy.shield = 0;
                    enemy.hp -= damageRemaning;
                }
                else
                {
                    enemy.shield -= lonfrasDamage;
                }
            }
            else
            {
                enemy.hp -= lonfrasDamage;
            }
        }

        public bool enemyIsDead(Enemy enemy)
        {
            if (enemy == null)
            {
                Console.WriteLine("O Inimigo é invalido!!!");
            }

            if (enemy.hp <= 0)
            {
                return true;
            }
            return false;
        }

        public void dropCoins()
        {

        }

        public void attackLonfras(Lonfras lonfras)
        {
            if (enemy == null)
            {
                Console.WriteLine("Erro ao identificar Lonfras");
            }

            int enemyDamage = enemy.damage;
            int lonfrasShield = lonfras.shield;

            if (lonfrasShield > 0)
            {
                if (enemyDamage > lonfrasShield)
                {
                    int damageRemaning = enemyDamage - lonfrasShield;
                    lonfras.shield = 0;
                    lonfras.hp -= damageRemaning;
                }
                else
                {
                    lonfras.shield -= enemyDamage;
                }
            }
            else
            {
                lonfras.hp -= enemyDamage;
            }
        }

        public bool lonfrasIsDead(Lonfras lonfras)
        {
            if (lonfras == null)
            {
                Console.WriteLine("Não foi possivel identificar Lonfras");
            }

            if (lonfras.hp <= 0)
            {
                return true;
            }
            return false;
        }
    }
}