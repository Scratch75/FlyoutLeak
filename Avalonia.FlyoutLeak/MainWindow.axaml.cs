using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;

namespace Avalonia.FlyoutLeak;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBlock_PointerPressed(object? sender, PointerPressedEventArgs e)
    {
        if (sender is Control ctl)
            FlyoutBase.ShowAttachedFlyout(ctl);
    }
}