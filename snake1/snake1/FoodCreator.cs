using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake1
{
    class FoodCreator
    {
        int mapWeight;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator (int mapWeight, int mapHeight, char sym)
        {
            this.mapWeight = mapWeight;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }
    }
}
