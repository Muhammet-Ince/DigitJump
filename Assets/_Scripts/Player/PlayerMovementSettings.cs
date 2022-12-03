using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace DigitJump.PlayerMovement
{
    [CreateAssetMenu(menuName = "DigitJump/Player/MovementSettings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float _jumpSpeed;
        public float JumpSpeed => _jumpSpeed;

        [SerializeField] private float _jumpHeight;
        public float JumpHeight => _jumpHeight;

        [SerializeField] private Ease _jumpEase;
        public Ease JumpEase => _jumpEase;

    }
}
