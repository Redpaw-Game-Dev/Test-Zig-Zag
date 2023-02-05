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
                    ""id"": ""db1ef2ea-4adc-49d0-a77c-06a29e84a8a5"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
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
                    ""id"": ""a8c05889-14fb-4a6b-906d-f46c7d4a4837"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
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
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
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
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""3cfd0434-eff6-48a7-bdff-677ba8813ff8"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""dbe74560-0ede-42e9-b371-8df0dd0e048a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""6d4e421c-2da3-493c-ae2d-ca01782dac9a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Settings"",
                    ""type"": ""Button"",
                    ""id"": ""b3931ffe-f73a-4c59-8ed6-bc1b9a170e29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""823026d4-54e5-4e1d-8dbc-f2f73f3bfc43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ae163bc-bc34-4ed6-80fc-cc901dc1dcb0"",
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
                    ""id"": ""d80c7eb3-399b-41ae-b176-3fa23aa60371"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4a76938-ba1b-40aa-8844-63562c0134cb"",
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
                    ""id"": ""744406c6-1750-40cf-9d3d-a276229735ac"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b723d0a-8bfd-4a56-87f1-be1b130d9def"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""Settings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8be77a7-81dc-4124-9868-a5e737829d92"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""cbab3bd6-8200-4e88-b576-04b2dd287878"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""bcf54da5-49de-4636-ad03-e346210850e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""02adf435-9eff-4a4c-abdc-d73ab18267ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""65ad951c-0d32-443a-bd18-3f1d601a75bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""8ac143a2-5ba5-4c77-a4b3-5c18d8575f50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""09efa2e5-d159-4dec-96b6-c0720093d42a"",
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
                    ""id"": ""b37307de-bc1c-4e62-95ff-f8aaa2e3d5a6"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d89f371-ec9f-4aad-ba18-e01ec24b152d"",
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
                    ""id"": ""7d4c10fc-7682-4e83-906a-6a8d89c64663"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fa85950-dee8-478b-aa58-68ed42b4a95e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""BackToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a17968e-dca9-4eb1-9c07-490e4a735848"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Settings"",
            ""id"": ""d9db4542-efbc-4559-ac0e-b4d80951f991"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""95f65da0-7632-42a4-bfd2-5bee2beb2ca5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""531b66fc-b77d-4b98-b72e-48846d80a63e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackToMenu"",
                    ""type"": ""Button"",
                    ""id"": ""0797832a-21dc-4c66-8fab-966c89bb7449"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchMode"",
                    ""type"": ""Button"",
                    ""id"": ""5a4af940-4eda-4a46-a416-07b39bb1a0bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5012f26a-77fb-47f5-98e8-80452debd59a"",
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
                    ""id"": ""a2831e07-2fe8-4cee-93c4-9e4bd31f013b"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00afa15a-b5b9-4be5-901f-f606f92437f6"",
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
                    ""id"": ""fadafe8b-a602-417e-ad04-acae092bf9ed"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad7088d0-eb0b-4b78-973c-4f3cfdc48930"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""BackToMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""074e8b2f-9187-4f8b-8c0e-2c5d0505a11b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""SwitchMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Lose"",
            ""id"": ""a1d4ca60-ebe2-40dd-b858-a3de14af3fa2"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""e2d93f5f-0956-4ad2-94e8-7cbc30572d97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""a20d8035-1e5b-485e-9a88-93fd927788ba"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Retry"",
                    ""type"": ""Button"",
                    ""id"": ""e24875c0-c07d-4bc0-8c6a-c605b689a976"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b5ff07d-a8bb-4266-b829-1ab219e2f846"",
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
                    ""id"": ""03099c16-3be0-4116-aa36-1692f42ee581"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b374e2f1-3890-4b7d-8e5b-4bec480c229a"",
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
                    ""id"": ""6bce1bfc-55b8-4023-ade7-fe2947a433c5"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch;Touchscreen"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04bac37f-886a-420e-9daf-117ad70c6450"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse Keyboard;Touchscreen"",
                    ""action"": ""Retry"",
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
        }
    ]
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Click = m_Gameplay.FindAction("Click", throwIfNotFound: true);
            m_Gameplay_Point = m_Gameplay.FindAction("Point", throwIfNotFound: true);
            m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
            m_Gameplay_Turn = m_Gameplay.FindAction("Turn", throwIfNotFound: true);
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Click = m_Menu.FindAction("Click", throwIfNotFound: true);
            m_Menu_Point = m_Menu.FindAction("Point", throwIfNotFound: true);
            m_Menu_Settings = m_Menu.FindAction("Settings", throwIfNotFound: true);
            m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
            // Pause
            m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
            m_Pause_Click = m_Pause.FindAction("Click", throwIfNotFound: true);
            m_Pause_Point = m_Pause.FindAction("Point", throwIfNotFound: true);
            m_Pause_BackToMenu = m_Pause.FindAction("BackToMenu", throwIfNotFound: true);
            m_Pause_Play = m_Pause.FindAction("Play", throwIfNotFound: true);
            // Settings
            m_Settings = asset.FindActionMap("Settings", throwIfNotFound: true);
            m_Settings_Click = m_Settings.FindAction("Click", throwIfNotFound: true);
            m_Settings_Point = m_Settings.FindAction("Point", throwIfNotFound: true);
            m_Settings_BackToMenu = m_Settings.FindAction("BackToMenu", throwIfNotFound: true);
            m_Settings_SwitchMode = m_Settings.FindAction("SwitchMode", throwIfNotFound: true);
            // Lose
            m_Lose = asset.FindActionMap("Lose", throwIfNotFound: true);
            m_Lose_Click = m_Lose.FindAction("Click", throwIfNotFound: true);
            m_Lose_Point = m_Lose.FindAction("Point", throwIfNotFound: true);
            m_Lose_Retry = m_Lose.FindAction("Retry", throwIfNotFound: true);
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

        // Menu
        private readonly InputActionMap m_Menu;
        private IMenuActions m_MenuActionsCallbackInterface;
        private readonly InputAction m_Menu_Click;
        private readonly InputAction m_Menu_Point;
        private readonly InputAction m_Menu_Settings;
        private readonly InputAction m_Menu_Start;
        public struct MenuActions
        {
            private @InputActionsConfig m_Wrapper;
            public MenuActions(@InputActionsConfig wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Menu_Click;
            public InputAction @Point => m_Wrapper.m_Menu_Point;
            public InputAction @Settings => m_Wrapper.m_Menu_Settings;
            public InputAction @Start => m_Wrapper.m_Menu_Start;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void SetCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPoint;
                    @Settings.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                    @Settings.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                    @Settings.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSettings;
                    @Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                    @Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                    @Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                }
                m_Wrapper.m_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Settings.started += instance.OnSettings;
                    @Settings.performed += instance.OnSettings;
                    @Settings.canceled += instance.OnSettings;
                    @Start.started += instance.OnStart;
                    @Start.performed += instance.OnStart;
                    @Start.canceled += instance.OnStart;
                }
            }
        }
        public MenuActions @Menu => new MenuActions(this);

        // Pause
        private readonly InputActionMap m_Pause;
        private IPauseActions m_PauseActionsCallbackInterface;
        private readonly InputAction m_Pause_Click;
        private readonly InputAction m_Pause_Point;
        private readonly InputAction m_Pause_BackToMenu;
        private readonly InputAction m_Pause_Play;
        public struct PauseActions
        {
            private @InputActionsConfig m_Wrapper;
            public PauseActions(@InputActionsConfig wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Pause_Click;
            public InputAction @Point => m_Wrapper.m_Pause_Point;
            public InputAction @BackToMenu => m_Wrapper.m_Pause_BackToMenu;
            public InputAction @Play => m_Wrapper.m_Pause_Play;
            public InputActionMap Get() { return m_Wrapper.m_Pause; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
            public void SetCallbacks(IPauseActions instance)
            {
                if (m_Wrapper.m_PauseActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPoint;
                    @BackToMenu.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnBackToMenu;
                    @BackToMenu.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnBackToMenu;
                    @BackToMenu.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnBackToMenu;
                    @Play.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPlay;
                    @Play.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPlay;
                    @Play.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPlay;
                }
                m_Wrapper.m_PauseActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @BackToMenu.started += instance.OnBackToMenu;
                    @BackToMenu.performed += instance.OnBackToMenu;
                    @BackToMenu.canceled += instance.OnBackToMenu;
                    @Play.started += instance.OnPlay;
                    @Play.performed += instance.OnPlay;
                    @Play.canceled += instance.OnPlay;
                }
            }
        }
        public PauseActions @Pause => new PauseActions(this);

        // Settings
        private readonly InputActionMap m_Settings;
        private ISettingsActions m_SettingsActionsCallbackInterface;
        private readonly InputAction m_Settings_Click;
        private readonly InputAction m_Settings_Point;
        private readonly InputAction m_Settings_BackToMenu;
        private readonly InputAction m_Settings_SwitchMode;
        public struct SettingsActions
        {
            private @InputActionsConfig m_Wrapper;
            public SettingsActions(@InputActionsConfig wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Settings_Click;
            public InputAction @Point => m_Wrapper.m_Settings_Point;
            public InputAction @BackToMenu => m_Wrapper.m_Settings_BackToMenu;
            public InputAction @SwitchMode => m_Wrapper.m_Settings_SwitchMode;
            public InputActionMap Get() { return m_Wrapper.m_Settings; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SettingsActions set) { return set.Get(); }
            public void SetCallbacks(ISettingsActions instance)
            {
                if (m_Wrapper.m_SettingsActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_SettingsActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_SettingsActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_SettingsActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_SettingsActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_SettingsActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_SettingsActionsCallbackInterface.OnPoint;
                    @BackToMenu.started -= m_Wrapper.m_SettingsActionsCallbackInterface.OnBackToMenu;
                    @BackToMenu.performed -= m_Wrapper.m_SettingsActionsCallbackInterface.OnBackToMenu;
                    @BackToMenu.canceled -= m_Wrapper.m_SettingsActionsCallbackInterface.OnBackToMenu;
                    @SwitchMode.started -= m_Wrapper.m_SettingsActionsCallbackInterface.OnSwitchMode;
                    @SwitchMode.performed -= m_Wrapper.m_SettingsActionsCallbackInterface.OnSwitchMode;
                    @SwitchMode.canceled -= m_Wrapper.m_SettingsActionsCallbackInterface.OnSwitchMode;
                }
                m_Wrapper.m_SettingsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @BackToMenu.started += instance.OnBackToMenu;
                    @BackToMenu.performed += instance.OnBackToMenu;
                    @BackToMenu.canceled += instance.OnBackToMenu;
                    @SwitchMode.started += instance.OnSwitchMode;
                    @SwitchMode.performed += instance.OnSwitchMode;
                    @SwitchMode.canceled += instance.OnSwitchMode;
                }
            }
        }
        public SettingsActions @Settings => new SettingsActions(this);

        // Lose
        private readonly InputActionMap m_Lose;
        private ILoseActions m_LoseActionsCallbackInterface;
        private readonly InputAction m_Lose_Click;
        private readonly InputAction m_Lose_Point;
        private readonly InputAction m_Lose_Retry;
        public struct LoseActions
        {
            private @InputActionsConfig m_Wrapper;
            public LoseActions(@InputActionsConfig wrapper) { m_Wrapper = wrapper; }
            public InputAction @Click => m_Wrapper.m_Lose_Click;
            public InputAction @Point => m_Wrapper.m_Lose_Point;
            public InputAction @Retry => m_Wrapper.m_Lose_Retry;
            public InputActionMap Get() { return m_Wrapper.m_Lose; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(LoseActions set) { return set.Get(); }
            public void SetCallbacks(ILoseActions instance)
            {
                if (m_Wrapper.m_LoseActionsCallbackInterface != null)
                {
                    @Click.started -= m_Wrapper.m_LoseActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_LoseActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_LoseActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_LoseActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_LoseActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_LoseActionsCallbackInterface.OnPoint;
                    @Retry.started -= m_Wrapper.m_LoseActionsCallbackInterface.OnRetry;
                    @Retry.performed -= m_Wrapper.m_LoseActionsCallbackInterface.OnRetry;
                    @Retry.canceled -= m_Wrapper.m_LoseActionsCallbackInterface.OnRetry;
                }
                m_Wrapper.m_LoseActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @Retry.started += instance.OnRetry;
                    @Retry.performed += instance.OnRetry;
                    @Retry.canceled += instance.OnRetry;
                }
            }
        }
        public LoseActions @Lose => new LoseActions(this);
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
        public interface IGameplayActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnTurn(InputAction.CallbackContext context);
        }
        public interface IMenuActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnSettings(InputAction.CallbackContext context);
            void OnStart(InputAction.CallbackContext context);
        }
        public interface IPauseActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnBackToMenu(InputAction.CallbackContext context);
            void OnPlay(InputAction.CallbackContext context);
        }
        public interface ISettingsActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnBackToMenu(InputAction.CallbackContext context);
            void OnSwitchMode(InputAction.CallbackContext context);
        }
        public interface ILoseActions
        {
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnRetry(InputAction.CallbackContext context);
        }
    }
}
