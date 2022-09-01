//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
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
            ""name"": ""ManualShipThrusterControl"",
            ""id"": ""f062a2a2-29b1-4c39-8eb1-0bf2d5aa483e"",
            ""actions"": [
                {
                    ""name"": ""PitchAndRoll"",
                    ""type"": ""Value"",
                    ""id"": ""23c66b26-1ab0-4e79-a297-c63d9491aae9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""722b9e98-5193-46c8-8b27-00d72a104568"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Throttle"",
                    ""type"": ""Value"",
                    ""id"": ""3025a863-1e49-448a-8d35-1d8d2a66169c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""3ce49c64-9185-497f-b42e-e4b241b9db18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6249b220-218c-466e-bac4-44e02fd92c39"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PitchAndRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keybord"",
                    ""id"": ""17b60ad3-63b7-4254-a5a8-47f1df549f18"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c00c6e05-b586-4174-95b9-4cede61971ec"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""78ab18db-ba0c-4ab6-8479-4673ac1b5331"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keybord"",
                    ""id"": ""e8f4d892-a45b-4775-8b3e-e5d9923c60bb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5c0d36da-080f-44de-8ec3-45272337c63c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bdbb3c34-96f8-476e-b8fa-047e776cc8b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""03449cc5-f1f9-4cba-9579-7c62a1b46947"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ManualShipThrusterControl
        m_ManualShipThrusterControl = asset.FindActionMap("ManualShipThrusterControl", throwIfNotFound: true);
        m_ManualShipThrusterControl_PitchAndRoll = m_ManualShipThrusterControl.FindAction("PitchAndRoll", throwIfNotFound: true);
        m_ManualShipThrusterControl_Yaw = m_ManualShipThrusterControl.FindAction("Yaw", throwIfNotFound: true);
        m_ManualShipThrusterControl_Throttle = m_ManualShipThrusterControl.FindAction("Throttle", throwIfNotFound: true);
        m_ManualShipThrusterControl_Fire = m_ManualShipThrusterControl.FindAction("Fire", throwIfNotFound: true);
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

    // ManualShipThrusterControl
    private readonly InputActionMap m_ManualShipThrusterControl;
    private IManualShipThrusterControlActions m_ManualShipThrusterControlActionsCallbackInterface;
    private readonly InputAction m_ManualShipThrusterControl_PitchAndRoll;
    private readonly InputAction m_ManualShipThrusterControl_Yaw;
    private readonly InputAction m_ManualShipThrusterControl_Throttle;
    private readonly InputAction m_ManualShipThrusterControl_Fire;
    public struct ManualShipThrusterControlActions
    {
        private @PlayerInputActions m_Wrapper;
        public ManualShipThrusterControlActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PitchAndRoll => m_Wrapper.m_ManualShipThrusterControl_PitchAndRoll;
        public InputAction @Yaw => m_Wrapper.m_ManualShipThrusterControl_Yaw;
        public InputAction @Throttle => m_Wrapper.m_ManualShipThrusterControl_Throttle;
        public InputAction @Fire => m_Wrapper.m_ManualShipThrusterControl_Fire;
        public InputActionMap Get() { return m_Wrapper.m_ManualShipThrusterControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManualShipThrusterControlActions set) { return set.Get(); }
        public void SetCallbacks(IManualShipThrusterControlActions instance)
        {
            if (m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface != null)
            {
                @PitchAndRoll.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRoll;
                @PitchAndRoll.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRoll;
                @PitchAndRoll.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRoll;
                @Yaw.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnYaw;
                @Throttle.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnThrottle;
                @Fire.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PitchAndRoll.started += instance.OnPitchAndRoll;
                @PitchAndRoll.performed += instance.OnPitchAndRoll;
                @PitchAndRoll.canceled += instance.OnPitchAndRoll;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public ManualShipThrusterControlActions @ManualShipThrusterControl => new ManualShipThrusterControlActions(this);
    public interface IManualShipThrusterControlActions
    {
        void OnPitchAndRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
