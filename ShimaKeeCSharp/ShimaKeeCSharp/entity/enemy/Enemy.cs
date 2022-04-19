using System;
using System.Collections.Generic;

namespace ShimaKeeCSharp.entity
{
    public class Enemy : Entity, Drop
    {
        private float quest;
        private string image;
        private Random rnd = new Random();
        
        public Enemy(string name, float health, float attack, float defense, string img) : 
            base(name, health, attack, defense)
        {
            defaultHp = Health;
            defaultAtk = Attack;
            defaultDef = Defense;
            this.image = img;
        }

        public float Quest
        {
            get => quest;
            set => quest = value;
        }
        public float experience { get; set; }
        public float money { get; set; }
        public float rate { get; set; }
    }
}