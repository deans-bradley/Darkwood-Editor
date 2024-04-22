using DarkwoodEditorWPF.Models;
using System.ComponentModel;

namespace DarkwoodEditorWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string? filePath;

        private RootViewModel? _rootViewModel;
        private SaveMS? _saveMS;
        private PsViewModel? _psViewModel;
        private IsViewModel? _isViewModel;
        private HsViewModel? _hsViewModel;
        private CnSViewModel? _cnsViewModel;
        private DrSViewModel? _drSViewModel;
        private OutSViewModel? _outSViewModel;
        private RaSViewModel? _raSViewModel;
        private FlaSViewModel? _flaSViewModel;
        private JoSViewModel? _joSViewModel;
        private NumSViewModel? _numSViewModel;
        private EvSViewModel? _evSViewModel;
        private ChspSViewModel? _chspSViewModel;
        private WorldGenSViewModel? _worldGenSViewModel;
        private GridSViewModel? _gridSViewModel;
        private BbdSViewModel? _bbdSViewModel;
        private MapSViewModel? _mapSViewModel;
        private NightScenSViewModel? _nightScenSViewModel;
        private ChDCViewModel? _chDCViewModel;
        private List<SavedObj>? _savedObjs;

        public MainViewModel()
        {
            _rootViewModel = new RootViewModel();
            _psViewModel = new PsViewModel();
        }

        public string? FilePath
        {
            get => filePath;
            set
            {
                filePath = value;
                OnPropertyChanged("FilePath");
            }
        }

        public RootViewModel? RootViewModel
        {
            get => _rootViewModel;
            set
            {
                _rootViewModel = value;
                OnPropertyChanged("RootViewModel");
            }
        }

        public SaveMS? SaveMS
        {
            get => _saveMS;
            set
            {
                _saveMS = value;
                OnPropertyChanged("SaveMS");
            }
        }

        public PsViewModel? PsViewModel
        {
            get => _psViewModel;
            set
            {
                _psViewModel = value;
                OnPropertyChanged("PsViewModel");
            }
        }

        public IsViewModel? IsViewModel
        {
            get => _isViewModel;
            set
            {
                _isViewModel = value;
                OnPropertyChanged("IsViewModel");
            }
        }

        public HsViewModel? HsViewModel
        {
            get => _hsViewModel;
            set
            {
                _hsViewModel = value;
                OnPropertyChanged("HsViewModel");
            }
        }

        public CnSViewModel? CnsViewModel
        {
            get => _cnsViewModel;
            set
            {
                _cnsViewModel = value;
                OnPropertyChanged("CnsViewModel");
            }
        }

        public DrSViewModel? DrSViewModel
        {
            get => _drSViewModel;
            set
            {
                _drSViewModel = value;
                OnPropertyChanged("DrSViewModel");
            }
        }

        public OutSViewModel? OutSViewModel
        {
            get => _outSViewModel;
            set
            {
                _outSViewModel = value;
                OnPropertyChanged("OutSViewModel");
            }
        }

        public RaSViewModel? RaSViewModel
        {
            get => _raSViewModel;
            set
            {
                _raSViewModel = value;
                OnPropertyChanged("RaSViewModel");
            }
        }

        public FlaSViewModel? FlaSViewModel
        {
            get => _flaSViewModel;
            set
            {
                _flaSViewModel = value;
                OnPropertyChanged("FlaSViewModel");
            }
        }

        public JoSViewModel? JoSViewModel
        {
            get => _joSViewModel;
            set
            {
                _joSViewModel = value;
                OnPropertyChanged("JoSViewModel");
            }
        }

        public NumSViewModel? NumSViewModel
        {
            get => _numSViewModel;
            set
            {
                _numSViewModel = value;
                OnPropertyChanged("NumSViewModel");
            }
        }

        public EvSViewModel? EvSViewModel
        {
            get => _evSViewModel;
            set
            {
                _evSViewModel = value;
                OnPropertyChanged("EvSViewModel");
            }
        }

        public ChspSViewModel? ChspSViewModel
        {
            get => _chspSViewModel;
            set
            {
                _chspSViewModel = value;
                OnPropertyChanged("ChspSViewModel");
            }
        }

        public WorldGenSViewModel? WorldGenSViewModel
        {
            get => _worldGenSViewModel;
            set
            {
                _worldGenSViewModel = value;
                OnPropertyChanged("WorldGenSViewModel");
            }
        }

        public GridSViewModel? GridSViewModel
        {
            get => _gridSViewModel;
            set
            {
                _gridSViewModel = value;
                OnPropertyChanged("GridSViewModel");
            }
        }

        public BbdSViewModel? BbdSViewModel
        {
            get => _bbdSViewModel;
            set
            {
                _bbdSViewModel = value;
                OnPropertyChanged("BbdSViewModel");
            }
        }

        public MapSViewModel? MapSViewModel
        {
            get => _mapSViewModel;
            set
            {
                _mapSViewModel = value;
                OnPropertyChanged("MapSViewModel");
            }
        }

        public NightScenSViewModel? NightScenSViewModel
        {
            get => _nightScenSViewModel;
            set
            {
                _nightScenSViewModel = value;
                OnPropertyChanged("NightScenSViewModel");
            }
        }

        public ChDCViewModel? ChDCViewModel
        {
            get => _chDCViewModel;
            set
            {
                _chDCViewModel = value;
                OnPropertyChanged("ChDCViewModel");
            }
        }

        public List<SavedObj>? SavedObjs
        {
            get => _savedObjs;
            set
            {
                _savedObjs = value;
                OnPropertyChanged("SavedObjs");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
