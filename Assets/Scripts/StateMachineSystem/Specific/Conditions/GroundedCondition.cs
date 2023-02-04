using TestZigZag.Utilities;
using UnityEngine;

namespace TestZigZag.StateMachineSystem
{
    public class GroundedCondition : Condition
    {
        [SerializeField] private GroundDetector _groundDetector;
        
        public override bool IsFulfilled()
        {
            return _logicalNot ? !_groundDetector.IsGrounded : _groundDetector.IsGrounded;
        }
    }
}