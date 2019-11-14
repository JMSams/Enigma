using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingSloth.Enigma
{
    public class Reflector
    {
        int[][] chars = new int[][] { new int[] { 0, 4 }, new int[] { 1, 9 }, new int[] { 2, 12 }, new int[] { 3, 25 }, new int[] { 4, 0 }, new int[] { 5, 11 }, new int[] { 6, 24 }, new int[] { 7, 23 }, new int[] { 8, 21 }, new int[] { 9, 1 }, new int[] { 10, 22 }, new int[] { 11, 5 }, new int[] { 12, 2 }, new int[] { 13, 17 }, new int[] { 14, 16 }, new int[] { 15, 20 }, new int[] { 16, 14 }, new int[] { 17, 13 }, new int[] { 18, 19 }, new int[] { 19, 18 }, new int[] { 20, 15 }, new int[] { 21, 8 }, new int[] { 22, 10 }, new int[] { 23, 7 }, new int[] { 24, 6 }, new int[] { 25, 3 } };

        public int Encode(int input, bool reverse = false)
        {
            return chars[input][(reverse) ? 0 : 1];
        }
    }
}
