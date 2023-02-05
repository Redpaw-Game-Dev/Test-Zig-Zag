using System;
using TestZigZag.Game;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Zenject;

namespace TestZigZag.Input
{
    public class InputManager : IInitializable
    {
        private InputActionsConfig _inputActionsConfig;
        [Inject] private GameManager _gameManager;

        public InputActionsConfig InputActionsConfig => _inputActionsConfig;

        public event Action OnTurn;
        public event Action OnPause;
        public event Action OnStart;
        public event Action OnSettings;
        public event Action OnPlay;
        public event Action OnBackToMenu;
        public event Action OnSwitchMode;
        
        public void Initialize()
        {
            // NewInputInit();
        }

        
        //TODO: fix new input for mobile devices
        private void NewInputInit()
        {
            _inputActionsConfig = new InputActionsConfig();
            _inputActionsConfig.Gameplay.Turn.started += HandleTurn;
            _inputActionsConfig.Gameplay.Pause.started += HandlePause;
            _inputActionsConfig.Menu.Start.started += HandleStart;
            _inputActionsConfig.Menu.Settings.started += HandleSettings;
            _inputActionsConfig.Pause.Play.started += HandlePlay;
            _inputActionsConfig.Pause.BackToMenu.started += HandleBackToMenu;
            _inputActionsConfig.Lose.Retry.started += HandleBackToMenu;
            _inputActionsConfig.Settings.BackToMenu.started += HandleBackToMenu;
            _inputActionsConfig.Settings.SwitchMode.started += HandleSwitchMode;
            _inputActionsConfig.Menu.Enable();
            _gameManager.OnGameEnded += HandleGameEnd;
        }

        public void StartGame() => OnStart?.Invoke();
        public void PauseGame() => OnPause?.Invoke();
        public void ContinueGame() => OnPlay?.Invoke();
        public void BackToMenu() => OnBackToMenu?.Invoke();
        public void OpenSettings() => OnSettings?.Invoke();
        public void TurnInput() => OnTurn?.Invoke();
        public void SwitchMode() => OnSwitchMode?.Invoke();

        private void HandleGameEnd()
        {
            _inputActionsConfig.Gameplay.Disable();
            _inputActionsConfig.Lose.Enable();
        }
        
        private void HandleSwitchMode(InputAction.CallbackContext obj)
        {
            OnSwitchMode?.Invoke();
        }

        private void HandleBackToMenu(InputAction.CallbackContext context)
        {
            _inputActionsConfig.Settings.Disable();
            _inputActionsConfig.Pause.Disable();
            _inputActionsConfig.Lose.Disable();
            _inputActionsConfig.Menu.Enable();
            OnBackToMenu?.Invoke();
        }

        private void HandlePlay(InputAction.CallbackContext context)
        {
            _inputActionsConfig.Pause.Disable();
            _inputActionsConfig.Gameplay.Enable();
            OnPlay?.Invoke();
        }

        private void HandleSettings(InputAction.CallbackContext context)
        {
            _inputActionsConfig.Menu.Disable();
            _inputActionsConfig.Settings.Enable();
            OnSettings?.Invoke();
        }

        private void HandleStart(InputAction.CallbackContext context)
        {
            _inputActionsConfig.Menu.Disable();
            _inputActionsConfig.Gameplay.Enable();
            OnStart?.Invoke();
        }

        private void HandlePause(InputAction.CallbackContext context)
        {
            _inputActionsConfig.Gameplay.Disable();
            _inputActionsConfig.Pause.Enable();
            OnPause?.Invoke();
        }

        private void HandleTurn(InputAction.CallbackContext context)
        {
            OnTurn?.Invoke();
        }
    }
}