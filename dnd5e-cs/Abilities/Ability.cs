using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs.Abilities
{
    public abstract class Ability
    {
        public virtual string Name => string.Empty;

        protected int _baseValue = 0;

        public abstract int Value { get; set; }

        public int Modifier => (_baseValue - 10) / 2;
    }

    public interface IAbilityBonus
    {
        int GetStrengthBonus();
    }
}
