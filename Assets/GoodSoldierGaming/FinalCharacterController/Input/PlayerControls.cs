//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GoodSoldierGaming/FinalCharacterController/Input/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace GoodSoldierGaming.FinalCharacterController
{
    public partial class @PlayerControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerLocomotionMap"",
            ""id"": ""34b7f22b-28e9-4c2c-96fc-7a246e59cdc3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1464bdb7-818d-4623-983f-9d4bb1fa832a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""f3b3aab6-b37b-4fb9-a870-0f20593bfa83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleSprint"",
                    ""type"": ""Button"",
                    ""id"": ""4a1a60b3-2557-4908-a251-40728d2249bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3c971497-0ca4-4287-9331-a47d6408b3f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""3ae1385d-62e1-4376-9e68-67be51ec0293"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f1f756dc-e310-4c9e-bd40-6aba0976e539"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bbdaf116-fff0-487d-a23a-4796c3fdd901"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d6ba72db-2912-443b-9aed-dd9eec556227"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88871ef1-297b-4b9d-87a8-430ebc1c4b34"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""c8bc76b1-1303-4626-9125-497cd0bff019"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9c87a5e7-a0d5-485d-bc60-30401080c466"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75c5de3f-63c4-45be-b131-ee610289563b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ed7e096a-9047-4e3a-980f-881e3d98e700"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""89d87edc-4604-4a9c-97ad-5dc276f2b3bf"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fa2c0bdf-6bcc-4dd2-a7f6-5cb0f7ba0994"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1571af3-d8da-4371-894e-2ce748fe4b9b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0af452d9-50b7-4d78-8694-033f1a784ae6"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleSprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""548804f1-d12d-4e0f-b5e7-1588b4e37538"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleSprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20876fbf-0d2a-4c53-9257-769fe0a3bf35"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a8b0196-c9b3-458e-8107-6a7f74f134b5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerLocomotionMap
            m_PlayerLocomotionMap = asset.FindActionMap("PlayerLocomotionMap", throwIfNotFound: true);
            m_PlayerLocomotionMap_Movement = m_PlayerLocomotionMap.FindAction("Movement", throwIfNotFound: true);
            m_PlayerLocomotionMap_Look = m_PlayerLocomotionMap.FindAction("Look", throwIfNotFound: true);
            m_PlayerLocomotionMap_ToggleSprint = m_PlayerLocomotionMap.FindAction("ToggleSprint", throwIfNotFound: true);
            m_PlayerLocomotionMap_Jump = m_PlayerLocomotionMap.FindAction("Jump", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // PlayerLocomotionMap
        private readonly InputActionMap m_PlayerLocomotionMap;
        private List<IPlayerLocomotionMapActions> m_PlayerLocomotionMapActionsCallbackInterfaces = new List<IPlayerLocomotionMapActions>();
        private readonly InputAction m_PlayerLocomotionMap_Movement;
        private readonly InputAction m_PlayerLocomotionMap_Look;
        private readonly InputAction m_PlayerLocomotionMap_ToggleSprint;
        private readonly InputAction m_PlayerLocomotionMap_Jump;
        public struct PlayerLocomotionMapActions
        {
            private @PlayerControls m_Wrapper;
            public PlayerLocomotionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_PlayerLocomotionMap_Movement;
            public InputAction @Look => m_Wrapper.m_PlayerLocomotionMap_Look;
            public InputAction @ToggleSprint => m_Wrapper.m_PlayerLocomotionMap_ToggleSprint;
            public InputAction @Jump => m_Wrapper.m_PlayerLocomotionMap_Jump;
            public InputActionMap Get() { return m_Wrapper.m_PlayerLocomotionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerLocomotionMapActions set) { return set.Get(); }
            public void AddCallbacks(IPlayerLocomotionMapActions instance)
            {
                if (instance == null || m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @ToggleSprint.started += instance.OnToggleSprint;
                @ToggleSprint.performed += instance.OnToggleSprint;
                @ToggleSprint.canceled += instance.OnToggleSprint;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }

            private void UnregisterCallbacks(IPlayerLocomotionMapActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Look.started -= instance.OnLook;
                @Look.performed -= instance.OnLook;
                @Look.canceled -= instance.OnLook;
                @ToggleSprint.started -= instance.OnToggleSprint;
                @ToggleSprint.performed -= instance.OnToggleSprint;
                @ToggleSprint.canceled -= instance.OnToggleSprint;
                @Jump.started -= instance.OnJump;
                @Jump.performed -= instance.OnJump;
                @Jump.canceled -= instance.OnJump;
            }

            public void RemoveCallbacks(IPlayerLocomotionMapActions instance)
            {
                if (m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IPlayerLocomotionMapActions instance)
            {
                foreach (var item in m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_PlayerLocomotionMapActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public PlayerLocomotionMapActions @PlayerLocomotionMap => new PlayerLocomotionMapActions(this);
        public interface IPlayerLocomotionMapActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnToggleSprint(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
    }
}
