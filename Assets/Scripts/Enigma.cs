using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using TMPro;

namespace FallingSloth.Enigma
{
    public class Enigma : MonoBehaviour
    {
        public const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public TextMeshProUGUI rotor1Position, rotor2Position, rotor3Position, outputBox;

        [Range(0, 4)]
        public int rotor1No = 1;
        [Range(0, 4)]
        public int rotor2No = 2;
        [Range(0, 4)]
        public int rotor3No = 3;

        [Range(0, 25)]
        public int rotor1StartPosition = 0;
        [Range(0, 25)]
        public int rotor2StartPosition = 0;
        [Range(0, 25)]
        public int rotor3StartPosition = 0;

        Rotor rotor1, rotor2, rotor3;
        Reflector reflector;

        public InputKey[] keys;
        public Lamp[] lamps;

        int currentKey = -1;
        int currentLamp = -1;

        void Start()
        {
            rotor1 = intToRotor(rotor1No);
            rotor1.position = rotor1StartPosition;
            rotor1Position.text = rotor1StartPosition.ToString();

            rotor2 = intToRotor(rotor2No);
            rotor2.position = rotor2StartPosition;
            rotor2Position.text = rotor2StartPosition.ToString();

            rotor3 = intToRotor(rotor3No);
            rotor3.position = rotor3StartPosition;
            rotor3Position.text = rotor3StartPosition.ToString();

            reflector = new Reflector();

            outputBox.text = "";
        }
        
        void Update()
        {
            if (currentKey == -1)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (CharToKey(i).isPressed)
                    {
                        currentKey = i;
                        TurnRotors();
                        int encoded = Encode(i);
                        currentLamp = encoded;
                        outputBox.text += chars[encoded];
                        lamps[currentLamp].isOn = true;
                        break;
                    }
                }
            }
            else
            {
                if (!CharToKey(currentKey).isPressed)
                {
                    lamps[currentLamp].isOn = false;
                    currentLamp = -1;
                    currentKey = -1;
                }
            }
        }

        void TurnRotors()
        {
            if (rotor1.position == rotor1.turnoverPoint)
            {
                if (rotor2.position == rotor2.turnoverPoint)
                {
                    rotor3.position = (rotor3.position + 1) % 26;
                    rotor3Position.text = rotor3.position.ToString();
                }
                rotor2.position = (rotor2.position + 1) % 26;
                rotor2Position.text = rotor2.position.ToString();
            }
            rotor1.position = (rotor1.position + 1) % 26;
            rotor1Position.text = rotor1.position.ToString();
        }

        int Encode(int input)
        {
            int output = input;

            output = rotor1.Encode(output);
            output = rotor2.Encode(output);
            output = rotor3.Encode(output);

            output = reflector.Encode(output);

            output = rotor3.Encode(output, true);
            output = rotor2.Encode(output, true);
            output = rotor1.Encode(output, true);

            return output;
        }

        Rotor intToRotor(int r)
        {
            switch (r)
            {
                default:
                    throw new System.ArgumentOutOfRangeException();
                case 0:
                    return Rotor.Rotor_I;
                case 1:
                    return Rotor.Rotor_II;
                case 2:
                    return Rotor.Rotor_III;
                case 3:
                    return Rotor.Rotor_IV;
                case 4:
                    return Rotor.Rotor_V;
            }
        }

        KeyControl CharToKey(int input)
        {
            switch (input)
            {
                default:
                    throw new System.ArgumentOutOfRangeException();
                case 0:
                    return Keyboard.current.aKey;
                case 1:
                    return Keyboard.current.bKey;
                case 2:
                    return Keyboard.current.cKey;
                case 3:
                    return Keyboard.current.dKey;
                case 4:
                    return Keyboard.current.eKey;
                case 5:
                    return Keyboard.current.fKey;
                case 6:
                    return Keyboard.current.gKey;
                case 7:
                    return Keyboard.current.hKey;
                case 8:
                    return Keyboard.current.iKey;
                case 9:
                    return Keyboard.current.jKey;
                case 10:
                    return Keyboard.current.kKey;
                case 11:
                    return Keyboard.current.lKey;
                case 12:
                    return Keyboard.current.mKey;
                case 13:
                    return Keyboard.current.nKey;
                case 14:
                    return Keyboard.current.oKey;
                case 15:
                    return Keyboard.current.pKey;
                case 16:
                    return Keyboard.current.qKey;
                case 17:
                    return Keyboard.current.rKey;
                case 18:
                    return Keyboard.current.sKey;
                case 19:
                    return Keyboard.current.tKey;
                case 20:
                    return Keyboard.current.uKey;
                case 21:
                    return Keyboard.current.vKey;
                case 22:
                    return Keyboard.current.wKey;
                case 23:
                    return Keyboard.current.xKey;
                case 24:
                    return Keyboard.current.yKey;
                case 25:
                    return Keyboard.current.zKey;
            }
        }
    }
}