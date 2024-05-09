using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DarkwoodEditorWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for Dropdown.xaml
    /// </summary>
    public partial class Dropdown : UserControl
    {
        public Dropdown()
        {
            InitializeComponent();
        }

        private bool isRotated = false;

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
    }
}
