using System.Collections.Generic;
using UnityEngine;

namespace FallingSloth.Enigma
{
    [CreateAssetMenu(fileName = "rotor.asset", menuName = "New Rotor", order = 1)]
    public class Rotor : ScriptableObject
    {
        int _position;
        public int position
        {
            get => _position;
            protected set => _position = value;
        }

        public int turnoverPosition = 17;

        [Range(0, 25)]
        public int ringSetting = 0;

        public List<Chars> pairings;

        public delegate void RotorTurnoverDelegate();
        public RotorTurnoverDelegate turnoverAction;

        public void TurnRotor()
        {
            int oldPos = position;
            position = (position + 1) % 26;
            if (oldPos == turnoverPosition)
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
                int i = (int)input - position - ringSetting;
                while (i < 0)
                    i += 26;
                return (Chars)i;
            }
            else
            {
                return pairings[((int)input + position + ringSetting) % 26];
            }
        }
    }
}
