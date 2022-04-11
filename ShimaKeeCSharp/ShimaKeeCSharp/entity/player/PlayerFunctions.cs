using System.Collections;
using System.Collections.Generic;
using System.IO;
using ShimaKeeCSharp.entity.npc;

namespace ShimaKeeCSharp.entity;

public class PlayerFunctions
{
    public void CreatePlayer(Player player)
    {
        string fileName = player.Name + "_player.txt";
        if (!File.Exists(fileName))
        {
            SavePlayerFunc(player, fileName);

            NPCFunctions NPCF = new NPCFunctions();
            NPCF.CreateNPC(player);
        }
    }

    public void SavePlayer(Player player, List<NPC> npcs)
    {
        string fileName = player.Name + "_player.txt";
        if (File.Exists(fileName))
        {
            SavePlayerFunc(player, fileName);

            NPCFunctions NPCF = new NPCFunctions();
            NPCF.SaveNPC(player, npcs);
        }
    }

    private void SavePlayerFunc(Player player, string fileName)
    {
        using (var fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
        using (var writer = new StreamWriter(fileStream))
        {
            writer.Write($"{player.Name};{player.DefaultHp};{player.DefaultAtk};");
            writer.Write($"{player.DefaultDef};{player.DefaultExp};{player.Money}");
        }
    }

    public List<Player> LoadPlayers()
    {
        List<Player> players = new List<Player>();
        EntityFunctions entityFunc = new EntityFunctions();
        List<string> playerFile = entityFunc.GetFiles("_player.txt");
        foreach (string file in playerFile)
        {
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string line = reader.ReadLine();
                    string[] playerData = line.Split(';');
                    Player player = new Player(
                        playerData[0],
                        float.Parse(playerData[1]),
                        float.Parse(playerData[2]),
                        float.Parse(playerData[3]),
                        float.Parse(playerData[4]),
                        float.Parse(playerData[5])
                    );
                    players.Add(player);
                }
            }
        }

        return players;
    }

    public void DeletePlayer(Player player)
    {
        string fileNamePlayer = player.Name + "_player.txt";
        string fileNameNPC = player.Name + "_NPC.txt";
        if(File.Exists(fileNamePlayer) && File.Exists(fileNameNPC))
        {
            File.Delete(fileNamePlayer);
            File.Delete(fileNameNPC);
        }
    }
    
    public Player LvlUp(Player player)
    {
        Player change = player;
        while (change.Experience >= change.LvlCap)
        {
            change.Experience -= change.LvlCap;
            change.Lvl++;
            change.LvlCap = GetNSetLvlCap(change.Lvl, change.LvlCap);

            change.Health = change.DefaultHp + (change.Lvl * 250);
            change.Attack = change.DefaultAtk + (change.Lvl * 25);
            change.Defense = change.DefaultDef + (change.Lvl * 10);
        }

        return player;
    }

    private float GetNSetLvlCap(float lvl, float lvlCap)
    {
        float cap = lvlCap;
        if (lvl <= 15) cap += lvl * 1500;
        else if (lvl <= 30) cap += lvl * 3000;
        else if (lvl <= 45) cap += lvl * 6000;
        else cap += lvl * 10000;

        return cap;
    }
}