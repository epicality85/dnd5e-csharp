using dnd5e_cs.Abilities;
using System.Text;

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

        public Ability[] Abilities { get; private set; } = new Ability[6];

        public PlayerCharacter(string name, int str, int intl, int cons, int cha, int dex, int wis)
        {
            Name = name;
            Abilities = [
                new Strength(str), 
                new Intelligence(intl), 
                new Constitution(cons), 
                new Charisma(cha), 
                new Dexterity(dex), 
                new Wisdom(wis)
                ];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Character Details for {Name}");
            sb.AppendLine($"Character Desc: {Description}");
            sb.AppendLine($"Character Race: {PlayerCharacterRace.ToString()}");
            sb.AppendLine($"Character Background: {PlayerCharacterBackground.ToString()}");
            sb.AppendLine();
            sb.AppendLine("Abilities: ");

            foreach (var item in Abilities)
            {
                string sign = item.Modifier >= 0 ? "+" : "";
                int modifier = item.Modifier;
                sb.AppendLine($"{item.Name}: {item.Value} ({sign}{modifier})");
            }

            return sb.ToString();
        }
    }
}
