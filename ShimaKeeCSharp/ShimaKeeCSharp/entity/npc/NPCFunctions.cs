using System;
using System.Collections.Generic;
using System.IO;

namespace ShimaKeeCSharp.entity.npc;

public class NPCFunctions
{
    public void CreateNPC(Player player)
    {
        string[] npcNames = new string[]
        {
            "Mashiron", "Shiina",
            "Raku", "Kaede",
            "Chi", "Shiro",
            "Kuro", "Hiro"
        };
        foreach (string npcName in npcNames)
        {
            SaveFunc(npcName, false, false, player.Name);
        }
    }

    public void SaveNPC(Player player, List<NPC> npcs)
    {
        DeleteNPCList(player);
        foreach (NPC npc in npcs)
        {
            SaveFunc(npc.Name, npc.Completed, npc.Accepted, player.Name);
        }
    }

    private void SaveFunc(string npcName, bool completed, bool accepted, string player)
    {
        string fileName = player + "_NPC.txt";
        using (var fileStream = new FileStream(fileName, FileMode.Append))
        using (var writer = new StreamWriter(fileStream))
        {
            writer.Write($"{npcName};{completed};{accepted};{player}:");
        }
    }

    public List<NPC> ReadNPC(Player player)
    {
        List<NPC> NPCList = new List<NPC>();
        string fileName = player.Name + "_NPC.txt";
        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line = reader.ReadLine();
                string[] npcs = line.Split(':');
                foreach (string read in npcs)
                {
                    if (!read.Equals(""))
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
            }
        }
        
        return NPCList;
    }

    public void DeleteNPCList(Player player)
    {
        string fileName = player.Name + "_NPC.txt";
        if(File.Exists(fileName))
        {
            File.Delete(fileName);
        }
    }
}