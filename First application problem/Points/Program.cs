using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Pick two points");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int[] arr = { x, y };
            Directions Direction = new Directions(x, y, arr);
            Console.WriteLine("Enter directions");
            string directions = Console.ReadLine();

            int[] resultArr = Direction.ReactOnWarp(directions);
           
            Console.Write(resultArr[0] + ", "+ resultArr[1]);
        }
    }
}
