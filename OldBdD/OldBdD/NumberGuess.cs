using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OldBdD
{
    class NumberGuess
    {
        /* Method for self-testing (manual version) */
        public static void StartGuess()
        {
            int low = 0;
            int high = Program.MAX_VALUE;
            String answer = String.Empty;
            while (low < high)
            {
                int middle = (int) Math.Floor((double) ((low + high) / 2));
                Console.WriteLine("Is this number bigger than {0}?", middle);
                answer = Console.ReadLine();
                numberOfQuestions++;
                switch (answer)
                {
                    case "Yes":
                        if (middle >= low)
                            low = middle + 1;
                        else
                        {
                            Console.WriteLine("Don\'t mess with me...");
                            break;
                        }
                        break;
                    case "No":
                        if (middle <= high)
                            high = middle;
                        else
                        {
                            Console.WriteLine("Don\'t mess with me...");
                            break;
                        }
                        break;
                    default:
                        answer = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Your number is {0}! I guess it in {1} questions.", high, numberOfQuestions);
        }
        
        /* Method for auto-testing */
        public static int StartGuess(int userNumber)
        {
            int low = 0;
            int high = Program.MAX_VALUE;
            String answer = String.Empty;
            while (low < high)
            {
                int middle = (int)Math.Floor(((low + high) / 2.0));
                if (middle < userNumber)
                    answer = "Yes";
                else
                    answer = "No";
                switch (answer)
                {
                    case "Yes":
                        if (middle >= low)
                            low = middle + 1;
                        else
                        {
                            Console.WriteLine("Don\'t mess with me...");
                            break;
                        }
                        break;
                    case "No":
                        if (middle <= high)
                            high = middle;
                        else
                        {
                            Console.WriteLine("Don\'t mess with me...");
                            break;
                        }
                        break;
                    default:
                        answer = Console.ReadLine();
                        break;
                }
            }
                return high;
        }

        public static void ConsoleUserOpportunities()
        {
            Console.WriteLine("Guess a number and press any key.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Answer the questions in format \"Yes\" or \"No\".");
            StartGuess();
        }

        public static int numberOfQuestions;
    }

    /* Special class for performing WinForms
        WolF derived from WF derived from WinForms =) */
    class NumberGuessWolF
    {
        public static int StartGuess(bool answer)
        {
            if (answer)
                low = middle + 1;
            else
                high = middle;
            middle = (int) Math.Floor((double) ((low + high) / 2));
            numberOfQuestions++;
            return middle;
        }

        public static int low = 0;
        public static int high = Program.MAX_VALUE;
        public static int middle = (int)Math.Floor((double)((low + high) / 2));
        public static int numberOfQuestions = 0;
    }
}