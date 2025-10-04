using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    internal class Charisma : Ability
    {
        public override string Name => GetType().Name;

        public override int Value { get => _baseValue; }

        public Charisma(int value = 8)
        {
            _baseValue = value;
        }
    }
}
