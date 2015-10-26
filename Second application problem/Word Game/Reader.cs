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
        int[][] results = new int[10][];
        public int[][] ReadCharsFromFile()
        {
            int rowCount = 0;
            int colCount = 0;
            char c;
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("names.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == null)
                        {
                            break;
                        }
                        //Add characters to 2D array
                        int rowCount = results["row_count"];
                        int columnCount = counts["column_count"];

                    }
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
    }
}

