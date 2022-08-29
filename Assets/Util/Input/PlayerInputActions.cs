//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Util/Input/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""4f72c896-47ef-4ca1-a72e-b0477c298cf3"",
            ""actions"": [
                {
                    ""name"": ""PitchAndYaw"",
                    ""type"": ""Value"",
                    ""id"": ""bb521b96-3d1f-4033-93d9-6164f92b6113"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""23eda144-2e5a-4d94-be01-1a21911851da"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PitchAndYaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ManualShipThrusterControl"",
            ""id"": ""f062a2a2-29b1-4c39-8eb1-0bf2d5aa483e"",
            ""actions"": [
                {
                    ""name"": ""StickX"",
                    ""type"": ""Value"",
                    ""id"": ""39bfc9a6-9582-4fe8-99cb-caa9f9cf32e9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StickY"",
                    ""type"": ""Value"",
                    ""id"": ""535786a6-5387-4095-ae6f-920dba08c498"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StickRz"",
                    ""type"": ""Value"",
                    ""id"": ""eaf2d2dc-8034-494f-b8e8-53da63b87079"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StickZ"",
                    ""type"": ""Value"",
                    ""id"": ""27e2790c-3929-4271-8c6d-81143733229d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c7102e19-ce8f-4609-a82b-9d7eea1ed7e5"",
                    ""path"": ""<Joystick>/stick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""824cebc3-8c05-42b4-8693-634b3dfe218b"",
                    ""path"": ""<Joystick>/stick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21e50905-2021-4a61-a931-3f6cdd0b1915"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRz"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2715bd2b-6a09-4617-931c-d02d3dca91e1"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_PitchAndYaw = m_Main.FindAction("PitchAndYaw", throwIfNotFound: true);
        // ManualShipThrusterControl
        m_ManualShipThrusterControl = asset.FindActionMap("ManualShipThrusterControl", throwIfNotFound: true);
        m_ManualShipThrusterControl_StickX = m_ManualShipThrusterControl.FindAction("StickX", throwIfNotFound: true);
        m_ManualShipThrusterControl_StickY = m_ManualShipThrusterControl.FindAction("StickY", throwIfNotFound: true);
        m_ManualShipThrusterControl_StickRz = m_ManualShipThrusterControl.FindAction("StickRz", throwIfNotFound: true);
        m_ManualShipThrusterControl_StickZ = m_ManualShipThrusterControl.FindAction("StickZ", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_PitchAndYaw;
    public struct MainActions
    {
        private @PlayerInputActions m_Wrapper;
        public MainActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PitchAndYaw => m_Wrapper.m_Main_PitchAndYaw;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @PitchAndYaw.started -= m_Wrapper.m_MainActionsCallbackInterface.OnPitchAndYaw;
                @PitchAndYaw.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnPitchAndYaw;
                @PitchAndYaw.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnPitchAndYaw;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PitchAndYaw.started += instance.OnPitchAndYaw;
                @PitchAndYaw.performed += instance.OnPitchAndYaw;
                @PitchAndYaw.canceled += instance.OnPitchAndYaw;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // ManualShipThrusterControl
    private readonly InputActionMap m_ManualShipThrusterControl;
    private IManualShipThrusterControlActions m_ManualShipThrusterControlActionsCallbackInterface;
    private readonly InputAction m_ManualShipThrusterControl_StickX;
    private readonly InputAction m_ManualShipThrusterControl_StickY;
    private readonly InputAction m_ManualShipThrusterControl_StickRz;
    private readonly InputAction m_ManualShipThrusterControl_StickZ;
    public struct ManualShipThrusterControlActions
    {
        private @PlayerInputActions m_Wrapper;
        public ManualShipThrusterControlActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @StickX => m_Wrapper.m_ManualShipThrusterControl_StickX;
        public InputAction @StickY => m_Wrapper.m_ManualShipThrusterControl_StickY;
        public InputAction @StickRz => m_Wrapper.m_ManualShipThrusterControl_StickRz;
        public InputAction @StickZ => m_Wrapper.m_ManualShipThrusterControl_StickZ;
        public InputActionMap Get() { return m_Wrapper.m_ManualShipThrusterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManualShipThrusterControlActions set) { return set.Get(); }
        public void SetCallbacks(IManualShipThrusterControlActions instance)
        {
            if (m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface != null)
            {
                @StickX.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickX;
                @StickX.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickX;
                @StickX.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickX;
                @StickY.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickY;
                @StickY.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickY;
                @StickY.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickY;
                @StickRz.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @StickRz.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @StickRz.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @StickZ.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickZ;
                @StickZ.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickZ;
                @StickZ.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickZ;
            }
            m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StickX.started += instance.OnStickX;
                @StickX.performed += instance.OnStickX;
                @StickX.canceled += instance.OnStickX;
                @StickY.started += instance.OnStickY;
                @StickY.performed += instance.OnStickY;
                @StickY.canceled += instance.OnStickY;
                @StickRz.started += instance.OnStickRz;
                @StickRz.performed += instance.OnStickRz;
                @StickRz.canceled += instance.OnStickRz;
                @StickZ.started += instance.OnStickZ;
                @StickZ.performed += instance.OnStickZ;
                @StickZ.canceled += instance.OnStickZ;
            }
        }
    }
    public ManualShipThrusterControlActions @ManualShipThrusterControl => new ManualShipThrusterControlActions(this);
    public interface IMainActions
    {
        void OnPitchAndYaw(InputAction.CallbackContext context);
    }
    public interface IManualShipThrusterControlActions
    {
        void OnStickX(InputAction.CallbackContext context);
        void OnStickY(InputAction.CallbackContext context);
        void OnStickRz(InputAction.CallbackContext context);
        void OnStickZ(InputAction.CallbackContext context);
    }
}