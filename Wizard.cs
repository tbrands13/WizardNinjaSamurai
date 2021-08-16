using System;
using System.Collections.Generic;


namespace WizardNinjaSamurai
{
    class Wizard : Human{
        

        public Wizard(string name): base(name)
        {
            Intelligence = 25;
            health = 50;
            newHealth = 0;
        }

        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            newHealth = health + dmg;
            Console.WriteLine($"{Name} gained {dmg} health points!");
            return target.health;
        }

        public int Heal(Human target){
            int hp = Intelligence * 10;
            target.health += hp;
            Console.WriteLine($"{Name} healed {target.Name} for {hp} points");
            return target.Health;
        }
    }

}