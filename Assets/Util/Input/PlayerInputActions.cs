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
                },
                {
                    ""name"": ""pitchAndRollJoystick"",
                    ""type"": ""Value"",
                    ""id"": ""1fd4c333-4485-4bf8-9310-18703e978554"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""StickRz"",
                    ""type"": ""Value"",
                    ""id"": ""206fcbf0-3861-4512-addf-b69f476da629"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Translate"",
                    ""type"": ""Value"",
                    ""id"": ""5c445816-390a-4c5a-8b69-ddce47276be6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6249b220-218c-466e-bac4-44e02fd92c39"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KandM"",
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
                    ""groups"": ""KandM"",
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
                    ""groups"": ""KandM"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""17ea37b5-364b-499b-9146-e6fc48d3a511"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05c0b987-b16f-4db0-92c3-b3a9dc825736"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77b41022-7814-44b6-9de2-00ab8d91cf69"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/z"",
                    ""interactions"": """",
                    ""processors"": ""Invert,Normalize(min=-1,max=1,zero=-1)"",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2677fd00-e920-4ad9-92aa-820db15c579d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03449cc5-f1f9-4cba-9579-7c62a1b46947"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KandM"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a04df1c-1866-4aff-bdd2-3a7e60e5d00d"",
                    ""path"": ""<Joystick>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff44ffad-08a3-4440-8804-7869ea87951e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79461b7a-77d7-45d5-a8f4-3845b42eb004"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""pitchAndRollJoystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dc3ea2c-f7cf-4538-8581-9583c08b7fa3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""pitchAndRollJoystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73d5f074-cc38-4173-a4cc-fad677ddfdf6"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""StickRz"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d4c6047-3e68-4c85-a1ae-b14411f79a83"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Stick"",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""86476471-7882-4352-acbe-b24203bfb933"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""511ca918-7923-403c-9dfa-81295136cc36"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9bd775ea-589f-4c21-97f2-2b0a386b511c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""adcd87f1-1250-448e-b531-4d267e2b1753"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9cd040f9-3b3c-448f-b866-a9554b0d521a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Hat"",
                    ""id"": ""fd5f05be-b271-4b26-8c11-2d93b6e57bc8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a03577f7-a475-4690-a7be-b0ae70a162e7"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/button24"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f08c20dd-5af9-40bf-bea5-d3d83e6a78f6"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/button26"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b32bab2d-2eae-4918-b13a-111b4b79940d"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/button27"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d36b4a1-5b94-440f-bb1a-74df6bd4bb6a"",
                    ""path"": ""<HID::Logitech X52 Professional H.O.T.A.S.>/button25"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KandM"",
            ""bindingGroup"": ""KandM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Stick"",
            ""bindingGroup"": ""Stick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ManualShipThrusterControl
        m_ManualShipThrusterControl = asset.FindActionMap("ManualShipThrusterControl", throwIfNotFound: true);
        m_ManualShipThrusterControl_PitchAndRoll = m_ManualShipThrusterControl.FindAction("PitchAndRoll", throwIfNotFound: true);
        m_ManualShipThrusterControl_Yaw = m_ManualShipThrusterControl.FindAction("Yaw", throwIfNotFound: true);
        m_ManualShipThrusterControl_Throttle = m_ManualShipThrusterControl.FindAction("Throttle", throwIfNotFound: true);
        m_ManualShipThrusterControl_Fire = m_ManualShipThrusterControl.FindAction("Fire", throwIfNotFound: true);
        m_ManualShipThrusterControl_pitchAndRollJoystick = m_ManualShipThrusterControl.FindAction("pitchAndRollJoystick", throwIfNotFound: true);
        m_ManualShipThrusterControl_StickRz = m_ManualShipThrusterControl.FindAction("StickRz", throwIfNotFound: true);
        m_ManualShipThrusterControl_Translate = m_ManualShipThrusterControl.FindAction("Translate", throwIfNotFound: true);
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
    private readonly InputAction m_ManualShipThrusterControl_pitchAndRollJoystick;
    private readonly InputAction m_ManualShipThrusterControl_StickRz;
    private readonly InputAction m_ManualShipThrusterControl_Translate;
    public struct ManualShipThrusterControlActions
    {
        private @PlayerInputActions m_Wrapper;
        public ManualShipThrusterControlActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PitchAndRoll => m_Wrapper.m_ManualShipThrusterControl_PitchAndRoll;
        public InputAction @Yaw => m_Wrapper.m_ManualShipThrusterControl_Yaw;
        public InputAction @Throttle => m_Wrapper.m_ManualShipThrusterControl_Throttle;
        public InputAction @Fire => m_Wrapper.m_ManualShipThrusterControl_Fire;
        public InputAction @pitchAndRollJoystick => m_Wrapper.m_ManualShipThrusterControl_pitchAndRollJoystick;
        public InputAction @StickRz => m_Wrapper.m_ManualShipThrusterControl_StickRz;
        public InputAction @Translate => m_Wrapper.m_ManualShipThrusterControl_Translate;
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
                @pitchAndRollJoystick.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRollJoystick;
                @pitchAndRollJoystick.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRollJoystick;
                @pitchAndRollJoystick.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnPitchAndRollJoystick;
                @StickRz.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @StickRz.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @StickRz.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnStickRz;
                @Translate.started -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnTranslate;
                @Translate.performed -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnTranslate;
                @Translate.canceled -= m_Wrapper.m_ManualShipThrusterControlActionsCallbackInterface.OnTranslate;
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
                @pitchAndRollJoystick.started += instance.OnPitchAndRollJoystick;
                @pitchAndRollJoystick.performed += instance.OnPitchAndRollJoystick;
                @pitchAndRollJoystick.canceled += instance.OnPitchAndRollJoystick;
                @StickRz.started += instance.OnStickRz;
                @StickRz.performed += instance.OnStickRz;
                @StickRz.canceled += instance.OnStickRz;
                @Translate.started += instance.OnTranslate;
                @Translate.performed += instance.OnTranslate;
                @Translate.canceled += instance.OnTranslate;
            }
        }
    }
    public ManualShipThrusterControlActions @ManualShipThrusterControl => new ManualShipThrusterControlActions(this);
    private int m_KandMSchemeIndex = -1;
    public InputControlScheme KandMScheme
    {
        get
        {
            if (m_KandMSchemeIndex == -1) m_KandMSchemeIndex = asset.FindControlSchemeIndex("KandM");
            return asset.controlSchemes[m_KandMSchemeIndex];
        }
    }
    private int m_StickSchemeIndex = -1;
    public InputControlScheme StickScheme
    {
        get
        {
            if (m_StickSchemeIndex == -1) m_StickSchemeIndex = asset.FindControlSchemeIndex("Stick");
            return asset.controlSchemes[m_StickSchemeIndex];
        }
    }
    public interface IManualShipThrusterControlActions
    {
        void OnPitchAndRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnThrottle(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnPitchAndRollJoystick(InputAction.CallbackContext context);
        void OnStickRz(InputAction.CallbackContext context);
        void OnTranslate(InputAction.CallbackContext context);
    }
}
