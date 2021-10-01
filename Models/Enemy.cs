namespace Battle.Models
{
    public class Enemy : ICombatant
    {
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        public Enemy()
        {
            Name = "Enemy";
            Armor = new Armor();
            Weapon = new Weapon();
        }

        public void Attack(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        public void Defend(ICombatant enemy)
        {
            throw new System.NotImplementedException();
        }

        
        public void Fly(IMagicalCreature fighter){
            string magicDust = "shiek";

            System.Console.WriteLine($"When you {magicDust} the fighters will be able to fly.");
        }

    }
}