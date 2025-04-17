using NokoWars_test.Setup;
using UnityEngine;
using Zenject;

public class SetupSceneManagerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<SetupSceneManager>().AsSingle();
    }
}