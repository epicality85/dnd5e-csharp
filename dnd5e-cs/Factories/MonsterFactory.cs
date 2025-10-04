using dnd5e_cs.Abilities;
using dnd5e_cs.Dice;
using dnd5e_cs.Monsters;
using dnd5e_cs.Proficiencies;
using dnd5e_cs.Senses;

namespace dnd5e_cs.Factories
{
    public class MonsterFactory
    {
        public static Monster? CreateMonster(string monsterName)
        {
            Monster retVal;
            MonsterStatBlock monsterStatBlock = new MonsterStatBlock();

            string description = "";
            string monsterType = monsterName;

            // create the monster from given stat blocks
            if (monsterName.ToLower() == "goblin")
            {
                monsterStatBlock.name = monsterName;
                monsterStatBlock.type = monsterType;
                monsterStatBlock.description = description;
                monsterStatBlock.ac = 15;
                monsterStatBlock.speed = 30;
                monsterStatBlock.size = EntitySize.Small;
                monsterStatBlock.hp = new SetDiceValue(2, Dice.Dice.D6);
                monsterStatBlock.str = 8;
                monsterStatBlock.dex = 14;
                monsterStatBlock.con = 10;
                monsterStatBlock.intl = 10;
                monsterStatBlock.wis = 8;
                monsterStatBlock.cha = 8;

                monsterStatBlock.proficiencies = new List<Proficiency>() { new Stealth(6) };
                monsterStatBlock.senses = new List<Sense>() { new DarkVision(30) };

                monsterStatBlock.xp = 50;
            }
            else if (monsterName.ToLower() == "bandit")
            {
                monsterStatBlock.name = monsterName;
                monsterStatBlock.type = monsterType;
                monsterStatBlock.description = description;
                monsterStatBlock.ac = 12;
                monsterStatBlock.speed = 30;
                monsterStatBlock.size = EntitySize.Medium;
                monsterStatBlock.hp = new SetDiceValue(2, Dice.Dice.D6, 2);
                monsterStatBlock.str = 11;
                monsterStatBlock.dex = 12;
                monsterStatBlock.con = 12;
                monsterStatBlock.intl = 10;
                monsterStatBlock.wis = 10;
                monsterStatBlock.cha = 10;

                monsterStatBlock.proficiencies = new List<Proficiency>() { new Stealth(6) };
                monsterStatBlock.senses = new List<Sense>() { new PassivePerception(10) };

                monsterStatBlock.xp = 25;

                return new Bandit("");
            }

            return null; //CreateMonsterInternal(monsterStatBlock);
        }

    //    private static Monster CreateMonsterInternal(MonsterStatBlock sb)
    //    {
    //        int hp = DiceBag.Instance.RollSetDiceValue(sb.hp);

    //        Ability[] abilities = [
    //                new Strength(sb.str),
    //                new Dexterity(sb.dex),
    //                new Constitution(sb.con),
    //                new Intelligence(sb.intl),
    //                new Wisdom(sb.wis),
    //                new Charisma(sb.cha)
    //            ];

    //        return new Monster(
    //            sb.type,
    //            sb.name,
    //            sb.description,
    //            hp,
    //            sb.ac,
    //            sb.speed,
    //            sb.size,
    //            abilities,
    //            sb.proficiencies.ToArray(),
    //            sb.senses.ToArray(),
    //            sb.xp
    //            );
    //    }
    }
}
