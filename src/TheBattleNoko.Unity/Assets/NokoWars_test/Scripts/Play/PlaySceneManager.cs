using System.Collections.Generic;
using NokoWars_test.Scripts.Play.Interface;

namespace NokoWars_test.Scripts.Play
{
    public class PlaySceneManager
    {
        private List<List<IStructure>> stage;
        private List<IUnit> units;

        public bool isPlacable(int x, int y)
        {
            return false;
        }
    }
}