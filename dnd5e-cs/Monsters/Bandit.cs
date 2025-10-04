using dnd5e_cs.Abilities;
using dnd5e_cs.Dice;
using dnd5e_cs.Proficiencies;
using dnd5e_cs.Senses;

namespace dnd5e_cs.Monsters
{
    public class Bandit : Monster
    {
        public Bandit(string name)
        {
            Name = name;
        }

        public override string Name { get; protected set; }
        public override string MonsterType => GetType().Name;
        public override string Description => "A gang member usually out for their own gain";
        public override EntitySize Size { get => EntitySize.Medium; }
        public override int ArmourClass => 12;
        public override SetDiceValue HpSetDiceValue => new SetDiceValue() { DiceNumber = 2, DiceTytpe = Dice.Dice.D10, PlusValue = 2 };
        public override int MaxHitPoints
        {
            get
            {
                if (MaxHitPoints == 0)
                {
                    MaxHitPoints = DiceBag.Instance.RollSetDiceValue(HpSetDiceValue);
                }
                return MaxHitPoints;
            }
            protected set => MaxHitPoints = value;
        }
        public override int WalkSpeed => 30;
        public override int ChallengeXp => 25;

        public override Ability[] Abilities => [
            new Strength(11),
            new Dexterity(12),
            new Constitution(12),
            new Intelligence(10),
            new Wisdom(10),
            new Charisma(10)
            ];
        public override Proficiency[] Proficiencies => [
            new Stealth(6)
            ];
        public override Sense[] Senses => [
            new PassivePerception(10)
            ];

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
