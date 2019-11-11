using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace FallingSloth.Enigma
{
    public class Enigma : MonoBehaviour
    {
        public Dictionary<Chars, Lamp> lamps;
        
        Chars currentKey = Chars._;
        Chars currentLamp = Chars._;

        public RotorSpindle spindle;
        public Reflector reflector;

        StringBuilder output = new StringBuilder();
        public TMPro.TextMeshProUGUI outputField;

        void Awake()
        {
            lamps = new Dictionary<Chars, Lamp>();
            
            spindle.rotor1.turnoverAction = () => { spindle.rotor2.TurnRotor(); };
            spindle.rotor2.turnoverAction = () => { spindle.rotor3.TurnRotor(); };
            spindle.rotor3.turnoverAction = () => { };
        }

        void Update()
        {
            if (currentKey == Chars._)
            {
                for (int i = 1; i <= 26; i++)
                {
                    if (CharToKey((Chars)i).wasPressedThisFrame)
                    {
                        Chars encoded = Encode((Chars)i);
                        lamps[encoded].TurnOn();
                        currentKey = (Chars)i;
                        currentLamp = encoded;
                        output.Append(encoded.ToString());
                        outputField.text = output.ToString();
                        break;
                    }
                }
            }
            else
            {
                if (!CharToKey(currentKey).isPressed)
                {
                    lamps[currentLamp].TurnOff();
                    currentKey = Chars._;
                }
            }
        }

        KeyControl CharToKey(Chars character)
        {
            switch (character)
            {
                default:
                    return null;
                case Chars.A:
                    return Keyboard.current.aKey;
                case Chars.B:
                    return Keyboard.current.bKey;
                case Chars.C:
                    return Keyboard.current.cKey;
                case Chars.D:
                    return Keyboard.current.dKey;
                case Chars.E:
                    return Keyboard.current.eKey;
                case Chars.F:
                    return Keyboard.current.fKey;
                case Chars.G:
                    return Keyboard.current.gKey;
                case Chars.H:
                    return Keyboard.current.hKey;
                case Chars.I:
                    return Keyboard.current.iKey;
                case Chars.J:
                    return Keyboard.current.jKey;
                case Chars.K:
                    return Keyboard.current.kKey;
                case Chars.L:
                    return Keyboard.current.lKey;
                case Chars.M:
                    return Keyboard.current.mKey;
                case Chars.N:
                    return Keyboard.current.nKey;
                case Chars.O:
                    return Keyboard.current.oKey;
                case Chars.P:
                    return Keyboard.current.pKey;
                case Chars.Q:
                    return Keyboard.current.qKey;
                case Chars.R:
                    return Keyboard.current.rKey;
                case Chars.S:
                    return Keyboard.current.sKey;
                case Chars.T:
                    return Keyboard.current.tKey;
                case Chars.U:
                    return Keyboard.current.uKey;
                case Chars.V:
                    return Keyboard.current.vKey;
                case Chars.W:
                    return Keyboard.current.wKey;
                case Chars.X:
                    return Keyboard.current.xKey;
                case Chars.Y:
                    return Keyboard.current.yKey;
                case Chars.Z:
                    return Keyboard.current.zKey;
            }
        }

        Chars Encode(Chars input)
        {
            Chars encoded = spindle.Encode(input);
            encoded = reflector.Reflect(encoded);
            encoded = spindle.Encode(encoded, true);
            return encoded;
        }
    }
}