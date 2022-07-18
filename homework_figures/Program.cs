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

    //        Console.WriteLine("Draw triangle using for loop and variable with spaces \n");

            for (string doubleAsterix = "**"; oneBlockOfTriangle.Length < 11; oneBlockOfTriangle = string.Concat(oneBlockOfTriangle, doubleAsterix))
            {
                string outputLine = string.Concat(emptySpace, oneBlockOfTriangle);
    //            Console.WriteLine(outputLine);
                if (emptySpace.Length > 1)
                {
                    int lastSumbolIndex = emptySpace.Length - 1; // find last sumbol index
                    emptySpace = emptySpace.Remove(lastSumbolIndex); // cut emptySpace 1 sumboll
                }
       
            }



            #endregion

            #region - SQUARE

            Console.WriteLine("Enter square side length:");
            int squareSideLength = Convert.ToInt32(Console.ReadLine()); // TODO: add validations
            string squareOneBlock = string.Empty;

            for (int i = 0; i < squareSideLength; i++)
            {
                squareOneBlock = string.Concat(squareOneBlock, "*" , " ");
            }

            for (int j = 0; j < squareSideLength; j++)
            {
                Console.WriteLine(squareOneBlock);
            }

            #endregion

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
