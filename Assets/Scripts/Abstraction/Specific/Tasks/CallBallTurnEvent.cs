using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class CallBallTurnEvent : Task
    {
        [SerializeField] private Ball _ball;
        
        public override void Do(IInfo info = null)
        {
            _ball.CallTurnEvent();
        }
    }
}