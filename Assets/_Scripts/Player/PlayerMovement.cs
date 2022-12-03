using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DigitJump.PlayerMovement
{
    public class PlayerMovement : MonoBehaviour
    {
        private readonly float _checkRadius = 0.1f;

        [SerializeField] private Rigidbody rb;
        [SerializeField] private PlayerMovementSettings playerMovementSettings;
        
        
        
        [Header("About Checking isGround or Not"), Space]
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private Transform groundCheck;
        
        
        private bool CanJump => Physics.CheckSphere(groundCheck.position, _checkRadius, groundLayer);


        private void FixedUpdate()
        {
            JumpMovement();
        }

        private void JumpMovement()
        {
            // Can Player Jump Check
            if(CanJump)
            {
                // Fiziksel Ziplama
                //rb.AddForce(Vector3.up * playerMovementSettings.JumpForce);

                transform.DOMove(new Vector3(0, playerMovementSettings.JumpHeight, 0)
                    ,playerMovementSettings.JumpSpeed)
                    .SetRelative()
                    .SetEase(playerMovementSettings.JumpEase)
                    .SetSpeedBased();
            }

            // When player return ground after jumping, gravity scaler.
            // if (rb.velocity.y < 0 && !CanJump)
            // {
            //     Physics.gravity = new Vector3(0, -35, 0);
            // }
            // else
            // {
            //     Physics.gravity = new Vector3(0, -9.81f, 0);
            // }
        }
    }
}
