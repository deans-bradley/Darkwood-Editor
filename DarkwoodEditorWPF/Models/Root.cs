namespace DarkwoodEditorWPF.Models
{
    public class Root
    {
        public int majorVersion { get; set; }
        public int minorVersion { get; set; }
        public int majorVersionCompatibility { get; set; }
        public int minorVersionCompatibility { get; set; }
        public int RCVersion { get; set; }
        public int RCVersionCompatibility { get; set; }
        public SaveMS saveMS { get; set; }
        public PS pS { get; set; }
        public IS iS { get; set; }
        public HS hS { get; set; }
        public CnS cnS { get; set; }
        public DrS drS { get; set; }
        public OutS outS { get; set; }
        public RaS raS { get; set; }
        public FlaS flaS { get; set; }
        public JoS joS { get; set; }
        public NumS numS { get; set; }
        public EvS evS { get; set; }
        public ChspS chspS { get; set; }
        public WorldGenS worldGenS { get; set; }
        public GridS gridS { get; set; }
        public BbdS bbdS { get; set; }
        public MapS mapS { get; set; }
        public NightScenS nightScenS { get; set; }
        public ChDC chDC { get; set; }
        public List<SavedObj> savedObjs { get; set; }
    }
}
