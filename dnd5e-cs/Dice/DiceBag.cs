using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Dice
{
    public enum Dice : uint { D2 = 2, D3 = 3, D4 = 4, D6 = 6, D8 = 8, D10 = 10, D12 = 12, D20 = 20, D100 = 100 }

    public struct SetDiceValue
    {
        public int DiceNumber;
        public Dice DiceTytpe;
        public int PlusValue;

        public SetDiceValue(int diceNumber, Dice diceType, int plusValue = 0)
        {
            DiceNumber = diceNumber;
            DiceTytpe = diceType;
            PlusValue = plusValue;
        }
    }

    public class DiceBag
    {
        private static DiceBag instance; 
        private static Random _rand;
        private static readonly object _lock = new object();

        private DiceBag()
        {
            _rand = new Random(DateTime.Now.Second);
        }

        public static DiceBag Instance
        {
            get
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new DiceBag();
                    }
                    return instance;
                }
            }
        }

        private int RollInternal(uint dice)
        {
            return 1 + _rand.Next((int)dice);
        }

        public int RollSetDiceValue(SetDiceValue setDiceValue)
        {
            int retVal = 0;

            for(int i = 0; i < setDiceValue.DiceNumber; i++)
            {
                retVal += RollInternal((uint)setDiceValue.DiceTytpe);
            }

            return retVal + setDiceValue.PlusValue;
        }

        public int Roll(Dice dice)
        {
            return RollInternal((uint)dice);
        }

        public int RollWithModifier(Dice dice, int modifier)
        {
            return RollInternal((uint)dice) + modifier;
        }

        public int RollWithAdvantage(Dice dice)
        {
            int first = RollInternal((uint)dice);
            int second = RollInternal((uint)dice);

            return first > second ? first : second;
        }

        public int RollWithDisadvantage(Dice dice)
        {
            int first = RollInternal((uint)dice);
            int second = RollInternal((uint)dice);

            return first > second ? second : first;
        }

        public List<int> RollQuantity(Dice dice, int quantity)
        {
            List<int> diceRolls = new List<int>();
            for (int i = 0; i < quantity; i++)
            {
                diceRolls.Add(RollInternal((uint)dice));
            }
            return diceRolls;
        }

        public int RollSpecialNonDiceBetween(int minInc, int maxNonInc)
        {
            return _rand.Next(minInc, maxNonInc);
        }
    }
}
