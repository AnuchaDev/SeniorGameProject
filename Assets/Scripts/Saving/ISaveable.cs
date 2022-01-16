namespace GameDev.saving
{

    public interface ISaveable
    {
        object CaptureState();
        void RestoreState(object state);
    }
}