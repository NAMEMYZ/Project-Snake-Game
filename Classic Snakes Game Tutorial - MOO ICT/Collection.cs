using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snakes_Game
{
    public interface Collection
    {
        void add(object e);
        void remove(object e);
        bool contains(object e);
        int size();
        bool isEmpty();
    }
}
