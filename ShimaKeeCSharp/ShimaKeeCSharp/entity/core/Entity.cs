namespace ShimaKeeCSharp.entity
{
    public abstract class Entity
    {
        protected string name;
        protected float health;
        protected float attack;
        protected float defense;
        protected float lvl;

        public Entity(string name, float health, float attack, float defense)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public float Health
        {
            get => health;
            set => health = value;
        }

        public float Attack
        {
            get => attack;
            set => attack = value;
        }

        public float Defense
        {
            get => defense;
            set => defense = value;
        }

        public float Lvl
        {
            get => lvl;
            set => lvl = value;
        }
    }
}