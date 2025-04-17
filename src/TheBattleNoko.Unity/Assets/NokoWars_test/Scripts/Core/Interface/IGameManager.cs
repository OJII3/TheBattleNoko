using System;

namespace NokoWars_test.Core.Interface
{
    public interface IGameManager
    {
        public event Action<GameState> OnGameStateChanged;
        public event Action OnResetGame;
        public GameState CurrentScene { get; set; }
        public void GotoScene(GameState state);
        public void NextScene();
        public void ResetGame();

    }
}