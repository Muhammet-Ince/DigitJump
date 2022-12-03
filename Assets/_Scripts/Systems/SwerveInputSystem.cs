using UnityEngine;


namespace DigitJump.UserController.Systems
{
    public class SwerveInputSystem : MonoBehaviour
    {
        private float _lastFrameFingerPosX;
        private float _moveFactorX;

        public float MoveFactorX => _moveFactorX;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _lastFrameFingerPosX = Input.mousePosition.x;
            }

            else if (Input.GetMouseButton(0))
            {
                _moveFactorX = Input.mousePosition.x - _lastFrameFingerPosX;
                _lastFrameFingerPosX = Input.mousePosition.x;
            }

            else if (Input.GetMouseButtonUp(0))
            {
                _moveFactorX = 0;
            }
        }
    }
}
