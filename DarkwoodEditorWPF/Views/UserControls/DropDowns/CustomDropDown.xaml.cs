using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls.DropDowns
{
    /// <summary>
    /// Interaction logic for CustomDropDown.xaml
    /// </summary>
    public partial class CustomDropDown : UserControl
    {
        public CustomDropDown()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty DropDownTitleProperty =
            DependencyProperty.Register("DropDownTitle", typeof(string), typeof(CustomDropDown));

        public static readonly DependencyProperty DropDownItemSourceProperty =
            DependencyProperty.Register("DropDownItemSource", typeof(object), typeof(CustomDropDown));

        public static readonly DependencyProperty DropDownItemNameProperty =
            DependencyProperty.Register("DropDownItemName", typeof(string), typeof(CustomDropDown));

        public static readonly DependencyProperty DropDownItemValueProperty =
            DependencyProperty.Register("DropDownItemValue", typeof(string), typeof(CustomDropDown));

        // Test
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

        public string DropDownItemName
        {
            get { return (string)GetValue(DropDownItemNameProperty); }
            set { SetValue(DropDownItemNameProperty, value); }
        }

        public string DropDownItemValue
        {
            get { return (string)GetValue(DropDownItemValueProperty); }
            set { SetValue(DropDownItemValueProperty, value); }
        }

        // Test
        public DataTemplate DropDownItemTemplate
        {
            get { return (DataTemplate)GetValue(DropDownItemTemplateProperty); }
            set { SetValue(DropDownItemTemplateProperty, value); }
        }

        private void openDropdownBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
