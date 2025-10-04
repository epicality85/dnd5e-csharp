using dnd5e_cs;
using dnd5e_cs.Abilities;
using dnd5e_cs.Dice;
using dnd5e_cs.Proficiencies;
using dnd5e_cs.Senses;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

public struct MonsterStatBlock
{
    public string name;
    public string type;
    public string description;
    public int ac;
    public int speed;
    public EntitySize size;
    public SetDiceValue hp;
    public int str;
    public int dex;
    public int con;
    public int intl;
    public int wis;
    public int cha;
    public List<Proficiency> proficiencies;
    public List<Sense> senses;
    public int xp;
}

public abstract class Monster
{
    public abstract string Name { get; protected set; }
    public abstract string MonsterType { get; }
    public abstract string Description { get; }
    public abstract EntitySize Size { get; }
    public abstract int ArmourClass { get; }
    public abstract int MaxHitPoints { get; protected set; }
    public abstract SetDiceValue HpSetDiceValue { get; }
    public abstract int WalkSpeed { get; }
    public abstract int ChallengeXp { get; }

    public int CurrentHitPoints;
    
    public abstract Ability[] Abilities { get; }
    public abstract Proficiency[] Proficiencies { get; }
    public abstract Sense[] Senses { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Character Details for {Name} : {MonsterType}");
        sb.AppendLine($"Character Desc: {Description}");
        sb.AppendLine();
        
        sb.AppendLine("Abilities: ");
        foreach (var item in Abilities)
        {
            string sign = item.Modifier >= 0 ? "+" : "";
            int modifier = item.Modifier;
            sb.AppendLine($" {item.Name}: {item.Value} ({sign}{modifier})");
        }

        string prefix, unit = "";
        sb.AppendLine("Proficiencies: ");
        foreach (var item in Proficiencies)
        {
            prefix = item.Type == ProficiencyType.FixedValue ? "+" : "";
            unit = item.Type == ProficiencyType.Distance ? "ft" : "";
            sb.AppendLine($" {item.Name} : {prefix}{item.Value}{unit}");
        }

        sb.AppendLine("Senses: ");
        foreach (var item in Senses)
        {
            prefix = item.Type == ProficiencyType.FixedValue ? "+" : "";
            unit = item.Type == ProficiencyType.Distance ? "ft" : "";
            sb.AppendLine($" {item.Name} : {prefix}{item.Value}{unit}");
        }

        return sb.ToString();
    }
}