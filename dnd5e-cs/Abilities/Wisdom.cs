using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    internal class Wisdom : Ability
    {
        public override string Name => GetType().Name;

        public override int Value { get => _baseValue; }

        // needs something along the lines of a value that looks at equipped items and checks for any that add to ability

        public Wisdom(int value = 8)
        {
            _baseValue = value;
        }
    }
}
