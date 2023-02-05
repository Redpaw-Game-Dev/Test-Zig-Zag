using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class VCamStartFollowTask : Task
    {
        [SerializeField] private CustomVCamBehaviour _customVCam;
        
        public override void Do(IInfo info = null)
        {
            _customVCam.StartFollowing();
        }
    }
}