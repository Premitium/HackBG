using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    class Reader
    {
        static int[,] startingPosition = new int[1, 1];
        public int counter = 0;
        public Reader(int counter)
        {
            this.counter = counter;
        }

        char[,] results = new char[4, 5];
        public char[,] ReadCharsFromFile()
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
        public void SearchWord(string name, int i, int a, int width,
                                int height, string build, int direction)
        {
            char firstLetter;
            //look out for the "walls"
            if (i >= 4 || i < 0 || a >= 5 || a < 0)
            {
                return;
            }
            //if you find the first letter look in all possible directions, one step
            //now pick the first letter from the string
            for (int z = 0; z < name.Length; z++)
            {
                firstLetter = name[z];
                //go look for it in the 2d array
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 4; x++)
                    {
                        if (results[x, y] == firstLetter)
                        {
                            startingPosition[x, y] = results[x, y];
                        }
                    }
                }

                //if you found the second letter, look only one step at a time in the same direction

                //if found start searching in all possible directionsif (i >= width ||

            }
        }
    }
}


