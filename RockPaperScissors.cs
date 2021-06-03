using System;

namespace RockPaperScissors
{
    class Program
    {

        static string[] objects = { "rock", "paper", "scissors", "spock", "lizard" };

        static int[,] rules = { { 0, 0, 1, 0, 1 },
                                { 1, 0, 0, 1, 0 },
                                { 0, 1, 0, 0, 1 },
                                { 1, 0, 1, 0, 0 },
                                { 0, 1, 0, 1, 0 }, };

        static void Main() // main
        {
            Console.Write("Type the name of the object you pick [all lowercase], default is scissors: ");
            string yourMove = Console.ReadLine();
            string compMove = CompMove();
            Console.WriteLine($"The comp's move: {compMove}");

            if (Array.IndexOf(objects, yourMove) == -1)
            {
                yourMove = "scissors"; // default is scissors if anything other than objects is passed
            }

            Console.WriteLine(Evaluate(yourMove, compMove));

            Console.ReadLine();
        }

        static string CompMove() // computer's move
        {
            /* Returns one of the 5 objects with equal probability */
            Random rand = new Random();

            int randNum = rand.Next(0, 5);
            string randObj = objects[randNum];

            return randObj;
        }

        static string Evaluate(string yourMove, string compMove) // method for determining winner
        {
            /* Returns "You win!" if you won the round,
             * "Tie!" if you showed the same as comp, else "Comp wins!" */
            int yourMoveNum = Array.IndexOf(objects, yourMove);
            int compMoveNum = Array.IndexOf(objects, compMove);

            if (yourMove == compMove)
            {
                return "Tie!";
            }
            else if (rules[yourMoveNum, compMoveNum] == 1)
            {
                return "You win!";
            }
            else
            {
                return "Comp wins!";
            }


        }
    }
}
