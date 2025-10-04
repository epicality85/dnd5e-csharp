using dnd5e_cs.Abilities;
using dnd5e_cs.Dice;
using dnd5e_cs.Proficiencies;
using dnd5e_cs.Senses;

namespace dnd5e_cs.Monsters
{
    public class Goblin : Monster
    {
        public Goblin(string name)
        {
            Name = name;
        }

        public override string Name { get; protected set; }
        public override string MonsterType => GetType().Name;
        public override string Description => "A small creature with green skin and a bad attitude";
        public override EntitySize Size { get => EntitySize.Small; }
        public override int ArmourClass => 15;
        public override SetDiceValue HpSetDiceValue => new SetDiceValue() { DiceNumber = 2, DiceTytpe = Dice.Dice.D6 };
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
        public override int ChallengeXp => 50;

        public override Ability[] Abilities => [
            new Strength(8),
            new Dexterity(14),
            new Constitution(10),
            new Intelligence(10),
            new Wisdom(8),
            new Charisma(8)
            ];
        public override Proficiency[] Proficiencies => [
            new Stealth(6)
            ];
        public override Sense[] Senses => [
            new DarkVision(60),
            new PassivePerception(9)
            ];

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
