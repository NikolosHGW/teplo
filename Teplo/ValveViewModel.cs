using Core.Entities;

namespace Teplo
{

    public class ValveViewModel
    {
        public event ButtonImageDelegate ButtonImageChanged;

        public string ButtonImageSource =>
            _model.State == NewValveState.Active ? @"Resources/valveOPN.png" : @"Resources/valveCLS.png";

        private readonly Valve _model;

        public ValveViewModel(Valve model)
        {
            _model = model;

            _model.StateChanged += state => { ButtonImageChanged?.Invoke(ButtonImageSource); };
        }

        public void ToggleState() => _model.ToggleState();
    }
}