using System.Collections.Generic;
using UnityEngine;

namespace FallingSloth.Enigma
{
    [CreateAssetMenu(fileName = "rotor.asset", menuName = "New Rotor", order = 1)]
    public class RotorSettings : ScriptableObject
    {
        public int startPosition = 0;

        public int turnoverPosition = 17;

        [Range(0, 25)]
        public int ringSetting = 0;

        public List<Chars> pairings;
    }
}
