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
        public RotorSettings rotor1settings;
        public RotorSettings rotor2settings;
        public RotorSettings rotor3settings;

        Rotor _rotor1;
        public Rotor rotor1
        {
            get
            {
                if (_rotor1 == null)
                    _rotor1 = new Rotor(rotor1settings);
                return _rotor1;
            }
        }
        Rotor _rotor2;
        public Rotor rotor2
        {
            get
            {
                if (_rotor2 == null)
                    _rotor2 = new Rotor(rotor2settings);
                return _rotor2;
            }
        }
        Rotor _rotor3;
        public Rotor rotor3
        {
            get
            {
                if (_rotor3 == null)
                    _rotor3 = new Rotor(rotor3settings);
                return _rotor3;
            }
        }

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
