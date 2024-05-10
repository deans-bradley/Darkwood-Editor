using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkwoodEditorWPF.Views.UserControls.DropDowns
{
    /// <summary>
    /// Interaction logic for AvailableSkillsDrpDwn.xaml
    /// </summary>
    public partial class AvailableSkillsDrpDwn : UserControl
    {
        bool isRotated = false;

        public AvailableSkillsDrpDwn()
        {
            InitializeComponent();

            DataContext = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel?.SkillS;
            CheckDropDownContent();
        }

        private void openDropdownBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isRotated)
            {
                openDropdownBtn.RenderTransformOrigin = new Point(0.5, 0.5);
                openDropdownBtn.RenderTransform = new RotateTransform(180);
                isRotated = true;

                drpDwnContent.Visibility = Visibility.Visible;
            }
            else
            {
                openDropdownBtn.RenderTransformOrigin = new Point(0.5, 0.5);
                openDropdownBtn.RenderTransform = new RotateTransform(0);
                isRotated = false;

                drpDwnContent.Visibility = Visibility.Collapsed;
            }
        }

        private void CheckDropDownContent()
        {
            PsViewModel? psVM = (Application.Current.MainWindow.DataContext as MainViewModel)?.PsViewModel;

            if (psVM?.SkillS?.AvailableSkillsStates != null)
            {
                drpDwnContent.Visibility = Visibility.Collapsed;
            }
        }
    }
}
