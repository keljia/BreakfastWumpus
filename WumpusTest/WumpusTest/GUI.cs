using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class GUI
    {
        public GUI()
        {

        }
        /// <summary>
        /// When the start button is clicked, start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void startButton_Click(object sender, EventArgs e)
        {
            //GameControl.startGame();
        }

        /// <summary>
        /// When high score button is clicked, get high scores from HighScore class and display them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void highScoreButton_Click(object sender, EventArgs e)
        {
            // Display high scores
        }

        /// <summary>
        /// When a button that could be a door is clicked, it sends the room that the person is trying to move 
        /// to (?) to game control, which checks to see if that is a valid connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void door_Click(object sender, EventArgs e)
        {
            // send request to move to another room to game control, which determines if that move is possible
        }
    }
}