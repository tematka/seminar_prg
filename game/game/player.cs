using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class player
    {
        public bool state;
        public bool startingRoom;
        public bool key;
        public bool modernDoor;
        public bool hall;
        public bool flute;
        public player(bool state, bool startingRoom, bool key, bool modernDoor, bool hall, bool flute)
        {
            this.state = state;
            this.startingRoom = startingRoom;
            this.key = key;
            this.modernDoor = modernDoor;
            this.hall = hall;
            this.flute = flute;
        }
    }
}
