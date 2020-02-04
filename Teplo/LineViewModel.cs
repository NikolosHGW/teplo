using Core.Entities;

namespace Teplo
{
    public delegate void OpacityDelegate(int opacity);

    public class LineViewModel
    {
        public event OpacityDelegate OpacityChanged;

        public int Opacity =>
            _model.State == NewLineState.Active ? 1 : 0;

        private readonly Line _model;

        public LineViewModel(Line model)
        {
            _model = model;

            _model.StateChanged += state => { OpacityChanged?.Invoke(Opacity); };
        }

        public void ToggleState() => _model.ToggleState();
    }
}