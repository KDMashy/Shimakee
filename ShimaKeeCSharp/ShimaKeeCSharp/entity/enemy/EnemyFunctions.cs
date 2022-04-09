using System;
using System.Collections;

namespace ShimaKeeCSharp.entity;

public class EnemyFunctions
{
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