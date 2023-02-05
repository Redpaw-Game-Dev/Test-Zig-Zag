using UnityEngine;
using Zenject;

namespace TestZigZag.UI
{
    public class UiManagerInstaller : MonoInstaller
    {
        [SerializeField] protected UiConfig _uiConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<UiManager>().AsSingle().WithArguments(_uiConfig);
        }
    }
}