using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;

namespace lab7.Views;

public partial class MainView : UserControl
{
    private string seq = "";
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_on_click(object? sender, RoutedEventArgs e)
    {
        Wynik.Text = seq;
    }

    private void Wczytana_sekwencja(object? sender, TextChangedEventArgs e)
    {
        if (sender is TextBox textBox)
        {
            seq = textBox.Text;
        }
    }

    //DLA KAZDYCH 4 NUKLEOTYDOW, BIERZEMY PIERWSZE 4 I PATRZYMY CZY MAMY W LISCIE/SLOWNIKU ITD
    private void Analiza(object? sender, RoutedEventArgs e)
    {

    }

}
