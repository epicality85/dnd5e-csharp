using dnd5e_cs.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Races
{
    internal abstract class Race
    {
        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract Ability[] AbilityModifiers { get; }
    }
}
