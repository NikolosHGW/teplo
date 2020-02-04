namespace Teplo
{
    public delegate void StateDelegate(bool state);

    public abstract class WaterControlElement
    {
        public event StateDelegate StateChanged;

        public int Number { get; }

        public bool IsActive { get; private set; }

        protected WaterControlElement(int number)
        {
            Number = number;
        }

        public void ToggleState()
        {
            IsActive = ! IsActive;
            StateChanged?.Invoke(IsActive);
        }
    }
}
