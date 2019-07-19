using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Rooms
{
    interface IRoom
    {
        String type { get; set; }
        String number { get; set; }
        Boolean Available { get; set; }

    }
}
