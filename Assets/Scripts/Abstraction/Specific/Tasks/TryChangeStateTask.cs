using TestZigZag.StateMachineSystem;
using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class TryChangeStateTask : Task
    {
        [SerializeField] private SerializedStateMachine _stateMachine;
        
        public override void Do(IInfo info = null)
        {
            _stateMachine.TryChangeState();
        }
    }
}