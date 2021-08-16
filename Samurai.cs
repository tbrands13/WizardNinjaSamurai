using System;
using System.Collections.Generic;


namespace WizardNinjaSamurai{

    class Samurai: Human{

        public Samurai(string name): base(name)
        {
            Strength = 200;
            health = 200;
        }
        public override void ShowStats()
        {
            base.ShowStats();
        }
        public override int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            if(target.health < 50 )
            {
                target.health = 0;
            }
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            newHealth = health + dmg;
            return target.health;
        }

        public int Meditate(){
            if(health < 1000)
            {
                health = 1000;
            }
            Console.WriteLine($" {Name} healed themselves for {health} points");
            return health;
        }
    }
}