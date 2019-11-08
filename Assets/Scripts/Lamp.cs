using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace FallingSloth.Enigma
{
    public class Lamp : MonoBehaviour
    {
        public Chars character;
        
        public bool isLampOn { get; protected set; }

        float animTime = 0.1f;
        int animFrames = 12;
        float animFrameTime { get => animTime / animFrames; }

        Color darkColor = new Color(0.3f, 0.3f, 0.3f);
        Color lightColor = new Color(1.0f, 0.97f, 0.39f);

        Image image;
        TextMeshProUGUI text;
        
        void Start()
        {
            FindObjectOfType<Enigma>().lamps.Add(character, this);

            isLampOn = false;

            image = GetComponent<Image>();
            image.color = darkColor;

            text = GetComponentInChildren<TextMeshProUGUI>();
            text.text = character.ToString();
        }

        public void TurnOn()
        {
            //StartCoroutine(_TurnOn());
            image.color = lightColor;
        }
        IEnumerator _TurnOn()
        {
            if (isLampOn)
            {
                yield break;
            }

            isLampOn = true;

            float t = 0f;
            while (t <= 1f)
            {
                image.color = Color.Lerp(darkColor, lightColor, t);
                yield return new WaitForSeconds(animFrameTime);
                t += animFrameTime;
            }
            image.color = lightColor;
        }

        public void TurnOff()
        {
            //StartCoroutine(_TurnOff());
            image.color = darkColor;
        }
        IEnumerator _TurnOff()
        {
            if (!isLampOn)
            {
                yield break;
            }

            isLampOn = false;

            float t = 0f;
            while (t <= 1f)
            {
                image.color = Color.Lerp(lightColor, darkColor, t);
                yield return new WaitForSeconds(animFrameTime);
                t += animFrameTime;
            }
            image.color = lightColor;
        }
    }
}