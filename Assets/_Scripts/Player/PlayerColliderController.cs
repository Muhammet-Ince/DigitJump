using System;
using DigitJump.Interfaces;
using DigitJump.PlayerScore;
using UnityEngine;

namespace DigitJump.PlayerCollsion
{
    public class PlayerColliderController : MonoBehaviour
    {
        private PlayerScoreManager scoreManager;

        private void Awake()
        {
            scoreManager = GetComponent<PlayerScoreManager>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                interactable.TriggerInteract();
                scoreManager.UpdateScoreText();
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.TryGetComponent(out IInteractable interactable))
            {
                interactable.CollisionInteract();
            }
        }
    }
}
