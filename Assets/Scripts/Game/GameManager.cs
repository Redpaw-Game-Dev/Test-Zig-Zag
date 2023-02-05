using System;
using TestZigZag.Abstraction;
using TestZigZag.Input;
using TestZigZag.ObjectsManagement;
using TestZigZag.UI;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace TestZigZag.Game
{
    public class GameManager : IInitializable
    {
        private InputManager _inputManager;
        private UiManager _uiManager;
        private float _defaultTimeScale;
        private GameMode _gameMode;
        private bool _isGameStarted;
        private Ball _playerBall;

        public event Action OnGameStarted;
        public event Action OnGamePaused;
        public event Action OnGameEnded;
        public event Action OnGameContinued;
        public event Action OnReturnedToMenu;

        public bool IsGameStarted => _isGameStarted;
        public GameMode GameMode => _gameMode;

        [Inject]
        private void Construct(GameConfig gameConfig, InputManager inputManager, UiManager uiManager, ObjectsManager objectsManager)
        {
            _inputManager = inputManager;
            _uiManager = uiManager;
            
            _inputManager.OnStart += StartGame;
            _inputManager.OnPause += Pause;
            _inputManager.OnPlay += Play;
            _inputManager.OnSettings += ShowSettings;
            _inputManager.OnBackToMenu += ReturnToMenu;
            _inputManager.OnSwitchMode += SwitchGameMode;
            
            _playerBall = objectsManager.GetObject<Ball>(gameConfig.PlayerBallId, GetBallCallback);
            if (_playerBall)
            {
                _playerBall.OnDead += HandlePlayerDeath;
            }
        }

        private void SwitchGameMode()
        {
            switch (_gameMode)
            {
                case GameMode.Player:
                    _gameMode = GameMode.AI;
                    break;
                case GameMode.AI:
                    _gameMode = GameMode.Player;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private async void Play()
        {
            _uiManager.HideElement<PauseScreen>();
            await _uiManager.ShowElement<GameplayScreen>();
            Time.timeScale = _defaultTimeScale;
            OnGameContinued?.Invoke();
        }

        private async void ShowSettings()
        {
            _uiManager.HideElement<MenuScreen>();
            await _uiManager.ShowElement<SettingsScreen>();
        }

        private async void Pause()
        {
            _uiManager.HideElement<GameplayScreen>();
            await _uiManager.ShowElement<PauseScreen>();
            Time.timeScale = 0f;
            OnGamePaused?.Invoke();
        }

        private async void StartGame()
        {
            _uiManager.HideElement<MenuScreen>();
            await _uiManager.ShowElement<GameplayScreen>();
            _isGameStarted = true;
            OnGameStarted?.Invoke();
        }
        
        private async void ReturnToMenu()
        {
            _isGameStarted = false;
            _uiManager.HideElement<SettingsScreen>();
            _uiManager.HideElement<PauseScreen>();
            _uiManager.HideElement<LoseScreen>();
            await _uiManager.ShowElement<MenuScreen>();
            Time.timeScale = _defaultTimeScale;
            OnReturnedToMenu?.Invoke();
        }

        public async void Initialize()
        {
            _defaultTimeScale = Time.timeScale;
            await _uiManager.ShowElement<MenuScreen>();
        }
        
        private void GetBallCallback(Object obj)
        {
            _playerBall = (Ball)obj;
            _playerBall.OnDead += HandlePlayerDeath;
        }

        private async void HandlePlayerDeath()
        {
            _isGameStarted = false;
            _uiManager.HideElement<GameplayScreen>();
            await _uiManager.ShowElement<LoseScreen>();
           OnGameEnded?.Invoke();
        }
    }
}