using NokoWars_test.Core;
using UnityEngine;
using Zenject;

namespace NokoWars_test.Core.DI
{
    public class GameManagerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<GameManager>().AsSingle();
        }
    }    
}
