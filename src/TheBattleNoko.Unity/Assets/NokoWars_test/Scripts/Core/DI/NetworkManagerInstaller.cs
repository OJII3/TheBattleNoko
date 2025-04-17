using NokoWars_test.Core;
using Zenject;

namespace NokoWars_test.Core.DI
{
    public class NetworkManagerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<NetWorkManager>().AsSingle();
        }
    }
}
