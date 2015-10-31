using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    class Test
    {
        public static class Sample
        {
            public static int CountOccurrences(char[,] table, string word)
            {
                if (string.IsNullOrEmpty(word)) return 0;
                int count = 0;
                int rowCount = table.GetLength(0);
                int colCount = table.GetLength(1);
                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        if (table[row, col] != word[0]) continue;
                        if (word.Length == 1) { count++; continue; }
                        for (int dy = -1; dy <= 1; dy++)
                            for (int dx = -1; dx <= 1; dx++)
                                if ((dx != 0 || dy != 0) && Match(word, table, rowCount, colCount, row, col, dy, dx)) count++;
                    }
                }
                return count;
            }
            private static bool Match(string word, char[,] table, int rowCount, int colCount, int startRow, int startCol, int dy, int dx)
            {
                int row = startRow + dy;
                if (dy != 0 && (dy < 0 ? row : rowCount - row) < word.Length - 1) return false;
                int col = startCol + dx;
                if (dx != 0 && (dx < 0 ? col : colCount - col) < word.Length - 1) return false;
                for (int charPos = 1; charPos < word.Length; row += dy, col += dx, charPos++)
                    if (table[row, col] != word[charPos]) return false;
                return true;
            }
        }
    }
}
