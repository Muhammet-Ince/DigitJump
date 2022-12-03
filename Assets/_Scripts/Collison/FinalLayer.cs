using System.Collections;
using System.Collections.Generic;
using DigitJump.Interfaces;
using UnityEngine;

namespace DigitJump.Collison
{
    public class FinalLayer : MonoBehaviour,IInteractable
    {
        public void TriggerInteract()
        {
            
        }

        public void CollisionInteract()
        {
            print("Level End Cong. ");
        }
    }
}
