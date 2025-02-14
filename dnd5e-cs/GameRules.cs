using dnd5e_cs.Dice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd5e_cs
{
    public class GameRules
    {
        public DiceBag DiceBag { get; private set; }

        public GameRules() 
        {
            DiceBag = new DiceBag();
        }
    }
}
