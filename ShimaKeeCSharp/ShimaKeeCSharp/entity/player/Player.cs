namespace ShimaKeeCSharp.entity
{
    public class Player : Entity
    {
        /// <summary>
        /// <param name="experience">Tapasztalati pont mennyiség,
        ///     később a szint számolásra kell
        /// </param>
        /// <param name="money"> Saját pénz mennyiség
        /// </param>
        /// </summary>
        private float experience;
        private float defaultExp;
        private float money;
        private float lvlCap = 1500f;

        public Player(string name, float health, float attack, float defense, float exp, float piz) : 
            base(name, health, attack, defense)
        {
            defaultHp = Health;
            defaultAtk = Attack;
            defaultDef = Defense;
            
            defaultExp = exp;
            experience = defaultExp;
            money = piz;
        }

        public float Experience
        {
            get => experience;
            set => experience = value;
        }

        public float Money
        {
            get => money;
            set => money = value;
        }

        public float LvlCap
        {
            get => lvlCap;
            set => lvlCap = value;
        }

        public float DefaultExp
        {
            get => defaultExp;
            set => defaultExp = value;
        }
    }
}