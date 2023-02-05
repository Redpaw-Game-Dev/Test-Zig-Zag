using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;
using Zenject;

namespace TestZigZag.Input
{
    public class InputEventsHandler : SerializedMonoBehaviour
    {
        [SerializeField] private Task[] _onStartTasks = new Task[0];
        [SerializeField] private Task[] _onTurnTasks = new Task[0];
        [SerializeField] private Task[] _onPauseTasks = new Task[0];
        [SerializeField] private Task[] _onContinueTasks = new Task[0];
        [SerializeField] private Task[] _backToMenuTasks = new Task[0];
        [SerializeField] private Task[] _onSwitchModeTasks = new Task[0];
        [SerializeField] private Task[] _onOpenSettingsTasks = new Task[0];

        private InputManager _inputManager;

        [Inject]
        private void Construct(DiContainer diContainer, InputManager inputManager)
        {
            _inputManager = inputManager;
            _onStartTasks.ForEach(diContainer.Inject);
            _onTurnTasks.ForEach(diContainer.Inject);
            _onPauseTasks.ForEach(diContainer.Inject);
            _onContinueTasks.ForEach(diContainer.Inject);
            _backToMenuTasks.ForEach(diContainer.Inject);
            _onSwitchModeTasks.ForEach(diContainer.Inject);
            _onOpenSettingsTasks.ForEach(diContainer.Inject);
        }
        
        private void HandleReturnToMenu() => DoTasks(_backToMenuTasks);
        private void HandleStart() => DoTasks(_onStartTasks);
        private void HandlePause() => DoTasks(_onPauseTasks);
        private void HandleContinue() => DoTasks(_onContinueTasks);
        private void HandleTurn() => DoTasks(_onTurnTasks);
        private void HandleSwitchMode() => DoTasks(_onSwitchModeTasks);
        private void HandleSettings() => DoTasks(_onOpenSettingsTasks);

        private void DoTasks(Task[] tasks) => tasks.ForEach(task => task.Do());

        private void OnEnable()
        {
            _inputManager.OnStart += HandleStart;
            _inputManager.OnPause += HandlePause;
            _inputManager.OnPlay += HandleContinue;
            _inputManager.OnBackToMenu += HandleReturnToMenu;
            _inputManager.OnTurn += HandleTurn;
            _inputManager.OnSwitchMode += HandleSwitchMode;
            _inputManager.OnSettings += HandleSettings;
        }
        
        private void OnDisable()
        {
            _inputManager.OnStart -= HandleStart;
            _inputManager.OnPause -= HandlePause;
            _inputManager.OnPlay -= HandleContinue;
            _inputManager.OnBackToMenu -= HandleReturnToMenu;
            _inputManager.OnTurn -= HandleTurn;
            _inputManager.OnSwitchMode -= HandleSwitchMode;
            _inputManager.OnSettings -= HandleSettings;
        }
    }
}