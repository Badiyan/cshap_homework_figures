using System;

namespace homework_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor currentForeground = Console.ForegroundColor; // save default console color

            #region - TRIANGLE

//            int triangleHeight = 20;

            Console.WriteLine("Draw triangle using for loop and variable with spaces \n \n Enter triangle heigth:\n");
   
            int triangleHeight = Convert.ToInt16(Console.ReadLine()); // TODO: add validations
            string oneBlockOfTriangle = "*";
            string emptySpace = new String(' ', triangleHeight);

            Console.ForegroundColor = ConsoleColor.Red;

            for (string doubleAsterix = "**"; oneBlockOfTriangle.Length < (triangleHeight * 2) ; oneBlockOfTriangle = string.Concat(oneBlockOfTriangle, doubleAsterix))
            {
                string outputLine = string.Concat(emptySpace, oneBlockOfTriangle);
                Console.WriteLine(outputLine);
                if (emptySpace.Length > 1)
                {
                    int lastSumbolIndex = emptySpace.Length - 1; // find last sumbol index
                    emptySpace = emptySpace.Remove(lastSumbolIndex); // cut emptySpace 1 sumboll
                }
       
            }

            Console.ForegroundColor = currentForeground;
            Console.Write("\n Press <Enter> for next figure... \n ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            #endregion

            #region - SQUARE

            Console.ForegroundColor = currentForeground; // return default color
            Console.WriteLine("\n Drawing SQUARE with given side length \n Enter square side length:\n");

            int squareSideLength = Convert.ToInt32(Console.ReadLine()); // TODO: add validations
            string squareBlock = string.Empty;

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;

            for (int i = 0; i < squareSideLength; i++)
            {
                for (int j = 0; j < squareSideLength; j++)
                {
                    squareBlock = string.Concat(squareBlock, "*", " "); // create 1 line of the square 
                }

                squareBlock = string.Concat(squareBlock, "\n"); // dublicate line n times ; n = side lenght

            }

            Console.WriteLine(squareBlock + "\n");
            Console.ForegroundColor = currentForeground;
            Console.Write("Press <Enter> for next figure .... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            #endregion

            #region - SQUARE without filling

            Console.WriteLine("\n Drawing SQUARE with given side length / without filling\n Enter square side length:");
 
            int squareWithoutFillSideLength = Convert.ToInt32(Console.ReadLine()); // TODO: add validations
            string squareWithoutFillBlock = string.Empty;
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;

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

            Console.WriteLine("\n");
            Console.ForegroundColor = currentForeground;  // return default color
            Console.Write("Press <Enter> for next figure... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            #endregion

            #region - CIRCLE

            Console.WriteLine("\n Drawing CIRCLE ! \n");
            Console.Write("Press <Enter> for CIRCLE... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
            int width = 120;
            int height = 30;
            float aspect = (float)width / height;
            string[] elements = new string[width * height + 1];
            elements[width * height] = "\n";
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {   
                    float x = (float)i / width * 2.0f - 1.0f;
                    float y = (float)j / height * 2.0f - 1.0f;
                    x *= aspect/2;  
                    string element = " ";
                    if (x * x + y * y < 0.5)
                    { 
                        element = "*"; 
                    }
                    elements[i + j * width] = element;
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{string.Join("", elements)}");
            Console.ForegroundColor = currentForeground;  // return default color

            #endregion


            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}
