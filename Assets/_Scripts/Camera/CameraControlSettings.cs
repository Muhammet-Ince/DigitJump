using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitJump.Camera
{
    [CreateAssetMenu(menuName = "DigitJump/Camera/CameraControlSettings")]
    public class CameraControlSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float rotationLerpSpeed;
        public float RotationLerpSpeed => rotationLerpSpeed;

        [Header("Position")] 
        [SerializeField] private Vector3 positionOffset;
        public Vector3 PositionOffset => positionOffset;

        [SerializeField] private float positionLerp;
        public float PositionLerp => positionLerp;
    }
}
