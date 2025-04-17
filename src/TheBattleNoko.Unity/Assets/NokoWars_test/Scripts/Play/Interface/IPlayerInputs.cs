namespace NokoWars_test.Scripts.Play.Interface
{
    public interface IPlayerInputs
    {
        void SelectStructure(int structureId);
        void MoveCursor_Up();
        void MoveCursor_Down();
        void MoveCursor_Left();
        void MoveCursor_Right();
        void PutStructure();
    }
}