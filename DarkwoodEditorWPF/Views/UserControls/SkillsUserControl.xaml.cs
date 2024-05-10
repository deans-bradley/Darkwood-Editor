using DarkwoodEditorWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for SkillsUserControl.xaml
    /// </summary>
    public partial class SkillsUserControl : UserControl
    {
        public SkillsUserControl()
        {
            InitializeComponent();
            ShowDropDowns();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.SkillS;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.MainContent.Content = null;
        }

        private void ShowDropDowns()
        {
            PsViewModel? psVM = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;

            if (psVM?.SkillS?.AvailableSkillsStates == null)
            {
                availableSkillsDrpDwn.Visibility = Visibility.Collapsed;
            }

            if (psVM?.SkillS?.SkillsStates == null)
            {
                skillsStatesDrpDwn.Visibility = Visibility.Collapsed;
            }
        }
    }
}
