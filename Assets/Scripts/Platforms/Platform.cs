using System;
using System.Timers;
using Cysharp.Threading.Tasks;
using Sirenix.OdinInspector;
using TestZigZag.Utilities;
using UnityEngine;

namespace TestZigZag.Platforms
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private LayerMask _playerMask;
        [SerializeField] private float _fallingDuration = 1f;
        [SerializeField] private float _fallingDistance = 10f;
        [SerializeField] private AnimationCurve _fallingCurve;
        [SerializeField] private bool _disableAfterFalling = true;

        private bool _isFalling;
        
        public event Action<Platform> OnPlayerEnterPlatform;
        public event Action<Platform> OnPlayerExitPlatform;
        public event Action<Platform> OnDisabled;

        private void OnTriggerEnter(Collider other)
        {
            if (_playerMask.Contains(other.gameObject.layer))
            {
                OnPlayerEnterPlatform?.Invoke(this);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (_playerMask.Contains(other.gameObject.layer))
            {
                OnPlayerExitPlatform?.Invoke(this);
            }
        }

        [Button]
        public async void Fall()
        {
            if(_isFalling) return;
            _isFalling = true;
            float t = 0f;
            Vector3 startPos = transform.position;
            Vector3 targetPos = transform.position + Vector3.down * _fallingDistance;
            while (t < 1f)
            {
                if (!_isFalling) return;
                transform.position = Vector3.Lerp(startPos, targetPos, _fallingCurve.Evaluate(t));
                t += Time.deltaTime / _fallingDuration;
                await UniTask.Yield();
            }
            t = 1f;
            transform.position = Vector3.Lerp(startPos, targetPos, _fallingCurve.Evaluate(t));
            _isFalling = false;
            if (_disableAfterFalling)
            {
                gameObject.SetActive(false);
            }
        }

        public void Reset()
        {
            _isFalling = false;
        }
        
        public void Enable()
        {
            gameObject.SetActive(true);
        }
        
        private void OnEnable()
        {
            _isFalling = false;
        }

        private void OnDisable()
        {
            OnDisabled?.Invoke(this);
        }
    }
}