using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.OnScreen;
using TMPro;

namespace FallingSloth.Enigma
{
    public class InputKey : MonoBehaviour
    {
        public Chars character;

        OnScreenButton osb;
        TextMeshProUGUI text;

        void Start()
        {
            osb = GetComponent<OnScreenButton>();
            osb.controlPath = string.Format("<Keyboard>/#({0})", character);

            text = GetComponentInChildren<TextMeshProUGUI>();
            text.text = character.ToString();
        }

        void Update()
        {

        }
    }
}