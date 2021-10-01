using System;

namespace Battle.Models
{
    public class Fighter : ICombatant, IMagicalCreature
    {
        public Fighter()
        {
            Name = "Fighter";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        

        
        public void Fly(IMagicalCreature fighter){
            while (fighter.Name == "Flightmaker"){
                Console.WriteLine($"See enemy before they arrive.  Use flight while you are Flightmaker");
            }

        }

        public void Invisible(IMagicalCreature fighter){
            System.Console.WriteLine("You are flying.");
        }



        public void Attack(ICombatant enemy)
        {
            if (Weapon.Power > enemy.Armor.Defense)
                Console.WriteLine($"{Name} attacks {enemy.Name} with his {Weapon.Name}");
            else
                Console.WriteLine($"{enemy.Name} blocks {Name} with his {enemy.Armor.Name}");
        }

        public void Defend(ICombatant enemy)
        {
        }
    }
}