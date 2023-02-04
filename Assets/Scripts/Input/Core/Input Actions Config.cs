// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/Input Actions Config.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace TestZigZag.Input
{
    public class @InputActionsConfig : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputActionsConfig()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input Actions Config"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""d5bbe6e2-5d94-488b-8f4b-44d8b9d7d1c0"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""91c35288-b288-4f03-bf92-410ecb83af34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""6f7af360-e877-4e4b-aa28-dacbc4e6c0dd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8bd39294-bd00-4ef3-8b9e-e4bae5d761e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""321e3d30-b718-4f31-abee-88c4bf7d9910"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aa0ca74b-f762-412a-8a26-adf00bc03561"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Mouse Keyboard"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f1bb239-7e4c-4b2a-8ae7-0a7b08160e38"",
                    ""path"": ""<Pen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Pen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db1ef2ea-4adc-49d0-a77c-06a29e84a8a5"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd3370e6-b50c-4e8f-a0c4-3f60d8954518"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Mouse Keyboard"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbcd9fc0-7e0b-456e-b55a-9d8fc41157da"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;Pen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8c05889-14fb-4a6b-906d-f46c7d4a4837"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aeef91fd-4e23-4282-86cb-58d5583b1c4a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen;Pen"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34fd78f2-8187-4aae-b902-894099c7088c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Pen;Touchscreen"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse Keyboard"",
            ""bindingGroup"": ""Mouse Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touchscreen"",
            ""bindingGroup"": ""Touchscreen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Pen"",
            ""bindingGroup"": ""Pen"",
            ""devices"": [
                {
                    ""devicePath"": ""<Pen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Click = m_Gameplay.FindAction("Click", throwIfNotFound: true);
            m_Gameplay_Point = m_Gameplay.FindAction("Point", throwIfNotFound: true);
            m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
            m_Gameplay_Turn = m_Gameplay.FindAction("Turn", throwIfNotFound: true);
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Click;
        private readonly InputAction m_Gameplay_Point;
        private readonly InputAction m_Gameplay_Pause;
        private readonly InputAction m_Gameplay_Turn;
        public struct GameplayActions
        {
            private @InputActionsConfig m_Wrapper;
            public GameplayActions(@InputActionsConfig wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Gameplay_Click;
            public InputAction @Point => m_Wrapper.m_Gameplay_Point;
            public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
            public InputAction @Turn => m_Wrapper.m_Gameplay_Turn;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPoint;
                    @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Turn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                    @Turn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                    @Turn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnTurn;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @Turn.started += instance.OnTurn;
                    @Turn.performed += instance.OnTurn;
                    @Turn.canceled += instance.OnTurn;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);
        private int m_MouseKeyboardSchemeIndex = -1;
        public InputControlScheme MouseKeyboardScheme
        {
            get
            {
                if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse Keyboard");
                return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
            }
        }
        private int m_TouchscreenSchemeIndex = -1;
        public InputControlScheme TouchscreenScheme
        {
            get
            {
                if (m_TouchscreenSchemeIndex == -1) m_TouchscreenSchemeIndex = asset.FindControlSchemeIndex("Touchscreen");
                return asset.controlSchemes[m_TouchscreenSchemeIndex];
            }
        }
        private int m_PenSchemeIndex = -1;
        public InputControlScheme PenScheme
        {
            get
            {
                if (m_PenSchemeIndex == -1) m_PenSchemeIndex = asset.FindControlSchemeIndex("Pen");
                return asset.controlSchemes[m_PenSchemeIndex];
            }
        }
        public interface IGameplayActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnTurn(InputAction.CallbackContext context);
        }
    }
}
