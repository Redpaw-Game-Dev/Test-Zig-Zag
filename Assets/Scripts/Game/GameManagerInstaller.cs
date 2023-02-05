using UnityEngine;
using Zenject;

namespace TestZigZag.Game
{
    public class GameManagerInstaller : MonoInstaller
    {
        [SerializeField] private GameConfig _gameConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<GameManager>().AsSingle().WithArguments(_gameConfig);
        }
    }
}