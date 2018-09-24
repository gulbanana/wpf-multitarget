using System.Windows;
using System.Windows.Controls;

namespace coreapp
{
    public class BlueBox : Control
    {
        static BlueBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BlueBox), new FrameworkPropertyMetadata(typeof(BlueBox)));
        }
    }
}
