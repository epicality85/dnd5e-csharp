using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs
{
    public enum PlayerCharacterBackground { Hermit }
    public enum PlayerCharacterRace { Human, }
    public class PlayerCharacter
    {
        public string Name { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public PlayerCharacterBackground PlayerCharacterBackground { get; private set; } = PlayerCharacterBackground.Hermit;
        public PlayerCharacterRace PlayerCharacterRace { get; private set; } = PlayerCharacterRace.Human;
        public int WalkSpeed { get; private set; }

        public Abilities PlayerAbilities { get; private set; }

        public PlayerCharacter(string name, Abilities abilities)
        {
            Name = name;
            PlayerAbilities = abilities;
        }

        public void CharacterDetails()
        {
            Console.WriteLine($"Character Details for {Name}");
            Console.WriteLine($"Character Desc: {Description}");
            Console.WriteLine($"Character Race: {PlayerCharacterRace.ToString()}");
            Console.WriteLine($"Character Background: {PlayerCharacterBackground.ToString()}");
            Console.WriteLine();
            Console.WriteLine("Abilities: ");
            Console.WriteLine($"Strength: {PlayerAbilities.Strength}");
            Console.WriteLine($"Dexterity: {PlayerAbilities.Dexterity}");
            Console.WriteLine($"Constitution: {PlayerAbilities.Constitution}");
            Console.WriteLine($"Intelligence: {PlayerAbilities.Intelligence}");
            Console.WriteLine($"Wisdom: {PlayerAbilities.Wisdom}");
            Console.WriteLine($"Charisma: {PlayerAbilities.Charisma}");
        }
    }
}
