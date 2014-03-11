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


        public Wumpus() // constructor
            {
            
            }


        public bool WillMove() // mutator
            {
                //decides if the wumpus will move given certain variables
                //Calls methods from player class to determine the state of the player
                return true;
            }

        public void changeRoom() // mutator
            {
                //changes the room of the wumpus
                //Alters GetRoomNumber
            }

        public int GetRoomNumber() // accessor
            {
                //returns the room number that the wumpus is in
                
                return room_number;
            }

    }
}
