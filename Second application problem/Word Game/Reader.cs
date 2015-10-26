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
        public string PrintArray()
        {
            return "e";
        }
    }
}

