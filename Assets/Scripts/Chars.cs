using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingSloth.Enigma
{
    public enum Chars
    {
        _ = 0,
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z
    }

    [Serializable]
    public struct CharacterPairing
    {
        public Chars char1;
        public Chars char2;

        public CharacterPairing(Chars char1, Chars char2)
        {
            this.char1 = char1;
            this.char2 = char2;
        }

        public static bool Equals(CharacterPairing pair1, CharacterPairing pair2)
        {
            if (pair1.char1 == pair2.char1 && pair1.char2 == pair2.char2)
                return true;
            else if (pair1.char1 == pair2.char2 && pair1.char2 == pair2.char1)
                return true;
            else
                return false;
        }
    }
}
