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
            Reader ReaderFunc = new Reader();

            char[,] twoDResult = ReaderFunc.ReadCharsFromFile();
            Console.WriteLine(twoDResult[0, 0]);
            Console.WriteLine(twoDResult[0, 2]);
            Console.WriteLine(twoDResult[0, 3]);
            Console.WriteLine(twoDResult[0, 4]);

        }
    }
}
