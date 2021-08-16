using System;
using System.Collections.Generic;


namespace WizardNinjaSamurai{

    class Ninja: Human{


        public Ninja(string name): base(name)
        {
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int dmg = Dexterity * 5;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }

        public int Steal(Human target)
        {int dmg = 5;
            target.health -= dmg;
            dmg += health;
            Console.WriteLine($"{Name} stole {dmg} points of health from {target.Name}");
            return health;
        }
    }
}