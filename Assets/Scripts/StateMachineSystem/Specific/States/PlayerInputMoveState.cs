using Sirenix.Serialization;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using TestZigZag.Input;
using UnityEngine;
using Zenject;

namespace TestZigZag.StateMachineSystem
{
    public class PlayerInputMoveState : State
    {
        [OdinSerialize] private Task[] _onTurnTasks;
        [OdinSerialize] private Ball _ball;
        [OdinSerialize] private Rigidbody _ballRigidbody;
        [OdinSerialize] private ILabel _statsLabel;

        [Inject] private InputManager _inputManager;
        private SpeedFeature _speed;
        private Vector3 _currentDirection;
        
        protected override void Initialize()
        {
            _speed = _ball.GetFeature<SpeedFeature>(_statsLabel) as SpeedFeature;
            _inputManager.OnTurn += TurnPlayer;
        }

        private void TurnPlayer()
        {
            _currentDirection = _currentDirection == Vector3.right ? Vector3.forward : Vector3.right;
            _onTurnTasks.ForEach(task => task.Do());
        }

        protected override void EnterActions()
        {
            _currentDirection = Vector3.right;
            _ballRigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
        }

        protected override void TickActions()
        {
            
        }

        protected override void FixedTickActions()
        {
            _ballRigidbody.velocity = _speed.Value * Time.fixedDeltaTime * _currentDirection;
        }

        protected override void LateTickActions()
        {
            
        }

        protected override void ExitActions()
        {
            _ballRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
        }

        public override bool Equals(object obj)
        {
            return obj is PlayerInputMoveState;
        }

        public override int GetHashCode()
        {
            return nameof(PlayerInputMoveState).GetHashCode();
        }
    }
}