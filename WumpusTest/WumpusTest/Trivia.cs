using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestTrivia
{
    /// <summary>
    /// returns whether user has passed trivia or not
    /// and sends trivia meant for displayal for every player move (for the GUI)
    /// </summary>
    public class Trivia
    {
        // instance variables
        private int correct;
        private int numQuestions;
        bool result;
        string[] questions = System.IO.File.ReadAllLines(@"C:\Users\Amanda\Skydrive\CS\WumpusTest\bin\Debug\TriviaQuestions.txt");
        string[] fact = System.IO.File.ReadAllLines(@"C:\User\Amanda\Skydrive\CS\WumpusTest\bin\Debug\TriviaFacts.txt");
        
        // constructors

        /// <summary>
        /// True means player has succeeded the test, false means the player lost
        /// </summary>
        /// <returns></returns>
        public Trivia(int numberOfQuestions)
        {
            result = false;
            correct = 0;
            numQuestions = numberOfQuestions;

            if (numQuestions == 2)
            {
                result = twoOfThree();
            }
            else if (numQuestions == 3)
            {
                result = threeOfFive();
            }
        }
        
        // accessors and mutators
        /// <summary>
        /// Will return a question given a number. There are currently 11 questions.
        /// </summary>
        /// <returns></returns>
        public string getQuestion(int number)
        {
            return questions[number * 4];
        }
        /// <summary>
        /// Returns the correct answer to the question number. There are currently 11 questions.
        /// </summary>
        /// <returns></returns>
        public string getCorrectAnswer(int number){
            return questions[number * 4 + 1];
        }

        /// <summary>
        /// Returns the 2nd potential answer to the question number. There are currently 11 questions.
        /// </summary>
        /// <returns></returns>
        public string getSecondAnswer(int number)
        {
            return questions[number * 4 + 2];
        }

        /// <summary>
        /// Returns the correct answer to the question number. There are currently 11 questions.
        /// </summary>
        /// <returns></returns>
        public string getThirdAnswer(int number)
        {
            return questions[number * 4 + 3];
        }

        /// <summary>
        /// Returns a fact for display whenever the player moves
        /// </summary>
        /// <returns></returns>
        public string getFact()
        {
            int number = Random.nextInt(11) + 1;
            return fact[number];
        }
        /// <summary>
        /// True means a win, false means the player lost
        /// </summary>
        /// <returns></returns>
        public bool getResult()
        {
            return result;
        }
    }
}
