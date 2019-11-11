using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallingSloth.Enigma
{
    public class Rotor
    {
        public Rotor(RotorSettings settings)
        {
            this.position = settings.startPosition;
            this.settings = settings;
        }

        int _position;
        public int position
        {
            get => _position;
            protected set => _position = value;
        }

        RotorSettings settings;

        public delegate void RotorTurnoverDelegate();
        public RotorTurnoverDelegate turnoverAction;

        public void TurnRotor()
        {
            int oldPos = position;
            position = (position + 1) % 26;
            if (oldPos == settings.turnoverPosition)
                turnoverAction();
        }

        public Chars Encode(Chars input)
        {
            return Encode(input, false);
        }
        public Chars Encode(Chars input, bool reverse)
        {
            if (reverse)
            {
                int i = (int)input - position - settings.ringSetting;
                while (i < 0)
                    i += 26;
                return (Chars)i;
            }
            else
            {
                return settings.pairings[((int)input + position + settings.ringSetting) % 26];
            }
        }
    }
}
