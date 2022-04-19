namespace ShimaKeeCSharp.entity.npc;

public class NPC
{
    private string name;
    private bool completed;
    private bool accepted;
    private string playerName;
    private float xpGive;
    private float moneyGive;

    public NPC(string name, bool completed, bool accepted, string playerName, float xp, float money)
    {
        this.name = name;
        this.completed = completed;
        this.accepted = accepted;
        this.playerName = playerName;
        this.xpGive = xp;
        this.moneyGive = money;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }

    public bool Completed
    {
        get => completed;
        set => completed = value;
    }

    public bool Accepted
    {
        get => accepted;
        set => accepted = value;
    }

    public string PlayerName
    {
        get => playerName;
        set => playerName = value;
    }

    public float XpGive
    {
        get => xpGive;
        set => xpGive = value;
    }

    public float MoneyGive
    {
        get => moneyGive;
        set => moneyGive = value;
    }
}