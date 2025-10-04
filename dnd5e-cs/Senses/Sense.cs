using dnd5e_cs.Proficiencies;

namespace dnd5e_cs.Senses
{
    public abstract class Sense
    {
        public abstract string Name { get; }
        public abstract int Value { get; protected set; }
        public abstract ProficiencyType Type { get; }
    }
}
