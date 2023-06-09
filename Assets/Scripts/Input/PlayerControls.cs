//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input/PlayerControls.inputactions
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

namespace P209
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
            ""name"": ""General"",
            ""id"": ""e06a09a5-bb89-4c25-941f-3af9bda41c8b"",
            ""actions"": [
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e5e8c431-eb2b-47a7-8dea-d8834c0bf26c"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Gyroscope"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9439a17b-9866-4b65-a983-ff71f59467db"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44dd41c6-7407-487d-91d9-9beed0dace36"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerInput"",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bb42cb6-9ad2-492f-bb3f-166c771d7a86"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PlayerInput"",
                    ""action"": ""Gyroscope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PlayerInput"",
            ""bindingGroup"": ""PlayerInput"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gyroscope>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // General
            m_General = asset.FindActionMap("General", throwIfNotFound: true);
            m_General_PrimaryTouch = m_General.FindAction("PrimaryTouch", throwIfNotFound: true);
            m_General_Gyroscope = m_General.FindAction("Gyroscope", throwIfNotFound: true);
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

        // General
        private readonly InputActionMap m_General;
        private List<IGeneralActions> m_GeneralActionsCallbackInterfaces = new List<IGeneralActions>();
        private readonly InputAction m_General_PrimaryTouch;
        private readonly InputAction m_General_Gyroscope;
        public struct GeneralActions
        {
            private @PlayerControls m_Wrapper;
            public GeneralActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryTouch => m_Wrapper.m_General_PrimaryTouch;
            public InputAction @Gyroscope => m_Wrapper.m_General_Gyroscope;
            public InputActionMap Get() { return m_Wrapper.m_General; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
            public void AddCallbacks(IGeneralActions instance)
            {
                if (instance == null || m_Wrapper.m_GeneralActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GeneralActionsCallbackInterfaces.Add(instance);
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @Gyroscope.started += instance.OnGyroscope;
                @Gyroscope.performed += instance.OnGyroscope;
                @Gyroscope.canceled += instance.OnGyroscope;
            }

            private void UnregisterCallbacks(IGeneralActions instance)
            {
                @PrimaryTouch.started -= instance.OnPrimaryTouch;
                @PrimaryTouch.performed -= instance.OnPrimaryTouch;
                @PrimaryTouch.canceled -= instance.OnPrimaryTouch;
                @Gyroscope.started -= instance.OnGyroscope;
                @Gyroscope.performed -= instance.OnGyroscope;
                @Gyroscope.canceled -= instance.OnGyroscope;
            }

            public void RemoveCallbacks(IGeneralActions instance)
            {
                if (m_Wrapper.m_GeneralActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGeneralActions instance)
            {
                foreach (var item in m_Wrapper.m_GeneralActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GeneralActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GeneralActions @General => new GeneralActions(this);
        private int m_PlayerInputSchemeIndex = -1;
        public InputControlScheme PlayerInputScheme
        {
            get
            {
                if (m_PlayerInputSchemeIndex == -1) m_PlayerInputSchemeIndex = asset.FindControlSchemeIndex("PlayerInput");
                return asset.controlSchemes[m_PlayerInputSchemeIndex];
            }
        }
        public interface IGeneralActions
        {
            void OnPrimaryTouch(InputAction.CallbackContext context);
            void OnGyroscope(InputAction.CallbackContext context);
        }
    }
}
