using DigitJump.Interfaces;
using UnityEngine;

namespace DigitJump.PlayerCollsion
{
    public class PlayerColliderController : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IInteractable interactable))
            {
                interactable.TriggerInteract();
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
