using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GoodSoldierGaming.FinalCharacterController
{
    [DefaultExecutionOrder(-2)]
    public class PlayerLocomotionInput : MonoBehaviour, PlayerControls.IPlayerLocomotionMapActions
    {
        #region Class Variables
        [SerializeField] private bool holdToSprint = true;

        public bool SprintToggleOn { get; private set; }
        public PlayerControls PlayerControls { get; private set; } // class property instead of field. Going to access this variable from outside the class. private set so we cannot set it's value from outside the class
        public Vector2 MovementInput { get; private set; }
        public Vector2 LookInput { get; private set; }
        public bool JumpPressed {get; private set; }
        #endregion

        #region Startup
        private void OnEnable()
        {
            PlayerControls = new PlayerControls();
            PlayerControls.Enable();

            PlayerControls.PlayerLocomotionMap.Enable();
            PlayerControls.PlayerLocomotionMap.SetCallbacks(this);
        }

        private void OnDisable()
        {
            PlayerControls.PlayerLocomotionMap.Disable();
            PlayerControls.PlayerLocomotionMap.RemoveCallbacks(this);
        }
        #endregion

        #region Late Update
        private void LateUpdate()
        {
            JumpPressed = false;
        }
        #endregion

        #region Callbacks
        public void OnMovement(InputAction.CallbackContext context)
        {
            MovementInput = context.ReadValue<Vector2>();
            print(MovementInput);
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            LookInput = context.ReadValue<Vector2>();
        }

        public void OnToggleSprint(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                SprintToggleOn = holdToSprint || !SprintToggleOn;
            }
            else if (context.canceled)
            {
                SprintToggleOn = !holdToSprint && SprintToggleOn;
            }
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (!context.performed)
            return;

            JumpPressed = true;
        }
        #endregion
    }

}

