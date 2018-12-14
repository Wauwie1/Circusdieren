using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer
{
    class Container
    {
        public int weight = 4; // in tons
        int[,,] pos;
        ContainerType type;

        public Container(int weight, int[] xyz, ContainerType type)
        {
            this.weight = weight;
            pos = new int[xyz[0], xyz[1], xyz[2]];
            this.type = type;
        }

    }

    public enum ContainerType
    {
        Regular, Cooled, Precious
    }
}
