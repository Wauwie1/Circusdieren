using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circusdieren
{
    class Trein
    {
        public List<Treinwagon> treinwagons;
        public List<Dier> alleDieren;

        public Trein()
        {
            treinwagons = new List<Treinwagon>();
            alleDieren = new List<Dier>();
        }
        public void CreateTrein(List<Dier> dieren)
        {
            alleDieren = dieren;
            GrootVleesEter();

        }

        private void GrootVleesEter()
        {
            int grootteLijst = alleDieren.Count;

            restart:
            foreach(Dier dier in alleDieren)
            {
 
                if (dier.isVleeseter == true && dier.grootte == 5)
                {
                    Treinwagon treinwagon = new Treinwagon();
                    treinwagons.Add(treinwagon);
                    AddDier(dier, treinwagon);
                    Console.WriteLine("Er is een grote vleeseter apart gezet.");
                    if (alleDieren.Count != grootteLijst)
                    {
                        goto restart;
                    }
                }
            }
        }

        private void AddDier(Dier dier, Treinwagon treinwagon)
        {
            if (treinwagon.CanAddDier(dier))
            {
                treinwagon.AddDier(dier);
                alleDieren.Remove(dier);
            }
        }
    }
}
