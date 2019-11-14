using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.OnScreen;
using TMPro;

namespace FallingSloth.Enigma
{
    public class InputKey : MonoBehaviour
    {
        TextMeshProUGUI keyText;
        OnScreenButton osb;

        int character = -1;

        void Start()
        {
            keyText = GetComponentInChildren<TextMeshProUGUI>();
            keyText.text = keyText.text[0].ToString();

            character = Enigma.chars.IndexOf(keyText.text);

            osb = GetComponent<OnScreenButton>();
            osb.controlPath = string.Format("<Keyboard>/#({0})", Enigma.chars[character]);
        }


    }
}