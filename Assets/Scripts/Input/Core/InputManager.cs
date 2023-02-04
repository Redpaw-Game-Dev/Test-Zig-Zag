using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace TestZigZag.Input
{
    public class InputManager : IInitializable
    {
        private InputActionsConfig _inputActionsConfig;

        public InputActionsConfig InputActionsConfig => _inputActionsConfig;

        public event Action OnTurn;
        public event Action OnPause;
        
        public void Initialize()
        {
            _inputActionsConfig = new InputActionsConfig();
            _inputActionsConfig.Gameplay.Turn.started += HandleTurn;
            _inputActionsConfig.Gameplay.Pause.performed += HandlePause;
            _inputActionsConfig.Gameplay.Enable();
        }

        private void HandlePause(InputAction.CallbackContext context)
        {
            OnPause?.Invoke();
        }

        private void HandleTurn(InputAction.CallbackContext context)
        {
            OnTurn?.Invoke();
        }
    }
}