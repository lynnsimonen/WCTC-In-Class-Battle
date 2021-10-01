using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Battle.Models
{
    public interface IMagicalCreature
    {
        public string Name { get; set; }
        public string MagicDust { get; set; }

        
        void Fly(IMagicalCreature fighter);
        void Invisible(IMagicalCreature fighter);
    }
}