using Microsoft.Win32;
using System.Windows;
using DarkwoodEditorWPF.Models;
using Newtonsoft.Json;
using System.IO;
using DarkwoodEditorWPF.ViewModels;

namespace DarkwoodEditorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string? filePath;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFile.InitialDirectory = $@"C:\Users\{Environment.UserName}\AppData\LocalLow\Acid Wizard Studio\Darkwood";

            openFile.ShowDialog();

            if (openFile.CheckFileExists && openFile.FileName != String.Empty)
            {
                filePath = openFile.FileName;
                Root root = DeserializeJson();

                AddData(root);
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        public Root DeserializeJson()
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Root>(json);
        }

        public void AddData(Root root)
        {
            RootViewModel rootViewModel = new RootViewModel
            {
                MajorVersion = root.majorVersion,
                MinorVersion = root.minorVersion,
                MajorVersionCompatibility = root.majorVersionCompatibility,
                MinorVersionCompatibility = root.minorVersionCompatibility,
                RCVersion = root.RCVersion,
                RCVersionCompatibility = root.RCVersionCompatibility
            };

            // Add more properties here

            DataContext = rootViewModel;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog();
        }
    }
}