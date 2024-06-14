using Microsoft.Win32;
using System.Windows;
using DarkwoodEditorWPF.Models;
using Newtonsoft.Json;
using System.IO;
using DarkwoodEditorWPF.ViewModels;
using System.Windows.Input;
using DarkwoodEditorWPF.Views;
using System.Diagnostics;
using DarkwoodEditorWPF.Helpers;

namespace DarkwoodEditorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SavData data = new SavData();

        public MainWindow()
        {
            InitializeComponent();

#if DEBUG
            string filePath = $@"C:\Users\{Environment.UserName}\Documents\prof1\sav_test.json";

            Root root = DeserializeJson(filePath) ?? throw new Exception("Error deserializing JSON.");
            MainViewModel mainViewModel = data.LoadData(filePath, root);

            DataContext = mainViewModel;

            MainContentPage.Navigate(new Uri("Views/MainContent.xaml", UriKind.Relative));
#endif
        }

        private void OpenFileDialog()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";
            openFile.InitialDirectory = $@"C:\Users\{Environment.UserName}\AppData\LocalLow\Acid Wizard Studio\Darkwood";

            openFile.ShowDialog();

            if (openFile.CheckFileExists && openFile.FileName != String.Empty)
            {
                string filePath = openFile.FileName;

                if (DeserializeJson(filePath) != null)
                {
                    Root root = DeserializeJson(filePath) ?? throw new Exception("Error deserializing JSON.");
                    MainViewModel mainViewModel = data.LoadData(filePath, root);

                    //rootUserControl.DataContext = mainViewModel.RootViewModel;
                    DataContext = mainViewModel;

                    MainContentPage.Navigate(new Uri("Views/MainContent.xaml", UriKind.Relative));
                }
            }
            else if (openFile.CheckFileExists == false)
            {
                MessageBox.Show("File does not exist.");
            }
        }

        public Root? DeserializeJson(string filePath)
        {
            string json = File.ReadAllText(filePath);

            if (JsonConvert.DeserializeObject<Root>(json) is not null)
            {
                return JsonConvert.DeserializeObject<Root>(json);
            }
            else
            {
                MessageBox.Show("Error deserializing JSON.");
                return null;
            }
        }

        public string SerializeToJson(Root root)
        {
            return JsonConvert.SerializeObject(root, Formatting.Indented);
        }

        //
        // File Menu Items
        //
        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog();
        }

        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MainViewModel mainViewModel = (MainViewModel)DataContext;

            if (mainViewModel is null)
            {
                MessageBox.Show("No file open.");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = mainViewModel.FilePath;
                saveFile.Filter = "DAT Files (*.dat)|*.dat|All Files (*.*)|*.*";

                saveFile.ShowDialog();

                if (saveFile.FileName != String.Empty)
                {
                    string filePath = saveFile.FileName;

                    Debug.WriteLine(filePath);

                    Root? root = data.SaveData(mainViewModel);
                    if (root != null)
                    {
                        string serializedJson = SerializeToJson(root);

                        string newFilePath = Path.ChangeExtension(filePath + "-test", ".dat");
                        File.WriteAllText(newFilePath, serializedJson);

                        MessageBox.Show($"File saved as {newFilePath}");
                    }
                }
                else
                {
                    MessageBox.Show("File does not exist.");
                }
            }
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Close");
        }

        private void exitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Add a confirmation dialog
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
            MainContent? mainContent = MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentLeft("Views/Pages/PlayerStatePage.xaml");
            }
        }

        private void playerMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent? mainContent = MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentLeft("Views/Pages/PlayerPage.xaml");
            }
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
        // TODO: Add help menu items
        //

        //
        // Window buttons
        //
        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Add a confirmation dialog
            Environment.Exit(0);
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// 
        /// Interaction logic for dragging the window.
        ///
        private void windowGrd_MouseDown(object sender, MouseButtonEventArgs e)
        {
                base.OnMouseLeftButtonDown(e);
                DragMove();
        }

        private void MainContentPage_ContentRendered(object sender, EventArgs e)
        {
            MainContent? mainContent = MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentLeft("Views/Pages/PlayerStatePage.xaml");
            }
        }

        //
        // For testing
        //
        private void testBtn_Click(object sender, RoutedEventArgs e)
        {
            //ConvertCollections convert = new ConvertCollections();

            //MainViewModel mainViewModel = (MainViewModel)DataContext;
            //PsViewModel psViewModel = mainViewModel.PsViewModel ?? throw new NullReferenceException();

            //convert.ConvertObservableCollectionToCraftedItemViewModelList(psViewModel.CraftedItems);
        }
    }
}