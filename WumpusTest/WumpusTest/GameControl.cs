using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    public class GameControl
    {
        // private GUI graphics = new GUI(this);
        // private Cave cave = new Cave();
        // private Map map = new Map();
        // private Trivia trivia = new Trivia();
        // private Player player = new Player();
        // private Wumpus wumpus = new Wumpus;

        public enum ErrorType { BUG, NORM, WARN };
        public enum EntType { WUMPUS, PLAYER };

        public GameControl()
        {
            gameState = 0;
        }

        private void printError(ErrorType e, String report)
        {
            String str = "";
            if (e == ErrorType.WARN)
            {
                str += "WARNING: ";
            }

            if (e == ErrorType.NORM)
            {
                str += "NORMAL: ";
            }

            if (e == ErrorType.BUG)
            {
                str += "BUG: ";
            }

            str += report;

            Console.Out.WriteLine(str);
        }

        /* 
         * Notes to self:
         * All methods are called by GUI
         * GUI has a reference to me
         * 
         */

        /// <summary>
        /// gameState:
        ///     -1 = unknown state
        ///     0 = Main Menu
        ///     1 = Game
        ///     2 = Trivia
        /// </summary>
        private int gameState = -1;

        /// <summary>
        /// Change GUI from Menu to Game
        /// Build Cave
        /// Place objects in cave
        /// Place player
        /// </summary>
        public void StartGame()
        {
            gameState = 1;
        }
        
        /// <summary>
        /// Display Victory Screen
        /// </summary>
        public void Victory()
        {
            //graphics: display victor screen

        }

        /// <summary>
        /// Display Lose Screen
        /// </summary>
        public void Defeat()
        {

        }

        /// <summary>
        /// Display Trivia Screen,
        /// Grab Trivia Questions,
        /// Prompt the player with x number of questions.
        /// </summary>
        public void Trivia(int numberOfQuestions)
        {
            // <called by gui>
            gameState = 2;
            // get trivia question
            // populate answers with trivia answers
        }

        /// <summary>
        /// User attempts to by an arrow.
        /// Checks to see if the player can afford it.
        /// </summary>
        public void BuyArrow()
        {
            // <called by gui>
            // check money, can player afford it?
            //      player.arrows++;
            //      printError(NORM, "Arrows pruchased successfully!")
            // else
            //      printError(NORM, "Player can't afford arrows, thanks obama");
            //      return;
        }

        /// <summary>
        /// Places the player in specified room
        /// </summary>
        /// <param name="room">room number</param>
        public void Move(EntType e, int room)
        {
            // <called by gui>
            // ask cave if rooms are connected
            //      give <EntType> new room number
            // else
            //      printError(BUG,"Rooms not connected");
            //      return
            // 
            //
        }
    }
}