namespace Core.Entities
{
    public enum NewValveState
    {
        Active,
        Passive,
    }

    public delegate void ValveStateDelegate(NewValveState state);

    public class Valve
    {
        public event ValveStateDelegate StateChanged;

        public NewValveState State { get; private set; } = NewValveState.Passive;

        public void ToggleState()
        {
            State = State == NewValveState.Active ? NewValveState.Passive : NewValveState.Active;
            StateChanged?.Invoke(State);
        }
    }
}