using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{

    class Directions
    {
        private int x;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int y;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int[] initialPosition = new int[2];

        public Directions(int firstParam, int secondParam, int[] arr)
        {
            this.x = firstParam;
            this.y = secondParam;
            this.initialPosition = arr;
        }
        public void AddToArray()
        {
            initialPosition[0] = X;
            initialPosition[1] = Y;
        }
        public int[] ReactOnWarp(string inputSymbolString)
        {
            char[] test = inputSymbolString.ToCharArray();
            bool changeDirection = false;

            for (int i = 0; i <= test.Length-1; i++)
            {
                if (test[i] == '~')
                {
                    //swap
                    changeDirection = !changeDirection;
                }
                if (changeDirection)
                {
                    MoveInverse(test[i]);
                    AddToArray();
                }
                else
                {
                    MoveNormal(test[i]);
                    AddToArray();
                }
            }
            return initialPosition;
        }

        public void MoveNormal(char symbol)
        {
            switch (symbol)
            {
                //'>>><<<~>>>~^^^'
                case '>':
                    X++;
                    break;
                case '<':
                    X--;
                    break;
                case 'v':
                    Y++;
                    break;
                case '^':
                    Y--;
                    break;
            }
        }
        public void MoveInverse(char symbol)
        {
            switch (symbol)
            {
                //'>>><<<~>>>~^^^'
                case '<':
                    X++;
                    break;
                case '>':
                    X--;
                    break;
                case 'v':
                    Y--;
                    break;
                case '^':
                    Y++;
                    break;

            }
        }
    }
}
