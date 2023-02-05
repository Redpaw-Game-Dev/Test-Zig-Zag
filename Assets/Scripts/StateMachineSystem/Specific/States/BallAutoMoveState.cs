using System;
using Cysharp.Threading.Tasks;
using Sirenix.Serialization;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;

namespace TestZigZag.StateMachineSystem
{
    public class BallAutoMoveState : State
    {
        [OdinSerialize] private Task[] _onTurnTasks = new Task[0];
        [OdinSerialize] private Ball _ball;
        [OdinSerialize] private Rigidbody _ballRigidbody;
        [OdinSerialize] private ILabel _statsLabel;

        [SerializeField] private float _scanFrequency = 0.1f;
        [SerializeField] private float _scanDistance = 0.5f;
        [SerializeField] private Vector3 _scanerHalfExtents;
        [SerializeField] private LayerMask _groundMask;

        private SpeedFeature _speed;
        private Vector3 _currentDirection;
        private bool _isScanning;
        
        protected override void Initialize()
        {
            _currentDirection = Vector3.right;
            _speed = _ball.GetFeature<SpeedFeature>(_statsLabel) as SpeedFeature;
        }

        private void TurnPlayer()
        {
            _currentDirection = _currentDirection == Vector3.right ? Vector3.forward : Vector3.right;
            _onTurnTasks.ForEach(task => task.Do());
        }

        private async void Scan()
        {
            if(_isScanning) return;
            _isScanning = true;
            while (_isScanning)
            {
                Vector3 center = _ball.transform.position + _currentDirection * _scanDistance;
                var colliders = Physics.OverlapBox(center, _scanerHalfExtents, Quaternion.identity, _groundMask);
                
                if (colliders.Length == 0)
                {
                    TurnPlayer();
                }
                await UniTask.Delay(TimeSpan.FromSeconds(_scanFrequency), cancellationToken: _ball.GetCancellationTokenOnDestroy());
            }
        }

        protected override void EnterActions()
        {
            _ballRigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
            Scan();
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
            _isScanning = false;
        }

        public override bool Equals(object obj)
        {
            return obj is BallAutoMoveState;
        }

        public override int GetHashCode()
        {
            return nameof(BallAutoMoveState).GetHashCode();
        }
    }
}