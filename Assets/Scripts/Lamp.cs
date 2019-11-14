using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FallingSloth.Enigma
{
    public class Lamp : MonoBehaviour
    {
        Image image;
        Animator animator;

        bool _isOn = false;
        public bool isOn
        {
            get => _isOn;
            set
            {
                _isOn = value;
                animator.SetBool("isOn", value);
            }
        }

        void Start()
        {
            image = GetComponent<Image>();
            animator = GetComponent<Animator>();
        }
    }
}