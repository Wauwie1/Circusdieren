using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    class Ship
    {
        int maxWeight;
        int leftWeight = 0;
        int rightWeight = 0;
        List<Container> containers;
        public int[] size = new int[2];
        Container[,,] deck;

        public Ship(int maxWeight, int widthShip, int lengthShip, int widthContainer, int lengthContainer)
        {
            size[0] = widthShip / widthContainer;
            size[1] = lengthShip / lengthContainer;
            size[2] = 31;
            deck = new Container[widthShip / widthContainer, lengthShip / lengthContainer, 31];
            this.maxWeight = maxWeight;
        }

        public void AddContainer(Container container)
        {
            containers.Add(container);
        }

        private void SortByWeight()
        {
            for(int i = 0; i < containers.Count; i++)
            {
                if(containers[i + 1].weight > containers[i].weight)
                {
                    int temp = containers[i].weight;
                    containers[i].weight = containers[i + 1].weight;
                    containers[i + 1].weight = temp;
                }
            }
        }

    }
}
