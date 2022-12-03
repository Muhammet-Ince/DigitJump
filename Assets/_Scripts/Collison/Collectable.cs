using System;
using DigitJump.Interfaces;
using DigitJump.UserData;
using MText;
using UnityEngine;

namespace DigitJump.Collsion
{
    public class Collectable : MonoBehaviour, IInteractable
    {
        private int _tempPower;
        private Modular3DText textComponent;

        [SerializeField] private int collectablePower;
        [SerializeField] private UserDataSettings userDataSettings;

        private void Awake()
        {
            GetReferences();
            InitVariables();
        }

        public void TriggerInteract()
        {
            ScoreSetter();
            Destroy(gameObject);
        }

        private void ScoreSetter()
        {
            _tempPower = userDataSettings.userPower;
            _tempPower += collectablePower;
            userDataSettings.userPower = _tempPower;
        }

        private void GetReferences()
        {
            textComponent = GetComponent<Modular3DText>();
        }

        private void InitVariables()
        {
            textComponent.Text = collectablePower.ToString();
        }
    }
}
