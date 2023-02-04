using System;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;

namespace TestZigZag.Utilities
{
    public class GroundDetector : SerializedMonoBehaviour
    {
        [SerializeField] private Transform _transform;
        [SerializeField] private Vector3 _halfExtents;
        [SerializeField] private Vector3 _centerOffset;
        [SerializeField] private LayerMask _groundMask;
        [SerializeField] private float _scanFrequency = 0.1f;
        [SerializeField] private Task[] _onGroundedChangedTasks = new Task[0];
        
        private bool _isGrounded;
        private float _timer;

        public bool IsGrounded
        {
            get => _isGrounded;
            private set
            {
                _isGrounded = value;
                OnGroundedChanged?.Invoke(_isGrounded);
                _onGroundedChangedTasks.ForEach(task => task.Do(new GroundDetectorInfo(_isGrounded)));
            }
        }

        public event Action<bool> OnGroundedChanged;

        private void Start()
        {
            CheckGround();
        }
        
        private async void CheckGround()
        {
            while (true)
            {
                Vector3 center = _transform.position + _centerOffset;
                var colliders = Physics.OverlapBox(center, _halfExtents, Quaternion.identity, _groundMask);
                
                if (colliders.Length > 0)
                {
                    if (!_isGrounded) IsGrounded = true;
                }
                else if(_isGrounded)
                {
                    IsGrounded = false;
                }
                await UniTask.Delay(TimeSpan.FromSeconds(_scanFrequency), cancellationToken: this.GetCancellationTokenOnDestroy());
            }
            
        }
    }
}