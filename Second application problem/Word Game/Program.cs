using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            int counter = 0;
            Reader ReaderFunc = new Reader(counter);

            char[,] twoDResult = ReaderFunc.ReadCharsFromFile();
            ReaderFunc.SearchWord("ivan");
            Console.Write(twoDResult[0, 0]);
            Console.Write(twoDResult[1, 0]);
            Console.Write(twoDResult[2, 0]);
            Console.Write(twoDResult[3, 0]);
            Console.WriteLine();
            Console.Write(twoDResult[0, 1]);
            Console.Write(twoDResult[1, 1]);
            Console.Write(twoDResult[2, 1]);
            Console.Write(twoDResult[3, 1]);
            Console.WriteLine();

        }
    }
}
