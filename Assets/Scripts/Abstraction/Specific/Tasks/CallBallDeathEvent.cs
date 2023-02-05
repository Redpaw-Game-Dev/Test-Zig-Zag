using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class CallBallDeathEvent : Task
    {
        [SerializeField] private Ball _ball;
        
        public override void Do(IInfo info = null)
        {
            _ball.CallDeathEvent();
        }
    }
}