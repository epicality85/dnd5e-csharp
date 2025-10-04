using dnd5e_cs.Proficiencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Senses
{
    internal class DarkVision : Sense
    {
        public override string Name => GetType().Name;
        public override int Value { get; protected set; }
        public override ProficiencyType Type => ProficiencyType.Distance;

        public DarkVision(int distance)
        {
            Value = distance;
        }
    }
}
