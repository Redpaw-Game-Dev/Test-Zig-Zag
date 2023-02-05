using UnityEngine;

namespace TestZigZag.Utilities
{
    public class RotationAnimation : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotationAngle;
        
        private void Update()
        {
            transform.Rotate(_rotationAngle * Time.deltaTime);
        }
    }
}