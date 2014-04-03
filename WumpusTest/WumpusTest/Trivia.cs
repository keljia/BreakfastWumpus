using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FormTest
{
    public class Trivia
    {
        // instance variables
        private int correct;
        private int numQuestions;
        bool result;
        string[] questions = System.IO.File.ReadAllLines(@".\TriviaText\TriviaQuestions.txt");
        string[] fact = System.IO.File.ReadAllLines(@".\TriviaText\TriviaFacts.txt");
        // constructors
        public Trivia(int numberOfQuestions)
        {
            result = false;
            correct = 0;
            numQuestions = numberOfQuestions;
            
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
        public string getCorrectAnswer(int number)
        {
            return questions[number * 4 + 1];
        }

        /// <summary>
        /// Returns the any answer to the question number. There are currently 11 questions.
        /// </summary>
        /// <returns></returns>
        public string getAnswer(int number)
        {
            Random gen = new Random();
            int rand = gen.Next(3) + 1;
            return questions[number * 4 + rand];
        }

        /// <summary>
        /// Returns a fact for display whenever the player moves
        /// </summary>
        /// <returns></returns>
        public string getFact()
        {
            Random rnd = new Random();
            int number = rnd.Next(11) + 1;
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
