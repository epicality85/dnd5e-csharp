using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Proficiencies
{
    internal class Stealth : Proficiency
    {
        public override string Name => GetType().Name;
        public override int Value { get; protected set; }
        public override ProficiencyType Type { get => ProficiencyType.FixedValue; }

        public Stealth(int value)
        {
            Value = value;
        }
    }
}
