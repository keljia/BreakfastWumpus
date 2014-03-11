using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WumpusTest
{
    /// <summary>
    /// returns whether user has passed trivia or not
    /// and sends trivia meant for displayal for every player move (for the GUI)
    /// </summary>
    
    class Trivia
    {
        // instance variables
        private int correct;
        private int numQuestions;
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Public\TestFolder\WriteLines2.txt");
        Random gen; 
        
        // constructors
        public Trivia(int numberOfQuestions)
        {
            correct = 0;
            numQuestions = numberOfQuestions;
        }
        
        // accessors
        
        // methods        
        

        /// <summary> 
        /// Used when the player has encountered the 
        /// wumpus (3 out of 5 questions). After
        /// completion, will return to the main game
        /// </summary>
        
        
        public bool threeOfFive(){
            return true;
        }
        
        /// <summary>
        /// falls into pit or encounters bats or purchasing 
        /// secret or purchasing arrows, 2 out of 3
        /// After completion, will return to the main game
        /// </summary>
        public bool twoOfThree(){
            return true;
        }
        
        /// <summary>
        /// trivia facts that are to be displayed
        /// every time the player moves
        /// <param name= "move"></param>
        /// </summary>
        public String triviaDisplay(GameControl move){
            // if player move = true, then send trivia to game control for GUI
            string str = "";
            return str;
        }
    }
}
