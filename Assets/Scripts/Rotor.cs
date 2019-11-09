using System.Collections.Generic;
using UnityEngine;

namespace FallingSloth.Enigma
{
    [CreateAssetMenu(fileName = "rotor.asset", menuName = "New Rotor")]
    public class Rotor : ScriptableObject
    {
        int _position;

        public int turnoverPosition = 17;

        public List<CharacterPairing> pairings;

        public Chars Encode(Chars input)
        {
            foreach (CharacterPairing pair in pairings)
            {
                if (pair.char1 == input)
                    return pair.char2;
            }
            throw new System.Exception(string.Format("Character not found on rotor ({0}).", input));
        }
    }
}
