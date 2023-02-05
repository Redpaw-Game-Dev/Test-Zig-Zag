using Sirenix.OdinInspector;
using Sirenix.Utilities;
using TestZigZag.Abstraction;
using UnityEngine;
using Zenject;

namespace TestZigZag.CrystalManagement
{
    public class CrystalCollectedEventHandler : SerializedMonoBehaviour
    {
        [SerializeField] private Task[] _tasks = new Task[0];
        
        [Inject] private CrystalManager _crystalManager;
        
        private void HandleCrystalCollected(int value)
        {
            _tasks.ForEach(task => task.Do());
        }

        private void OnEnable()
        {
            _crystalManager.OnCrystalCollected += HandleCrystalCollected;
        }
        
        private void OnDisable()
        {
            _crystalManager.OnCrystalCollected -= HandleCrystalCollected;
        }
    }
}