using System;
using System.Collections.Generic;

namespace ShimaKeeCSharp.entity
{
    public class Enemy : Entity, Drop
    {
        /// <summary>
        /// base felelos az alapadatokért,
        /// <param name="other">
        ///     float adatokat tartalmaz:
        ///     <param name="quest">0 - küldetés száma</param>
        ///     <param name="experience">1 - alap dobható tapasztalati pont</param>
        ///     <param name="money">2 - alap dobható pénz mennyiség</param>
        ///     <param name="rate">3 - előbbiek dobásának szorzója</param>
        /// </param>
        /// default adatok a játék közben változások után helyreállításokra kellenek
        /// </summary>
        
        private float quest;
        private Random rnd = new Random();
        
        public Enemy(string name, float health, float attack, float defense, List<float> other) : 
            base(name, health, attack, defense)
        {
            defaultHp = Health;
            defaultAtk = Attack;
            defaultDef = Defense;

            quest = other[0];
            experience = other[1];
            money = other[2];
            rate = other[3];
        }

        public float experience { get; set; }
        public float money { get; set; }
        public float rate { get; set; }
    }
}