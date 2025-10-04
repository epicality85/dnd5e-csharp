using dnd5e_cs.Abilities;
using dnd5e_cs.Dice;
using dnd5e_cs.Proficiencies;
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

        protected int maxHitPoints;
        public int ArmourClass { get; private set; }

        public Ability[] Abilities { get; private set; } = new Ability[6];

        public PlayerCharacter(string name, int str, int dex, int cons, int intl, int wis, int cha,  
            SetDiceValue setDiceValue, int armourClass)
        {
            Name = name;
            Abilities = [
                new Strength(str),
                new Dexterity(dex),
                new Constitution(cons), 
                new Intelligence(intl), 
                new Wisdom(wis),
                new Charisma(cha)
                ];
            ArmourClass = armourClass;
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
                sb.AppendLine($" {item.Name}: {item.Value} ({sign}{modifier})");
            }

            //string prefix, unit = "";
            sb.AppendLine("Proficiencies: ");
            //foreach (var item in Proficiencies)
            //{
            //    prefix = item.Type == ProficiencyType.FixedValue ? "+" : "";
            //    unit = item.Type == ProficiencyType.Distance ? "ft" : "";
            //    sb.AppendLine($" {item.Name} : {prefix}{item.Value}{unit}");
            //}

            sb.AppendLine("Senses: ");
            //foreach (var item in Senses)
            //{
            //    prefix = item.Type == ProficiencyType.FixedValue ? "+" : "";
            //    unit = item.Type == ProficiencyType.Distance ? "ft" : "";
            //    sb.AppendLine($" {item.Name} : {prefix}{item.Value}{unit}");
            //}

            return sb.ToString();
        }
    }
}
