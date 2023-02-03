using Zenject;

namespace TestZigZag.ObjectsManagement
{
    public class ObjectsManagerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<ObjectsManager>().AsSingle();
        }
    }
}