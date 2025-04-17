using System;
using NokoWars_test.Core.Interface;
using Zenject;
using R3;
using UnityEngine.InputSystem;


namespace NokoWars_test.Setup
{
    public class SetupSceneManager : IScene,IInitializable,IDisposable
    {
        [Inject] INetworkManager networkManager;
        [Inject] IGameManager gameManager;
        public SetupInputs SetupInputs { get; private set; }

        SetupSceneManager()
        {
            SetupInputs = new SetupInputs();
            SetupInputs.Enable();
        }
        
        // public void registerAddress(string ip, int port)
        // {
        //     networkManager.setSelfAddress(new Tuple<string,int>(ip, port));
        // }
        
        public void Initialize()
        {
            Observable.FromEvent<InputAction.CallbackContext>(
                h => SetupInputs.Test.NextScene.performed += h,
                h => SetupInputs.Test.NextScene.performed -= h
            ).Subscribe(_ =>nextScene());
        }

        public void nextScene()
        {
            gameManager.NextScene();
        }

        public void resetScene()
        {
            
        }

        public void resetGame()
        {
            
        }

        public void Dispose()
        {
            SetupInputs.Disable();
        }

        
    }
}