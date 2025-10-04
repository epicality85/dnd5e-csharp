using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    internal class Constitution : Ability
    {
        public override string Name => GetType().Name;

        public override int Value { get => _baseValue; }

        public Constitution(int value = 0)
        {
            _baseValue = value;
        }
    }
}
