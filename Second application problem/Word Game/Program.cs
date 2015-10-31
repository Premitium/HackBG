using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    public class Program
    {
        public static int counter = 0;
        public static string name = "ivan";

        static void Main(string[] args)
        {
            Reader ReaderFunc = new Reader();//the counter will count the occurences of the word in the matrix

            char[,] twoDResult = ReaderFunc.ReadCharsFromFile();
            Console.WriteLine(CountOccurrences(twoDResult, name));
        }
        public static int CountOccurrences(char[,] table, string word)
        {
            //Always ceck if the string is empty.
            //The table is checked if empty in the reader method
            if (string.IsNullOrEmpty(word)) return 0;
            int count = 0;
            //count rows and columns.
            int rowCount = table.GetLength(0);
            int colCount = table.GetLength(1);
            //traverse the matrix
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    //look for the first letter of the string and if found jump over the next iteration
                    if (table[row, col] != word[0])
                    {
                        continue;
                    }
                    if (word.Length == 1)
                    {
                        count++;
                        continue;
                    }
                    //go in all 8 diretions
                    for (int directionY = -1; directionY <= 1; directionY++)
                    {
                        for (int directionX = -1; directionX <= 1; directionX++)
                        {       //if both zero there is no direction
                            if ((directionX != 0 || directionY != 0) && Match(word, table, rowCount, colCount, row, col, directionY, directionX))
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            return count;
        }
        private static bool Match(string word, char[,] table, int rowCount, int colCount, int startRow, int startCol, int directionY, int directionX)
        {
            int row = startRow + directionY;
            int storeDirectionY = directionY;
          
            if (directionY < 0)
            {
                storeDirectionY = row;
            }
            else
            {
                storeDirectionY = rowCount - row;
            }

            if (directionY != 0 && storeDirectionY < word.Length - 1)
            {
                return false;
            }
            //copy logic for horizontal search
            int storeDirectionX = directionX;
            int col = startCol + directionX;
           
            if (directionX < 0)
            {
                storeDirectionX = col;
            }
            else
            {
                storeDirectionX = colCount - col;
            }

            if (directionX != 0 && storeDirectionX < word.Length - 1)
            {
                return false;
            }

            for (int charPos = 1; charPos < word.Length; row += directionY, col += directionX, charPos++)
            {
                if (table[row, col] != word[charPos])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
