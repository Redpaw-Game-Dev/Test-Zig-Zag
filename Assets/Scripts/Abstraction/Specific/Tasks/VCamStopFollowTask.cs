using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class VCamStopFollowTask : Task
    {
        [SerializeField] private CustomVCamBehaviour _customVCam;
        
        public override void Do(IInfo info = null)
        {
            _customVCam.StopFollowing();
        }
    }
}