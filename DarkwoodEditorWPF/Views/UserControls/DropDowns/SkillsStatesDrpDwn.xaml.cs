using DarkwoodEditorWPF.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkwoodEditorWPF.Views.UserControls.DropDowns
{
    /// <summary>
    /// Interaction logic for SkillsStatesDrpDwn.xaml
    /// </summary>
    public partial class SkillsStatesDrpDwn : UserControl
    {
        public bool isRotated = false;

        public SkillsStatesDrpDwn()
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

            if (psVM?.SkillS?.SkillsStates != null)
            {
                drpDwnContent.Visibility = Visibility.Collapsed;
            }
        }
    }
}
