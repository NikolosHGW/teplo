namespace Core.Entities
{
    public enum NewLineState
    {
        Active,
        Passive,
    }

    public delegate void LineStateDelegate(NewLineState state);

    public class Line
    {
        public event LineStateDelegate StateChanged;

        public NewLineState State { get; private set; } = NewLineState.Passive;

        public void ToggleState()
        {
            State = State == NewLineState.Active ? NewLineState.Passive : NewLineState.Active;
            StateChanged?.Invoke(State);
        }
    }
}