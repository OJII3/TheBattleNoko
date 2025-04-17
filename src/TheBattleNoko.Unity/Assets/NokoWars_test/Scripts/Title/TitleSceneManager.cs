using System;
using NokoWars_test.Core;
using NokoWars_test.Core.Interface;
using NokoWars_test.Core.Interface;
using Zenject;
using R3;
using UnityEngine.InputSystem;

namespace NokoWars_test.Title
{
    public class TitleSceneManager: IScene,IInitializable,IDisposable
    {
        [Inject] IGameManager gameManager;
        public TitleInputs TitleInputs { get; private set; }
        TitleSceneManager()
        {
            TitleInputs = new TitleInputs();
            TitleInputs.Enable();
        }

        public void Initialize()
        {
            Observable.FromEvent<InputAction.CallbackContext>(
                h => TitleInputs.Test.NextScene.performed += h,
                h => TitleInputs.Test.NextScene.performed -= h
            ).Subscribe(_ =>nextScene());
        }
        
        public void nextScene()
        {
            gameManager.NextScene();
        }

        public void resetScene()
        {
            gameManager.ResetGame();
        }

        public  void resetGame()
        {
            gameManager.GotoScene(GameState.Setup);
        }

        public void Dispose()
        {
            TitleInputs.Disable();
        }
    }
}