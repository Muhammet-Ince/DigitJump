using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DigitJump.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private float minValue;
        private bool _canCameraMove;

        [SerializeField] private CameraControlSettings cameraControlSettings;
        [SerializeField] private Transform targetTransform;
        [SerializeField] private Transform cameraTransform;


        private void Update()
        {
            //CameraMovementFollow();
            Deneme();
            Deneme2();
            //CameraRotationFollow();
        }

        private void CameraRotationFollow()
        {
            cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation,
                Quaternion.LookRotation(targetTransform.position - cameraTransform.position)
                , Time.deltaTime * cameraControlSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            if (!_canCameraMove) return;

            cameraTransform.position = Vector3.Lerp(cameraTransform.position,
                targetTransform.position + cameraControlSettings.PositionOffset,
                Time.deltaTime * cameraControlSettings.PositionLerp);
        }

        private void Deneme()
        {
            Vector3 screenPos = UnityEngine.Camera.main.WorldToScreenPoint(targetTransform.position);
            print(screenPos.y);
            
            if (screenPos.y < minValue)
            {
                _canCameraMove = true;
            }
            else
            {
                _canCameraMove = false;
            }
        }

        private void Deneme2()
        {
            if (!_canCameraMove) return;
            
            print("AAAAAAAA");
        }
    }
}