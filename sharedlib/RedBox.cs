using System.Windows;
using System.Windows.Controls;

namespace sharedlib
{
    public class RedBox : Control
    {
        static RedBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RedBox), new FrameworkPropertyMetadata(typeof(RedBox)));
        }
    }
}
