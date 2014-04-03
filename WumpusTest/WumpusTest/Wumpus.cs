using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus_Test
{
    class Wumpus
    {

        public int room_number;
        Random gen = new Random();

        public Wumpus() // constructor
            {
            
            }


        public bool WillMove(bool input) // mutator
            {
                //decides if the wumpus will move given certain variables
                //Calls methods from player class to determine the state of the player
                //Need input from other classes before we expand

                return input;
            }

        public void changeRoom(int room1, int room2, int room3) // mutator
            {
                //changes the room of the wumpus
                //Alters GetRoomNumber field

                int randomRoom = gen.Next(3) + 1;

                if (randomRoom == 1)
                    room_number = room1;
                else if (randomRoom == 2)
                    room_number = room2;
                else if (randomRoom == 3)
                    room_number = room3;
            }

        public int GetRoomNumber() // accessor
            {
                //returns the room number that the wumpus is in
                return room_number;
            }

    }
}
