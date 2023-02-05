using UnityEngine;
using Zenject;

namespace TestZigZag.CrystalManagement
{
    public class CrystalManagerInstaller : MonoInstaller
    {
        [SerializeField] private CrystalConfig _crystalConfig;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<CrystalManager>().AsSingle().WithArguments(_crystalConfig);
        }
    }
}