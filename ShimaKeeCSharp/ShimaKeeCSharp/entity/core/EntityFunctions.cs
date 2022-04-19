using System.Collections.Generic;
using System.IO;

namespace ShimaKeeCSharp.entity;

public class EntityFunctions
{
    public List<string> GetFiles(string postfix)
    {
        string[] filePaths = Directory.GetFiles(@"C:\Users\domak\Desktop\4. Szem\c#\C#formGame\Shimakee\ShimaKeeCSharp\ShimaKeeCSharp\bin\Debug\");
        List<string> neededFiles = new List<string>();
        foreach (string filePath in filePaths)
        {
            string[] getFileName = filePath.Split('\\');
            if (getFileName[getFileName.Length - 1].Contains(postfix))
            {
                neededFiles.Add(getFileName[getFileName.Length - 1]); 
            }
        }

        return neededFiles;
    }

    public List<Enemy> quest(Player player, float questId)
    {
        List<Enemy> questEnemy = new List<Enemy>();
        List<Enemy> enemies = new EnemyFunctions().LoadEnemy();
        foreach (Enemy enemy in enemies)
        {
            if (enemy.Quest == questId)
            {
                questEnemy.Add(new EnemyFunctions().UpdateEnemy(enemy, player));   
            }
        }

        return questEnemy;
    }
}