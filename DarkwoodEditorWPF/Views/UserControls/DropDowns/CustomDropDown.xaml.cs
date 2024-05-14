using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DarkwoodEditorWPF.Views.UserControls.DropDowns
{
    /// <summary>
    /// Interaction logic for CustomDropDown.xaml
    /// </summary>
    public partial class CustomDropDown : UserControl
    {
        private bool isRotated = false;

        public CustomDropDown()
        {
            InitializeComponent();

            dropDownItemSource.Visibility = Visibility.Collapsed;
        }

        public static readonly DependencyProperty DropDownTitleProperty =
            DependencyProperty.Register("DropDownTitle", typeof(string), typeof(CustomDropDown));

        public static readonly DependencyProperty DropDownItemSourceProperty =
            DependencyProperty.Register("DropDownItemSource", typeof(object), typeof(CustomDropDown));

        public static readonly DependencyProperty DropDownItemTemplateProperty =
            DependencyProperty.Register("DropDownItemTemplate", typeof(DataTemplate), typeof(CustomDropDown));

        public string DropDownTitle
        {
            get { return (string)GetValue(DropDownTitleProperty); }
            set { SetValue(DropDownTitleProperty, value); }
        }

        public object DropDownItemSource
        {
            get { return GetValue(DropDownItemSourceProperty); }
            set { SetValue(DropDownItemSourceProperty, value); }
        }

        public DataTemplate DropDownItemTemplate
        {
            get { return (DataTemplate)GetValue(DropDownItemTemplateProperty); }
            set { SetValue(DropDownItemTemplateProperty, value); }
        }

        private void openDropdownBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isRotated)
            {
                openDropdownBtn.RenderTransformOrigin = new Point(0.5, 0.5);
                openDropdownBtn.RenderTransform = new RotateTransform(180);
                isRotated = true;

                dropDownItemSource.Visibility = Visibility.Visible;
            }
            else
            {
                openDropdownBtn.RenderTransformOrigin = new Point(0.5, 0.5);
                openDropdownBtn.RenderTransform = new RotateTransform(0);
                isRotated = false;

                dropDownItemSource.Visibility = Visibility.Collapsed;
            }
        }
    }
}
