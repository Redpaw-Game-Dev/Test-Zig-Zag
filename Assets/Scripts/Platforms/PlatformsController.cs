using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using Random = UnityEngine.Random;

namespace TestZigZag.Platforms
{
    public class PlatformsController : MonoBehaviour
    {
        [SerializeField] private Platform _platformPrefab;
        [SerializeField] private Vector2Int _maxBounds = Vector2Int.one * 9;
        [SerializeField] private Vector2Int _startBounds = new Vector2Int(6, 4);
        [SerializeField] private int _startCount = 49;
        [SerializeField] private int _passedBeforeFalling = 10;
        [SerializeField] private Platform _mainPlatform;
        [SerializeField] private Platform[] _preparedPlatforms = new Platform[0];

        private List<Platform> _activePlatforms = new List<Platform>();
        private Queue<Platform> _pooledPlatforms = new Queue<Platform>();
        private int _passedCount;
        private Vector2Int _currentBounds;
        private Vector3 _mainPlatformStartPos;
        private Vector3 _firstPlatformStartPos;

        public event Action<Platform> OnPlatformSpawned;
        
        private void Awake()
        {
            _currentBounds = _startBounds;
            foreach (var platform in _preparedPlatforms)
            {
                _activePlatforms.Add(platform);
                platform.OnDisabled += HandlePlatformDisabled;
                platform.OnPlayerExitPlatform += HandlePlayerExitPlatform;
            }
            _activePlatforms[0].OnPlayerEnterPlatform += HandlePlayerEnterFirstPlatform;
        }

        private void Start()
        {
            _mainPlatformStartPos = _mainPlatform.transform.position;
            _firstPlatformStartPos =  _activePlatforms[0].transform.position;
            SpawnStartPlatforms();
        }

        private void HandlePlayerEnterFirstPlatform(Platform platform)
        {
            platform.OnPlayerEnterPlatform -= HandlePlayerEnterFirstPlatform; 
            _mainPlatform.Fall();
        }

        [Button]
        private void RespawnPlatforms()
        {
            _currentBounds = _startBounds;
            _mainPlatform.transform.position = _mainPlatformStartPos;
            _mainPlatform.Enable();
            for (int i = 0; i < _activePlatforms.Count; i++)
            {
                Vector3 position = Vector3.zero;
                if (i == 0) position = _firstPlatformStartPos;
                else position = GetNextPosition(GetRandomDirection(), i - 1);
                _activePlatforms[i].transform.position = position;
            }
        }
        
        private void SpawnStartPlatforms()
        {
            for (int i = 0; i < _startCount; i++)
            {
                SpawnPlatformRandomDirection();
            }
        }

        [Button]
        private void SpawnPlatformRandomDirection()
        {
            
            SpawnPlatform(GetRandomDirection());
        }

        private Vector3 GetRandomDirection()
        {
            int random = Random.Range(0, 2);
            Vector3 direction = random == 0 ? Vector3.right : Vector3.forward;
            if (direction == Vector3.right && _currentBounds.x == _maxBounds.x) direction = Vector3.forward;
            else if (direction == Vector3.forward && _currentBounds.y == _maxBounds.y) direction = Vector3.right;
            
            if (direction == Vector3.right)
            {
                _currentBounds.x += 1;
                _currentBounds.y -= 1;
            }
            else if (direction == Vector3.forward)
            {
                _currentBounds.x -= 1;
                _currentBounds.y += 1;
            }
            
            return direction;
        }

        private Vector3 GetNextPosition(Vector3 direction, int index)
        {
            return _activePlatforms[index].transform.position +
                   direction * _platformPrefab.transform.localScale.x;
        }
        
        private void SpawnPlatform(Vector3 direction)
        {
            var newPosition = GetNextPosition(direction, _activePlatforms.Count - 1);
            Platform newPlatform = null;
            if (_pooledPlatforms.Count > 0)
            {
                newPlatform = _pooledPlatforms.Dequeue();
                newPlatform.transform.position = newPosition;
                newPlatform.Enable();
            }
            else
            {
                newPlatform = Instantiate(_platformPrefab, newPosition, Quaternion.identity, transform);
                newPlatform.OnDisabled += HandlePlatformDisabled;
                newPlatform.OnPlayerExitPlatform += HandlePlayerExitPlatform;
            }
            _activePlatforms.Add(newPlatform);
            OnPlatformSpawned?.Invoke(newPlatform);
        }

        private void HandlePlayerExitPlatform(Platform platform)
        {
            _passedCount++;
            if (_passedCount >= _passedBeforeFalling)
            {
                var platformToFall = _activePlatforms[0];
                _activePlatforms.RemoveAt(0);
                platformToFall.Fall();
                SpawnPlatformRandomDirection();
            }
        }

        private void HandlePlatformDisabled(Platform platform)
        {
            _pooledPlatforms.Enqueue(platform);
        }
    }
}