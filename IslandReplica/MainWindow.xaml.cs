using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace IslandReplica;

public partial class MainWindow : Window
{
    private readonly DispatcherTimer _timer = new() { Interval = TimeSpan.FromSeconds(1) };
    private bool _expanded;

    public MainWindow()
    {
        InitializeComponent();
        _timer.Tick += (_, _) => UpdateClock();
        _timer.Start();
        UpdateClock();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Left = (SystemParameters.PrimaryScreenWidth - Width) / 2;
        Top = 18;
    }

    private void UpdateClock()
    {
        var now = DateTime.Now;
        ClockText.Text = now.ToString("HH:mm");
        LongTimeText.Text = now.ToString("HH:mm:ss");
        DateText.Text = now.ToString("ddd, dd MMM");
    }

    private void ExpandButton_Click(object sender, RoutedEventArgs e)
    {
        _expanded = !_expanded;
        Details.Visibility = _expanded ? Visibility.Visible : Visibility.Collapsed;
        Height = _expanded ? 230 : 78;
        ExpandButton.Content = _expanded ? "⌃" : "⌄";
    }

    private void Shell_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ButtonState == MouseButtonState.Pressed && e.OriginalSource is not System.Windows.Controls.Button)
            DragMove();
    }
}
