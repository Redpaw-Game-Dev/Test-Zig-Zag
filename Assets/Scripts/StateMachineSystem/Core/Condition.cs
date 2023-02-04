using UnityEngine;

namespace TestZigZag.StateMachineSystem
{
    public abstract class Condition
    {
        [SerializeField] protected bool _isNecessary;
        [SerializeField] protected bool _logicalNot;

        public bool IsNecessary => _isNecessary;

        public abstract bool IsFulfilled();
    }
}