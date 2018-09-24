using System.Windows;
using System.Windows.Controls;

namespace netapp
{
    public class GreenBox : Control
    {
        static GreenBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GreenBox), new FrameworkPropertyMetadata(typeof(GreenBox)));
        }
    }
}
