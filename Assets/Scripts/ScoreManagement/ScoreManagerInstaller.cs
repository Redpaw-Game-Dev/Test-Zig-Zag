using UnityEngine;
using Zenject;

namespace TestZigZag.ScoreManagement
{
    public class ScoreManagerInstaller : MonoInstaller
    {
        [SerializeField] private string ballId = "PlayerBall";
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ScoreManager>().AsSingle().WithArguments(ballId);
        }
    }
}