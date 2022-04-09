using System.Collections;

namespace ShimaKeeCSharp.entity;

public class PlayerFunctions
{
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