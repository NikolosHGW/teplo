using System.Collections.ObjectModel;
using System.Linq;
using Core.Entities;
using Prism.Commands;
using Prism.Mvvm;

namespace Teplo
{
    public class GameViewModel : BindableBase
    {
        private readonly Game _model;
        private readonly PumpViewModel[] _pumpViewModels;
        private readonly ValveViewModel[] _valveViewModels;
        private readonly LineViewModel[] _lineViewModels;

        public DelegateCommand<string> TogglePumpStateCommand { get; }
        public DelegateCommand<string> ToggleValveStateCommand { get; }
        public DelegateCommand<string> ToggleLineStateCommand { get; }

        public ObservableCollection<string> PumpImageSources { get; set; } 
        public ObservableCollection<string> ValveImageSources { get; set; } 
        public ObservableCollection<int> LineOpacities { get; set; } 

        public GameViewModel()
        {
            _model = new Game();
            _pumpViewModels = _model.Pumps
                .Select(x => new PumpViewModel(x))
                .ToArray();
            _valveViewModels = _model.Valves
                .Select(x => new ValveViewModel(x))
                .ToArray();
            _lineViewModels = _model.Lines
                .Select(x => new LineViewModel(x))
                .ToArray();

            TogglePumpStateCommand = new DelegateCommand<string>(TogglePumpState);
            ToggleValveStateCommand = new DelegateCommand<string>(ToggleValveState);
            ToggleLineStateCommand = new DelegateCommand<string>(ToggleLineState);

            PumpImageSources = new ObservableCollection<string>(_pumpViewModels.Select(x => x.ButtonImageSource));
            ValveImageSources = new ObservableCollection<string>(_valveViewModels.Select(x => x.ButtonImageSource));
            LineOpacities = new ObservableCollection<int>(_lineViewModels.Select(x => x.Opacity));

            for (int i = 0; i < _pumpViewModels.Length; i++)
            {
                var i1 = i;
                _pumpViewModels[i].ButtonImageChanged += (src) =>
                {
                    PumpImageSources[i1] = _pumpViewModels[i1].ButtonImageSource;
                };
            }

            for (int i = 0; i < _valveViewModels.Length; i++)
            {
                var i1 = i;
                _valveViewModels[i].ButtonImageChanged += (src) =>
                {
                    ValveImageSources[i1] = _valveViewModels[i1].ButtonImageSource;
                };
            }

            for (int i = 0; i < _lineViewModels.Length; i++)
            {
                var i1 = i;
                _lineViewModels[i].OpacityChanged += (src) =>
                {
                    LineOpacities[i1] = _lineViewModels[i1].Opacity;
                };
            }
        }

        private void ToggleLineState(string index)
        {
            _lineViewModels[int.Parse(index)].ToggleState();
        }

        private void ToggleValveState(string index)
        {
            _valveViewModels[int.Parse(index)].ToggleState();
        }

        private void TogglePumpState(string index)
        {
            _pumpViewModels[int.Parse(index)].ToggleState();
        }
    }
}