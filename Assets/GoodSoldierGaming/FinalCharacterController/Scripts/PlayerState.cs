using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoodSoldierGaming.FinalCharacterController
{
    public class PlayerState : MonoBehaviour
    {
        // show the current animation state in editor, but not able to change the value. This is for debugging.
        [field: SerializeField] public PlayerMovementState CurrentPlayerMovementState { get; private set; } = PlayerMovementState.Idling;

        public void SetPlayerMovementState(PlayerMovementState playerMovementState)
        {
            CurrentPlayerMovementState = playerMovementState;
        }

        public bool InGroundedState()
        {
            return CurrentPlayerMovementState == PlayerMovementState.Idling ||
                   CurrentPlayerMovementState == PlayerMovementState.Walking ||
                   CurrentPlayerMovementState == PlayerMovementState.Running ||
                   CurrentPlayerMovementState == PlayerMovementState.Sprinting;
        }
    }
    public enum PlayerMovementState
    {
        Idling = 0,
        Walking = 1,
        Running = 2,
        Sprinting = 3,
        Jumping = 4,
        Falling = 5,
        Strafing = 6,
    }
}

