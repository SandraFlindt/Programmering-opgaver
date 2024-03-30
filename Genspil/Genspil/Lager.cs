using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    internal class Lager
    {
        List<Spil> MineSpil = new List<Spil>();
        
        public void AddSpil(Spil spil)
        {
            MineSpil.Add(spil);
        }

        public List<Spil> GetSpil()
        { 
            return MineSpil; 
        }

    }
}
