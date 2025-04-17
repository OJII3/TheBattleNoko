using System;
using NokoWars_test.Core.Interface;
using UnityEngine;
using R3;
using UnityEngine.SceneManagement;

namespace NokoWars_test.Core
{
    public class GameManager: IGameManager
    {
        private GameState currentScene;
        public event Action<GameState> OnGameStateChanged;
        public event Action OnResetGame;

        public GameState CurrentScene
        {
            get => currentScene;
            set
            {
                currentScene = value;
                OnGameStateChanged?.Invoke(currentScene);
            }
        }

        GameManager()
        {
            CurrentScene = GameState.Setup;
            // Observable.FromEvent<GameState>(
            //     h => OnGameStateChanged += h,
            //     h => OnGameStateChanged -= h
            //     ).Subscribe(_ =>TransitScene());
        }

        private void TransitScene()
        {
            switch (CurrentScene)
            {
                case GameState.Setup:
                    
                    break;
                case GameState.Title:
                    SceneManager.LoadScene("Explanation");
                    break;
                case GameState.Explanation:
                    SceneManager.LoadScene("Matching");
                    break;
                case GameState.Matching:
                    SceneManager.LoadScene("Play");
                    break;
                case GameState.Play:
                    SceneManager.LoadScene("Result");
                    break;
                case GameState.Result:
                    SceneManager.LoadScene("Title");
                    break;
            }
        }

        public void GotoScene(GameState state)
        {
            CurrentScene = state;
        }

        public void NextScene()
        {
            Debug.Log("Next Scene Called");
            switch (CurrentScene)
            {
                case GameState.Setup:
                    CurrentScene = GameState.Title;
                    SceneManager.LoadScene("Title");
                    break;
                case GameState.Title:
                    CurrentScene = GameState.Explanation;
                    SceneManager.LoadScene("Explanation");
                    break;
                case GameState.Explanation:
                    CurrentScene = GameState.Matching;
                    SceneManager.LoadScene("Matching");
                    break;
                case GameState.Matching:
                    CurrentScene = GameState.Play;
                    SceneManager.LoadScene("Play");
                    break;
                case GameState.Play:
                    CurrentScene = GameState.Result;
                    SceneManager.LoadScene("Result");
                    break;
                case GameState.Result:
                    CurrentScene = GameState.Title;
                    SceneManager.LoadScene("Title");
                    break;
            }
        }

        public void ResetGame()
        {
            CurrentScene = GameState.Setup;
        }
    }
}
