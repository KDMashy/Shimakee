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
        private float money;

        public Player(string name, float health, float attack, float defense) : 
            base(name, health, attack, defense)
        {
            experience = 0;
            money = 0;
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
    }
}