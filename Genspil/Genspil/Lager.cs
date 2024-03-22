using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil
{
    internal class Lager
    {
        List<string> MineSpil = new List<string>();

        public void AddSpil(string spil)
        {
            MineSpil.Add(spil);
        }

        public List<string> GetSpil()
        { 
            return MineSpil; 
        }

    }
}
