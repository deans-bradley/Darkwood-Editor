﻿using DarkwoodEditorWPF.ViewModels;
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
            CheckDropDowns();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.SkillS;
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            MainContent? mainContent = mainWindow.MainContentPage.Content as MainContent;

            if (mainContent != null)
            {
                mainContent.SetContentRight(null);
            }
        }

        private void CheckDropDowns()
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
