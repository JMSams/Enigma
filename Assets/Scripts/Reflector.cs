using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace FallingSloth.Enigma
{
    [CreateAssetMenu(fileName = "reflector.asset", menuName = "New Reflector", order = 2)]
    public class Reflector : ScriptableObject
    {
        public List<CharacterPairing> pairings;

        public Chars Reflect(Chars input)
        {
            foreach (CharacterPairing pair in pairings)
            {
                if (pair.char1 == input)
                    return pair.char2;
                else if (pair.char2 == input)
                    return pair.char1;
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
