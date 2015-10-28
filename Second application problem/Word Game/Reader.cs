using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class Reader
    {
        public int[,] startingPosition = new int[1, 1];
        public int counter = 0;
        public Reader(int counter)
        {
            this.counter = counter;
        }

        public static char[,] results = new char[4, 5];
        public static char[,] ReadCharsFromFile()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("names.txt"))
                {
                    string line = "";
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    do
                    {

                        for (int y = 0; y < 5; y++)//y rows
                        {
                            line = sr.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            for (int x = 0; x < 4; x++)//x columns
                            {
                                results[x, y] = line[x];
                            }
                        }
                    } while (line != null);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return results;
        }
        public void SearchWord(char[,] input, string name)
        {
            //1. loop through the array and look for the first letter of the string
            //2. if found search in all directions "iterative"
            //3. if one direction doesn't find it break out of the mathod and continue to search
            //4. if found mark the positions so you don't find the same word more than once
            char firstLetter = name[0];

            //go look for it in the 2d array
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (results[x, y] == firstLetter)//found the letter
                    {
                        Console.WriteLine("Found it " +" "+ firstLetter);
                        SearchRightDirection(results, x, y);
                    }
                }
            }
            //if you found the second letter, look only one step at a time in the same direction

            //if found start searching in all possible directionsif (i >= width ||
        }

        public bool SearchRightDirection(char [,] matrix, int x, int y)
        {
            
            for (int columns = 0; columns < matrix.Length; columns++)
            {
                for (int rows = 0; rows < length; rows++)
                {

                }
            }
            return false;
        }
    }
}


