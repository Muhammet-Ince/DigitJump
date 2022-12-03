using System;
using UnityEngine;
using MText;

namespace TestScript
{
    public class TestScript : MonoBehaviour
    {
        private Modular3DText text;
        private int _value;

        private void Awake()
        {
            text = GetComponent<Modular3DText>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _value += 20;
                text.Text = _value.ToString();
            }
        }
    }
}
