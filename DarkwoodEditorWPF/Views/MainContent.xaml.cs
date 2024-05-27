using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views
{
    /// <summary>
    /// Interaction logic for MainContent.xaml
    /// </summary>
    public partial class MainContent : Page
    {
        public MainContent()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel);
        }

        public void SetContentLeft(string? uri)
        {
            if (uri != null)
            {
                contentLeft.Navigate(new Uri(uri, UriKind.Relative));
            }
            else
            {
                contentLeft.Content = null;
            }
        }

        public void SetContentRight(string? uri)
        {
            if (uri != null) 
            {
                contentRight.Navigate(new Uri(uri, UriKind.Relative));
            }
            else
            {
                contentRight.Content = null;
            }
        }
    }
}