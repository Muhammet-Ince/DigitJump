using System;
using System.Collections;
using System.Collections.Generic;
using DigitJump.UserController.Systems;
using UnityEngine;

namespace DigitJump.UserController
{
    public class UserController : MonoBehaviour
    {
        private Quaternion _deltaRotation;
        
        [SerializeField] private UserControllerSettings userControllerSettings;
        [SerializeField] private Rigidbody rb;
        [SerializeField] private SwerveInputSystem swerveInputSystem;

        private void Update()
        {
            _deltaRotation = Quaternion.Euler(Vector3.up * (userControllerSettings.towerRotateSpeed * Time.deltaTime * -swerveInputSystem.MoveFactorX)); 
            
            rb.MoveRotation(rb.rotation * _deltaRotation);
        }
        
        
    }
}
