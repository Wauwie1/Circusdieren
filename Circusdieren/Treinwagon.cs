using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusdieren
{
    class Treinwagon
    {
        public List<Dier> dierenAanBoord;
        public int onBoard = 0;

        public Treinwagon()
        {
            dierenAanBoord = new List<Dier>();
        }

        public bool CanAddDier(Dier dier)
        {
            if(onBoard == 10)
            {
                return false;
            }
            else if(dier.grootte + onBoard > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void AddDier(Dier dier)
        {
            dierenAanBoord.Add(dier);
            onBoard += dier.grootte;
        }
    }
}
