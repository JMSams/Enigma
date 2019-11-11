using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingSloth.Enigma
{
    [Serializable]
    public class RotorSpindle
    {
        public Rotor rotor1;
        public Rotor rotor2;
        public Rotor rotor3;

        public Chars Encode(Chars input)
        {
            return Encode(input, false);
        }
        public Chars Encode(Chars input, bool reverse)
        {
            if (reverse)
            {
                return rotor1.Encode(rotor2.Encode(rotor3.Encode(input, true), true), true);
            }
            else
            {
                rotor1.TurnRotor();
                return rotor3.Encode(rotor2.Encode(rotor1.Encode(input)));
            }
        }
    }
}
