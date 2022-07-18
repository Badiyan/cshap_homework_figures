using System;

namespace homework_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - TRIANGLE

            string oneBlockOfTriangle = "*";
            string emptySpace = "           "; // empty triangle sides spaces

            Console.WriteLine("Draw triangle using for loop and variable with spaces \n");

            for (string doubleAsterix = "**"; oneBlockOfTriangle.Length < 11; oneBlockOfTriangle = string.Concat(oneBlockOfTriangle, doubleAsterix))
            {
                string outputLine = string.Concat(emptySpace, oneBlockOfTriangle);
                Console.WriteLine(outputLine);
                if (emptySpace.Length > 1)
                {
                    int lastSumbolIndex = emptySpace.Length - 1; // find last sumbol index
                    emptySpace = emptySpace.Remove(lastSumbolIndex); // cut emptySpace 1 sumboll
                }
       
            }

            #endregion

            #region - SQUARE

            Console.WriteLine("\n Drawing SQUARE with given side length");
            Console.WriteLine("\n Enter square side length:");
            int squareSideLength = Convert.ToInt32(Console.ReadLine()); // TODO: add validations
            string squareBlock = string.Empty;

            for (int i = 0; i < squareSideLength; i++)
            {
                for (int j = 0; j < squareSideLength; j++)
                {
                    squareBlock = string.Concat(squareBlock, "*", " "); // create 1 line of the square 
                }

                squareBlock = string.Concat(squareBlock, "\n"); // dublicate line n times ; n = side lenght

            }

            Console.WriteLine(squareBlock);

            #endregion

            #region - SQUARE without filling

            Console.WriteLine("\n Drawing SQUARE with given side length / without filling");
            Console.WriteLine("\n Enter square side length:");
            int squareWithoutFillSideLength = Convert.ToInt32(Console.ReadLine()); // TODO: add validations
            string squareWithoutFillBlock = string.Empty;

            for (int j = 0; j < squareWithoutFillSideLength; j++)
            {
                squareWithoutFillBlock = string.Concat(squareWithoutFillBlock, "*", " "); // create 1 line of the square 
            }

            for (int i = 0; i < squareWithoutFillSideLength; i++)
            {
                if (i == 0 | i == squareWithoutFillSideLength - 1 )
                {
                    Console.WriteLine(squareWithoutFillBlock, "\n");
                }
                else 
                {
                    Console.WriteLine(string.Concat("*", squareWithoutFillBlock.Remove(squareWithoutFillBlock.Length - 3).Replace("*"," "), "*"));
                }

            }

            

            #endregion

            #region - CIRCLE



            #endregion

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
