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
            rotor1.TurnRotor();
            return rotor3.Encode(rotor2.Encode(rotor1.Encode(input)));
        }
    }
}
