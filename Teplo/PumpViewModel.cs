using Core.Entities;

namespace Teplo
{
    public delegate void ButtonImageDelegate(string source);

    public class PumpViewModel
    {
        public event ButtonImageDelegate ButtonImageChanged;

        public string ButtonImageSource =>
            _model.State == NewPumpState.Active ? @"Resources/nasos_green.png" : "Resources/nasos.png";

        private readonly Pump _model;

        public PumpViewModel(Pump model)
        {
            _model = model;

            _model.StateChanged += state => { ButtonImageChanged?.Invoke(ButtonImageSource); };
        }

        public void ToggleState() => _model.ToggleState();
    }
}