using System;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;

namespace TestZigZag.Utilities
{
    public class GroundDetector : SerializedMonoBehaviour
    {
        [SerializeField] private LayerMask _groundMask;
        [SerializeField] private float _rayLength = 0.1f;
        [SerializeField] private float _checkTime = 0.1f;
        [SerializeField] private bool _initialValue;
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

        private void Awake()
        {
            // IsGrounded = _initialValue;
        }

        private void Start()
        {
            CheckGround();
        }

        private void FixedUpdate()
        {
            if (_timer >= _checkTime)
            {
                _timer = 0f;
                CheckGround();
            }
            _timer += Time.fixedDeltaTime;
        }

        private void CheckGround()
        {
            var position = transform.position;
            Ray ray = new Ray(position, position + -transform.up);
            Debug.DrawRay(position, -transform.up * _rayLength, Color.yellow, 1f);
            // Debug.Log($"Raycast {Physics.Raycast(ray, _rayLength, _groundMask)}");
            if (_isGrounded && !Physics.Raycast(ray, _rayLength, _groundMask))
            {
                IsGrounded = false;
            }
            else if (!_isGrounded && Physics.Raycast(ray, _rayLength, _groundMask))
            {
                IsGrounded = true;
            }
            // Debug.Log($"Grounded {_isGrounded}");
        }
    }
}