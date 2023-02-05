using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;
using Zenject;

namespace TestZigZag.Game
{
    public class GameEventHandler : SerializedMonoBehaviour
    {
        [SerializeField] private Task[] _gameStartTasks = new Task[0];
        [SerializeField] private Task[] _gameEndTasks = new Task[0];
        [SerializeField] private Task[] _gamePauseTasks = new Task[0];
        [SerializeField] private Task[] _gameContinuedTasks = new Task[0];
        [SerializeField] private Task[] _backToMenuTasks = new Task[0];

        private GameManager _gameManager;

        [Inject]
        private void Construct(DiContainer diContainer, GameManager gameManager)
        {
            _gameManager = gameManager;
            _gameStartTasks.ForEach(diContainer.Inject);
            _gameEndTasks.ForEach(diContainer.Inject);
            _gamePauseTasks.ForEach(diContainer.Inject);
            _gameContinuedTasks.ForEach(diContainer.Inject);
            _backToMenuTasks.ForEach(diContainer.Inject);
        }
        
        private void HandleReturnedToMenu() => DoTasks(_backToMenuTasks);
        private void HandleGameStarted() => DoTasks(_gameStartTasks);
        private void HandleGamePaused() => DoTasks(_gamePauseTasks);
        private void HandleGameContinued() => DoTasks(_gameContinuedTasks);
        private void HandleGameEnded() => DoTasks(_gameEndTasks);

        private void DoTasks(Task[] tasks) => tasks.ForEach(task => task.Do());

        private void OnEnable()
        {
            _gameManager.OnGameStarted += HandleGameStarted;
            _gameManager.OnGamePaused += HandleGamePaused;
            _gameManager.OnGameContinued += HandleGameContinued;
            _gameManager.OnReturnedToMenu += HandleReturnedToMenu;
            _gameManager.OnGameEnded += HandleGameEnded;
        }
        
        private void OnDisable()
        {
            _gameManager.OnGameStarted -= HandleGameStarted;
            _gameManager.OnGamePaused -= HandleGamePaused;
            _gameManager.OnGameContinued -= HandleGameContinued;
            _gameManager.OnReturnedToMenu -= HandleReturnedToMenu;
            _gameManager.OnGameEnded -= HandleGameEnded;
        }
    }
}