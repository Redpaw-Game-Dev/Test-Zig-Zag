using System;
using TestZigZag.Utilities;
using UnityEngine;

namespace TestZigZag.CrystalManagement
{
    public class Crystal : MonoBehaviour
    {
        [SerializeField] private int _value = 1;
        [SerializeField] private LayerMask _playerMask;

        public int Value => _value;

        public event Action<Crystal> OnCollected;
        
        private void OnTriggerEnter(Collider other)
        {
            if (_playerMask.Contains(other.gameObject.layer))
            {
                gameObject.SetActive(false);
                OnCollected?.Invoke(this);
            }
        }
    }
}