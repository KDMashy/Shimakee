using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ShimaKeeCSharp.entity;

public class EnemyFunctions
{
    public List<Enemy> LoadEnemy()
    {
        List<Enemy> enemies = new List<Enemy>();
        string fileName = "enemy.txt";
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] enemyData = line.Split(';');
                    Enemy enemy = new Enemy(
                        enemyData[0],
                        float.Parse(enemyData[1]),
                        float.Parse(enemyData[2]),
                        float.Parse(enemyData[3])
                    );
                    enemy.Quest = float.Parse(enemyData[4]);
                    enemy.experience = float.Parse(enemyData[5]);
                    enemy.money = float.Parse(enemyData[6]);
                    enemy.rate = float.Parse(enemyData[7]);
                    
                    enemies.Add(enemy);
                }
            }
        }
        return enemies;
    }

    public Enemy UpdateEnemy(Enemy enemy, Player player)
    {
        if (player.Lvl >= 3)
        {
            enemy.Lvl *= (player.Lvl - 2);
        }
        else
        {
            enemy.Lvl *= player.Lvl;
        }
        
        float setLvl = (player.Lvl * enemy.Lvl);
        enemy.Health = enemy.DefaultHp * setLvl;
        enemy.Attack = enemy.DefaultAtk * setLvl;
        enemy.Defense = enemy.DefaultDef * setLvl;

        enemy.experience = (float) 
            (Math.Round(enemy.experience * enemy.rate) * enemy.Lvl) + 50;
        enemy.money = (float) 
            (Math.Round(enemy.money * enemy.rate) * enemy.Lvl) + 50;

        return enemy;
    }
}