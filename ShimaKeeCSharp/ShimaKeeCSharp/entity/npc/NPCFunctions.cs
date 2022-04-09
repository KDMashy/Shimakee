using System;
using System.Collections.Generic;
using System.IO;

namespace ShimaKeeCSharp.entity.npc;

public class NPCFunctions
{
    public void SaveNPC(Player player, NPC npc)
    {
        string fileName = player.Name + "_NPC.txt";
        string[] npcNames = new string[]
        {
            "Mashiron", "Shiina",
            "Raku", "Kaede",
            "Chi", "Shiro",
            "Kuro", "Hiro"
        };
        using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
        using (var writer = new StreamWriter(fileStream))
        {
            writer.Write($"{npcNames[0]};{npc.Completed};{npc.Accepted};{player.Name}");
            for (int i = 1; i < npcNames.Length; i++)
            {
                writer.Write($":{npcNames[i]};{npc.Completed};{npc.Accepted};{player.Name}");
            }
        }
    }

    public List<NPC> ReadNPC(Player player)
    {
        List<NPC> NPCList = new List<NPC>();
        string fileName = player.Name + "_NPC.txt";
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            string[] npcs = line.Split(':');
            foreach (string read in npcs)
            {
                string[] npcData = read.Split(';');
                
                bool completed = false;
                bool accepted = false;
                
                if (npcData[1].Contains("True")) completed = true;
                else completed = false;
                
                if (npcData[2].Contains("True")) accepted = true;
                else accepted = false;
                
                NPC newNPC = new NPC(
                    npcData[0],
                    completed,
                    accepted,
                    npcData[3]);
                
                NPCList.Add(newNPC);
            }
        }
        
        return NPCList;
    }
}