using Microsoft.Win32;
using System.Windows;
using DarkwoodEditorWPF.Models;
using Newtonsoft.Json;
using System.IO;
using DarkwoodEditorWPF.ViewModels;
using System.Windows.Input;
using DarkwoodEditorWPF.Views;

namespace DarkwoodEditorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
                string filePath = openFile.FileName;
                Root root = DeserializeJson(filePath);

                MainContent.Navigate(new Uri("Views/StartPage.xaml", UriKind.Relative));
                AddData(filePath, root);
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        public Root DeserializeJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Root>(json);
        }

        public void AddData(string filePath, Root root)
        {
            RootViewModel rootView = new RootViewModel
            {
                MajorVersion = root.majorVersion,
                MinorVersion = root.minorVersion,
                MajorVersionCompatibility = root.majorVersionCompatibility,
                MinorVersionCompatibility = root.minorVersionCompatibility,
                RCVersion = root.RCVersion,
                RCVersionCompatibility = root.RCVersionCompatibility
            };

            PS ps = root.pS;
            PsViewModel psView = new PsViewModel
            {
                Health = ps.health,
                Stamina = ps.stamina,
                Experience = ps.experience,
                CurrentLevel = ps.currentLevel,
                HealthUpgrades = ps.healthUpgrades,
                StaminaUpgrades = ps.staminaUpgrades,
                HotbarUpgrades = ps.hotbarUpgrades,
                InventoryUpgrades = ps.inventoryUpgrades,
                LastTimeAte = ps.lastTimeAte,
                Saturation = ps.saturation,
                FedToday = ps.fedToday,
                ExpMachineId = ps.expMachineId,
                ExaminedExpMachine = ps.examinedExpMachine,
                GotHitAtLeastOnce = ps.gotHitAtLeastOnce,
                DiedAtLeastOnce = ps.diedAtLeastOnce
            };

            MainViewModel mainViewModel = new MainViewModel
            {
                FilePath = filePath,
                PsViewModel = psView
            };

            rootUserControl.DataContext = rootView;
            DataContext = mainViewModel;
        }

        //
        // File Menu Items
        //
        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            openFileDialog();
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainViewModel mainViewModel = (MainViewModel)DataContext;

            SaveFileDialog saveFile = new SaveFileDialog();

            if (mainViewModel is null)
            {
                MessageBox.Show("No file open.");
            }
            else
            {
                saveFile.InitialDirectory = mainViewModel.FilePath;
                saveFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";

                saveFile.ShowDialog();
            }
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Close");
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void ExitCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        //
        // Edit Menu Items
        //

        private void playerStatsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var startPage = new StartPage();
            startPage.DataContext = DataContext;

            MainContent.Navigate(new Uri("Views/StartPage.xaml", UriKind.Relative));
        }

        private void playerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Uri("Views/PlayerPage.xaml", UriKind.Relative));
        }

        private void worldMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void stroyMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void timeAndWeatherMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        //
        // Help Menu Items
        //
    }
}