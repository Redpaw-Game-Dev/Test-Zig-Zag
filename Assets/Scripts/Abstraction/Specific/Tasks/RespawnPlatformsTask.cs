using TestZigZag.Platforms;
using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class RespawnPlatformsTask : Task
    {
        [SerializeField] private PlatformsController _platformsController;
    
        public override void Do(IInfo info = null)
        {
            _platformsController.RespawnPlatforms();
        }
    }
}