using NokoWars_test.Title;
using UnityEngine;
using Zenject;

public class TitleSceneManagerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesTo<TitleSceneManager>().AsSingle();
    }
}