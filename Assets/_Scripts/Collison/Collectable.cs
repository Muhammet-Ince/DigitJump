using DigitJump.Interfaces;
using DigitJump.UserData;
using UnityEngine;

namespace DigitJump.Collsion
{
    public class Collectable : MonoBehaviour, IInteractable
    {
        private int _tempPower;

        [SerializeField] private int collectablePower;
        [SerializeField] private UserDataSettings userDataSettings;


        public void TriggerInteract()
        {
            ScoreSetter();
            Destroy(gameObject);
        }

        public void CollisionInteract()
        {
            
        }

        private void ScoreSetter()
        {
            _tempPower = userDataSettings.userPower;

            if (userDataSettings.userPower > collectablePower)
            {
                _tempPower += collectablePower;
            }

            else if (userDataSettings.userPower == collectablePower)
            {
                _tempPower += collectablePower;
            }

            else
            {
                _tempPower -= collectablePower;

                if (_tempPower <= 0)
                {
                    _tempPower = 0;
                }
            }

            userDataSettings.userPower = _tempPower;
        }
    }
}
