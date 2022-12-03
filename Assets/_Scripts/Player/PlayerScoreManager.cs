using System;
using DigitJump.UserData;
using MText;
using UnityEngine;

namespace DigitJump.PlayerScore
{
    public class PlayerScoreManager : MonoBehaviour
    {
        [SerializeField] private UserDataSettings userDataSettings;
        [SerializeField] private Modular3DText textComponent;

        private void Awake()
        {
            InitVariables();
        }

        private void InitVariables()
        {
            textComponent.Text = userDataSettings.userPower.ToString();
        }

        public void UpdateScoreText()
        {
            textComponent.Text = userDataSettings.userPower.ToString();
        }
    }
}
