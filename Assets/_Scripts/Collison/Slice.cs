using System;
using System.Collections;
using System.Collections.Generic;
using DigitJump.Interfaces;
using DigitJump.UserData;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace DigitJump.Collsion
{
    public class Slice : MonoBehaviour, IInteractable
    {
        private MeshRenderer _meshRenderer;
        
        [SerializeField] private int slicePower;
        [SerializeField] private TextMeshPro text;
        [SerializeField] private UserDataSettings userDataSettings;
        
        [FoldoutGroup("Materials")] [SerializeField] private Material safeMaterial;
        [FoldoutGroup("Materials")] [SerializeField] private Material dangerMaterial;
        [FoldoutGroup("Materials")] [SerializeField] private Material breakableMaterial;

        [Header("Slide Types")] 
        [SerializeField] private bool isDanger;
        [SerializeField] private bool isBreakable;

        private void OnValidate()
        {
            if (isDanger && !isBreakable)
            {
                DangerSliceValidate();
            }
            else if (isBreakable && !isDanger)
            {
                BreakableSliceValidate();
            }
            else
            {
                SafeSliceValidate();
            }
        }

        public void CollisionInteract()
        {
            if (isDanger && !isBreakable)
            {
                DangerSliceInteract();
            }
            else if (isBreakable && !isDanger)
            {
                BreakableSliceInteract();
            }
        }

        private int _tempPower;
        private void DangerSliceInteract()
        {
            _tempPower = userDataSettings.userPower;
            _tempPower -= slicePower;
            userDataSettings.userPower = _tempPower;
        }

        private void BreakableSliceInteract()
        {
            if (userDataSettings.userPower > slicePower)
            {
                // Buraya daha guzel bir efekt gerekiyor direkt kapatmak sacma
                Destroy(gameObject);
            }
            else
            {
                print("Try Again!");
            }
        }
        
        private void DangerSliceValidate()
        {
            MaterialChanger(dangerMaterial);
            text.gameObject.SetActive(true);
        }

        private void BreakableSliceValidate()
        {
            MaterialChanger(breakableMaterial);
            text.gameObject.SetActive(true);
        }

        private void SafeSliceValidate()
        {
            MaterialChanger(safeMaterial);
            text.gameObject.SetActive(false);
        }
        
        
        private void MaterialChanger(Material mat)
        {
            // Get Component Must be Used Because Edit Mode The Only Way to Access Component
            // This func Never used In PlayMode
            GetComponent<MeshRenderer>().material = mat;
        }
    }
}
