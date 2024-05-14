using DarkwoodEditorWPF.Views.UserControls.DropDowns;
using System.Windows;
using System.Windows.Controls;

namespace DarkwoodEditorWPF.Views.UserControls
{
    /// <summary>
    /// Interaction logic for EffectsUserControl.xaml
    /// </summary>
    public partial class EffectsUserControl : UserControl
    {
        public EffectsUserControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty EffectsItemSourceProperty =
            DependencyProperty.Register("EffectsItemSource", typeof(object), typeof(EffectsUserControl));

        public object EffectsItemSource
        {
            get { return GetValue(EffectsItemSourceProperty); }
            set { SetValue(EffectsItemSourceProperty, value); }
        }
    }
}
