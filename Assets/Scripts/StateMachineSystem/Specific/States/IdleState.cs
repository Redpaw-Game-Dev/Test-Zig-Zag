using Sirenix.Serialization;
using TestZigZag.Abstraction;
using UnityEngine;

namespace TestZigZag.StateMachineSystem
{
    public class IdleState : State
    {
        [OdinSerialize] private Rigidbody _ballRigidbody;
        
        protected override void Initialize()
        {
            
        }

        protected override void EnterActions()
        {
            _ballRigidbody.isKinematic = true;
        }

        protected override void TickActions()
        {
            
        }

        protected override void FixedTickActions()
        {
            
        }

        protected override void LateTickActions()
        {
            
        }

        protected override void ExitActions()
        {
            _ballRigidbody.isKinematic = false;
        }
                
        public override bool Equals(object obj)
        {
            return obj is IdleState;
        }

        public override int GetHashCode()
        {
            return nameof(IdleState).GetHashCode();
        }
    }
}