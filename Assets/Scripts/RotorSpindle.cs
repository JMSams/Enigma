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

        public Rotor reflector;

        public Chars Encode(Chars input)
        {
            if (rotor2.position == rotor2.turnoverPosition)
                rotor3.position++;

            if (rotor1.position == rotor1.turnoverPosition)
                rotor2.position++;

            rotor1.position++;

            Chars round1 = rotor3.Encode(rotor2.Encode(rotor1.Encode(input)));
            Chars reflected = reflector.Encode(round1);
            Chars round2 = rotor1.Reverse(rotor2.Reverse(rotor3.Reverse(reflected)));
            return round2;
        }
    }
}
