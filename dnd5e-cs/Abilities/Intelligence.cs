using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    internal class Intelligence : Ability
    {
        public override string Name => "Intelligence";

        public override int Value { get => _baseValue; set => throw new NotImplementedException(); }

        public Intelligence(int baseValue = 8)
        {
            _baseValue = baseValue;
        }
    }
}
