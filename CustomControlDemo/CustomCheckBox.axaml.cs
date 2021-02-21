using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Avalonia.NETCoreApp
{
    public class CustomCheckBox : TemplatedControl
    {
        public static readonly StyledProperty<bool> IsCheckedProperty = 
            AvaloniaProperty.Register<CustomCheckBox, bool>("IsChecked");

        public bool IsChecked
        {
            get => GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public CustomCheckBox()
        {
            AddHandler(PointerPressedEvent, Handler, RoutingStrategies.Tunnel);
        }

        private void Handler(object? sender, PointerPressedEventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}