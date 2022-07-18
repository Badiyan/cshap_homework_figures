using System;

namespace homework_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - triangle 1st variant

            string oneBlockOfTriangle = "*";
            string emptySpace = "           "; // empty triangle sides spaces

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

            Console.ReadKey();

            #endregion

        }
    }
}
