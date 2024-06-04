using DarkwoodEditorWPF.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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

            contentRight.JournalOwnership = JournalOwnership.OwnsJournal;
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

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!contentRight.CanGoBack)
            {
                contentRight.Content = null;
            }
            else
            {
                contentRight.GoBack();
            }
        }

        private void forwardBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!contentRight.CanGoForward)
            {
                contentRight.Content = null;
            }
            else
            {
                contentRight.GoForward();
            }
        }
    }
}