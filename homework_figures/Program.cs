using System;

namespace homework_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - triangle 1st variant

        
            string oneBlockOfTriangle = "";
            for (string asterix = "*"; oneBlockOfTriangle.Length < 10; oneBlockOfTriangle = string.Concat(oneBlockOfTriangle, asterix))
            {
                Console.WriteLine(oneBlockOfTriangle);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
