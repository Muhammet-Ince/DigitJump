using System;
using System.Collections;
using System.Collections.Generic;
using DigitJump.Interfaces;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace DigitJump.Collsion
{
    public class Slice : MonoBehaviour, IInteractable
    {
        private MeshRenderer _meshRenderer;

        [SerializeField] private TextMeshPro text;
        
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
                DangerSlice();
            }
            else if (isBreakable && !isDanger)
            {
                BreakableSlice();
            }
            else
            {
                SafeSlice();
            }
        }

        public void TriggerInteract()
        {

        }

        private void DangerSlice()
        {
            MaterialChanger(dangerMaterial);
            text.gameObject.SetActive(true);
        }

        private void BreakableSlice()
        {
            MaterialChanger(breakableMaterial);
            text.gameObject.SetActive(true);
        }

        private void SafeSlice()
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
