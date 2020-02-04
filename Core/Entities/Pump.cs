namespace Core.Entities
{
    public enum NewPumpState
    {
        Active,
        Passive
    }

    public delegate void PumpStateDelegate(NewPumpState state);

    public class Pump
    {
        public event PumpStateDelegate StateChanged;

        public NewPumpState State { get; private set; } = NewPumpState.Passive;

        public void ToggleState()
        {
            State = State == NewPumpState.Active ? NewPumpState.Passive : NewPumpState.Active;
            StateChanged?.Invoke(State);
        }
    }
}