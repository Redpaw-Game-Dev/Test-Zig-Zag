using System;
using System.Collections.Generic;
using TestZigZag.Game;
using TestZigZag.ObjectsManagement;
using TestZigZag.Platforms;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace TestZigZag.CrystalManagement
{
    public class CrystalManager : IInitializable
    {
        private CrystalConfig _crystalConfig;
        private PlatformsController _platformsController;
        private Queue<Crystal> _pooledCrystals = new Queue<Crystal>();
        private List<Crystal> _activeCrystals = new List<Crystal>();
        private int _collectedCrystalsCount;

        public int CollectedCrystalsCount => _collectedCrystalsCount;

        public event Action<int> OnCrystalCollected;

        [Inject]
        private void Construct(CrystalConfig crystalConfig, GameManager gameManager, ObjectsManager objectsManager)
        {
            _crystalConfig = crystalConfig;
            gameManager.OnReturnedToMenu += PoolAllCrystals;

            _platformsController = objectsManager.GetObject<PlatformsController>(crystalConfig.PlatformsControllerId,
                GetPlatformsControllerCallback);
        }

        private void PoolAllCrystals()
        {
           _activeCrystals.ForEach(_pooledCrystals.Enqueue);
           _activeCrystals.Clear();
        }

        public void Initialize()
        {
            
        }
        
        private void GetPlatformsControllerCallback(Object obj)
        {
            _platformsController = (PlatformsController)obj;
            _platformsController.OnPlatformSpawned += HandlePlatformSpawned;
        }

        private void HandlePlatformSpawned(Platform platform)
        {
            float random = Random.Range(0f, 1f);
            if(random <= _crystalConfig.SpawnChance) SpawnCrystal(platform.transform);
        }

        private void SpawnCrystal(Transform parent)
        {
            Crystal crystal = _pooledCrystals.Count == 0
                ? SpawnNewCrystal()
                : _pooledCrystals.Dequeue();
            _activeCrystals.Add(crystal);
            var crystalTransform = crystal.transform;
            crystalTransform.parent = parent;
            crystalTransform.localPosition = Vector3.zero;
        }

        private Crystal SpawnNewCrystal()
        {
            Crystal crystal = GameObject.Instantiate(_crystalConfig.CrystalPrefab);
            crystal.OnCollected += HandleCrystalCollected;
            return crystal;
        }

        private void HandleCrystalCollected(Crystal crystal)
        {
            _activeCrystals.Remove(crystal);
            _collectedCrystalsCount++;
            _pooledCrystals.Enqueue(crystal);
            OnCrystalCollected?.Invoke(crystal.Value);
        }
    }
}