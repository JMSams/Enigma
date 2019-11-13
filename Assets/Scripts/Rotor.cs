using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FallingSloth.Enigma
{
    public class Rotor
    {
        int[][] chars;
        int turnoverPoint;
        
        public int position { get; protected set; }

        protected Rotor() { }

        public void SetPosition(int position)
        {
            this.position = position;
        }
        
        public void Encode(int input, bool reverse = false)
        {

        }

        public static Rotor Rotor_I => new Rotor { turnoverPoint = 16, chars = new int[][] { new int[] { 0, 4 }, new int[] { 1, 10 }, new int[] { 2, 12 }, new int[] { 3, 5 }, new int[] { 4, 11 }, new int[] { 5, 6 }, new int[] { 6, 3 }, new int[] { 7, 16 }, new int[] { 8, 21 }, new int[] { 9, 25 }, new int[] { 10, 13 }, new int[] { 11, 19 }, new int[] { 12, 14 }, new int[] { 13, 22 }, new int[] { 14, 24 }, new int[] { 15, 7 }, new int[] { 16, 23 }, new int[] { 17, 20 }, new int[] { 18, 18 }, new int[] { 19, 15 }, new int[] { 20, 0 }, new int[] { 21, 8 }, new int[] { 22, 1 }, new int[] { 23, 17 }, new int[] { 24, 2 }, new int[] { 25, 9 } } };
        public static Rotor Rotor_II => new Rotor { turnoverPoint = 4, chars = new int[][] { new int[] { 0, 0 }, new int[] { 1, 9 }, new int[] { 2, 3 }, new int[] { 3, 10 }, new int[] { 4, 18 }, new int[] { 5, 8 }, new int[] { 6, 17 }, new int[] { 7, 20 }, new int[] { 8, 23 }, new int[] { 9, 1 }, new int[] { 10, 11 }, new int[] { 11, 7 }, new int[] { 12, 22 }, new int[] { 13, 19 }, new int[] { 14, 12 }, new int[] { 15, 2 }, new int[] { 16, 16 }, new int[] { 17, 6 }, new int[] { 18, 25 }, new int[] { 19, 13 }, new int[] { 20, 15 }, new int[] { 21, 24 }, new int[] { 22, 5 }, new int[] { 23, 21 }, new int[] { 24, 14 }, new int[] { 25, 4 } } };
        public static Rotor Rotor_III => new Rotor { turnoverPoint = 21, chars = new int[][] { new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { 2, 5 }, new int[] { 3, 7 }, new int[] { 4, 9 }, new int[] { 5, 11 }, new int[] { 6, 2 }, new int[] { 7, 15 }, new int[] { 8, 17 }, new int[] { 9, 19 }, new int[] { 10, 23 }, new int[] { 11, 21 }, new int[] { 12, 25 }, new int[] { 13, 13 }, new int[] { 14, 24 }, new int[] { 15, 4 }, new int[] { 16, 8 }, new int[] { 17, 22 }, new int[] { 18, 6 }, new int[] { 19, 0 }, new int[] { 20, 10 }, new int[] { 21, 12 }, new int[] { 22, 20 }, new int[] { 23, 18 }, new int[] { 24, 16 }, new int[] { 25, 14 } } };
        public static Rotor Rotor_IV => new Rotor { turnoverPoint = 9, chars = new int[][] { new int[] { 0, 4 }, new int[] { 1, 18 }, new int[] { 2, 14 }, new int[] { 3, 21 }, new int[] { 4, 15 }, new int[] { 5, 25 }, new int[] { 6, 9 }, new int[] { 7, 0 }, new int[] { 8, 24 }, new int[] { 9, 16 }, new int[] { 10, 20 }, new int[] { 11, 8 }, new int[] { 12, 17 }, new int[] { 13, 7 }, new int[] { 14, 23 }, new int[] { 15, 11 }, new int[] { 16, 13 }, new int[] { 17, 5 }, new int[] { 18, 19 }, new int[] { 19, 6 }, new int[] { 20, 10 }, new int[] { 21, 3 }, new int[] { 22, 2 }, new int[] { 23, 12 }, new int[] { 24, 22 }, new int[] { 25, 1 } } };
        public static Rotor Rotor_V => new Rotor { turnoverPoint = 25, chars = new int[][] { new int[] { 0, 21 }, new int[] { 1, 25 }, new int[] { 2, 1 }, new int[] { 3, 17 }, new int[] { 4, 6 }, new int[] { 5, 8 }, new int[] { 6, 19 }, new int[] { 7, 24 }, new int[] { 8, 20 }, new int[] { 9, 15 }, new int[] { 10, 18 }, new int[] { 11, 3 }, new int[] { 12, 13 }, new int[] { 13, 7 }, new int[] { 14, 11 }, new int[] { 15, 23 }, new int[] { 16, 0 }, new int[] { 17, 22 }, new int[] { 18, 12 }, new int[] { 19, 9 }, new int[] { 20, 16 }, new int[] { 21, 14 }, new int[] { 22, 5 }, new int[] { 23, 4 }, new int[] { 24, 2 }, new int[] { 25, 10 } } };
    }
}