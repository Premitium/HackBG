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
            ReaderFunc.ReadFile();
        }
    }
}
