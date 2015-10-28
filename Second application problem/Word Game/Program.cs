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
        public static Reader ReaderFunc = new Reader(counter);//the counter will count the occurences of the word in the matrix
        public static string name = "ivan";
        static void Main(string[] args)
        {
            char[,] twoDResult = ReaderFunc.ReadCharsFromFile();
            ReaderFunc.SearchWord(twoDResult, name);
        }
    }
}
