using System;
using UnityEngine;

namespace TestZigZag.Abstraction
{
    public abstract class Vector3Feature : IFeature<Vector3>
    {
        [SerializeField] protected Vector3 _value;
        
        public virtual string Name => "Vector3";

        public Vector3 Value
        {
            get => _value;
            set
            {
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        public event Action<Vector3> OnValueChanged;

        public IFeature GetInstance() => this;

        public void CopyFrom(IFeature feature)
        {
            if (feature is Vector3Feature vector3Feature)
            {
                _value = vector3Feature._value;
            }
        }
        
        public override bool Equals(object obj)
        {
            return obj is Vector3Feature;
        }

        public override int GetHashCode()
        {
            return nameof(Vector3Feature).GetHashCode();
        }
    }
}