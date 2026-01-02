using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Diagnostics;
using System.Diagnostics;

namespace Temperature_Converter.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Convert();
    }

    private void Celcius_TextChanged(object? sender, TextChangedEventArgs e)
    {
        Convert();
    }

    private void Convert()
    {
        if (double.TryParse(Celcius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Farenheit.Text = F.ToString("0.0");
        }
        else
        {
            Celcius.Text = "";
            Farenheit.Text = "";
        }
    }
}