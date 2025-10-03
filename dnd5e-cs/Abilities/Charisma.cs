using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    internal class Charisma : Ability
    {
        public override string Name => "Charisma";

        public override int Value { get => _baseValue; set => throw new NotImplementedException(); }

        public Charisma(int value = 8)
        {
            _baseValue = value;
        }
    }
}
