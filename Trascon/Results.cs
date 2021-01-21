using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trascon
{
    class Results
    {
        private int[] result;

        public Results() { }

        public int[] GetJumpArr(int _group)
        {
            switch (_group)
            {
                case 6:
                    result = new int[3] { 205, 220, 235 };
                    return result;
                case 7:
                    result = new int[3] { 185, 200, 215 };
                    return result;
                case 8:
                    result = new int[3] { 150, 165, 180 };
                    return result;
                case 9:
                    result = new int[3] { 135, 150, 165 };
                    return result;
                case 10:
                    result = new int[3] { 120, 135, 150 };
                    return result;
                case 11:
                    result = new int[3] { 105, 120, 135 };
                    return result;
            }
            return result;
        }

        public int[] GetFlexArr(int _group)
        {
            switch (_group)
            {
                case 6:
                    result = new int[3] { 5, 7, 12 };
                    return result;
                case 7:
                    result = new int[3] { 2, 4, 10 };
                    return result;
                case 8:
                    result = new int[3] { -2, 0, 4 };
                    return result;
                case 9:
                    result = new int[3] { -6, -4, -2 };
                    return result;
                case 10:
                    result = new int[3] { -10, -8, -6 };
                    return result;
                case 11:
                    result = new int[3] { -12, -10, -8 };
                    return result;
            }
            return result;
        }

        public int[] GetPushArr(int _group)
        {
            switch (_group)
            {
                case 6:
                    result = new int[3] { 22, 25, 39 };
                    return result;
                case 7:
                    result = new int[3] { 13, 17, 29 };
                    return result;
                case 8:
                    result = new int[3] { 8, 12, 22 };
                    return result;
                case 9:
                    result = new int[3] { 4, 8, 14 };
                    return result;
                case 10:
                    result = new int[3] { 2, 4, 6 };
                    return result;
                case 11:
                    result = new int[3] { 1, 3, 5 };
                    return result;
            }
            return result;
        }
    }    
}

