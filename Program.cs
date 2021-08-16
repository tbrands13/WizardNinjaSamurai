using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wizard firstWizard = new Wizard("Oz");
            Wizard secondWizard = new Wizard("Zo");
            // firstWizard.ShowStats();
            firstWizard.Attack(secondWizard);
            Console.WriteLine("=================");

            Ninja firstNinja = new Ninja("Snake Eyes");
            Ninja secondNinja = new Ninja("Storm Shadow");
            // firstNinja.ShowStats();
            firstNinja.Attack(secondNinja);
            secondNinja.Steal(firstWizard);
            Console.WriteLine("=================");

            Samurai firstSamurai = new Samurai("Yasuke");
            Samurai secondSamurai = new Samurai("Some Evil Samurai");
            // firstSamurai.ShowStats();
            firstSamurai.Attack(secondSamurai);
            secondSamurai.Meditate();
            Console.WriteLine("=================");
        }
    }
}
