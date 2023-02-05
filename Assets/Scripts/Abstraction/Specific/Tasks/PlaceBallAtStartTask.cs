using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class PlaceBallAtStartTask : Task
    {
        [SerializeField] private Ball _ball;
        
        public override void Do(IInfo info = null)
        {
            var startPosition = _ball.GetFeature<StartPositionFeature>(new StatsLabel()) as StartPositionFeature;
            _ball.gameObject.transform.position = startPosition.Value;
        }
    }
}