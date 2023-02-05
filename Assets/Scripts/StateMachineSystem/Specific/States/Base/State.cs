using System;
using Sirenix.Serialization;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using Zenject;

namespace TestZigZag.StateMachineSystem
{
    public abstract class State : IState
    {
        [OdinSerialize] protected Task[] _onEnterTasks = new Task[0];
        [OdinSerialize] protected Task[] _onExitTasks = new Task[0];
        
        private bool _isInitialized;
        
        public event Action OnEntered;
        public event Action OnExited;
        
        protected abstract void Initialize();
        protected abstract void EnterActions();
        protected abstract void TickActions();
        protected abstract void FixedTickActions();
        protected abstract void LateTickActions();
        protected abstract void ExitActions();

        [Inject]
        private void Construct(DiContainer diContainer)
        {
            _onEnterTasks.ForEach(diContainer.Inject);
            _onExitTasks.ForEach(diContainer.Inject);
        } 
        
        public void Enter()
        {
            if (!_isInitialized)
            {
                Initialize();
                _isInitialized = true;
            }
            _onEnterTasks.ForEach(task => task.Do());
            EnterActions();
            OnEntered?.Invoke();
        }

        public void Tick()
        {
            TickActions();
        }

        public void FixedTick()
        {
            FixedTickActions();
        }

        public void LateTick()
        {
            LateTickActions();
        }

        public void Exit()
        {
            _onExitTasks.ForEach(task => task.Do());
            ExitActions();
            OnExited?.Invoke();
        }
    }
}