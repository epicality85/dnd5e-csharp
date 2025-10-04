using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Proficiencies
{
    public enum ProficiencyType { Distance, FixedValue }

    public abstract class Proficiency
    {
        public abstract string Name {  get; }
        public abstract int Value { get; protected set; }
        public abstract ProficiencyType Type { get; }
    }

    public interface IProficiencyBonus
    {

    }
}
