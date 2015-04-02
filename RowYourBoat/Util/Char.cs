using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RowYourBoat
{
    [Flags]
    public enum Char
    {
        NONE = 0,
        WOLF = 1,
        SHEEP = 2,
        CABBAGE = 4,
        BOATMAN = 8,
    }
}
