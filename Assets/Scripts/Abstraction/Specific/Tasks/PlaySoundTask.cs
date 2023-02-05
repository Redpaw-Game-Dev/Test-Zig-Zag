using UnityEngine;

namespace TestZigZag.Abstraction
{
    public class PlaySoundTask : Task
    {
        [SerializeField] private AudioSource _audioSource;
        
        public override void Do(IInfo info = null)
        {
            _audioSource.Play();
        }
    }
}