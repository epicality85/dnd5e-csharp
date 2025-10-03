using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Proficiencies
{
    public abstract class Proficiency
    {
        public virtual string Name => string.Empty;
    }

    public interface IProficiencyBonus
    {

    }
}
