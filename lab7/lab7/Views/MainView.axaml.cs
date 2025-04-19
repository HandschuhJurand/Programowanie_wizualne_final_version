using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace lab7.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    private bool SprawdzNukleotyd(char c)
    {
        return c == 'A' || c == 'C' || c == 'G' || c == 'T';
    }
    private void Button_on_click(object sender, RoutedEventArgs e)
    {
        var sekwencjaInput = this.FindControl<TextBox>("Wczytana_sekwencja");
        var wynikiBox = this.FindControl<TextBox>("WynikiAnaliz");

        if (sekwencjaInput == null || wynikiBox == null) return;

        string sekwencja = sekwencjaInput.Text?.ToUpper() ?? "";

        if (string.IsNullOrEmpty(sekwencja))
        {
            wynikiBox.Text = "Proszę wprowadzić sekwencję DNA.";
            return;
        }

        if (!sekwencja.All(SprawdzNukleotyd))
        {
            wynikiBox.Text = "Sekwencja może zawierać tylko litery A, C, G, T.";
            return;
        }

        if (sekwencja.Length < 4)
        {
            wynikiBox.Text = "Sekwencja jest za krótka. Minimalna długość to 4 nukleotydy.";
            return;
        }

        var wyniki = new Dictionary<string, int>();

        for (int i = 0; i <= sekwencja.Length - 4; i++)
        {
            string podsekwencja = sekwencja.Substring(i, 4);
            if (!wyniki.ContainsKey(podsekwencja))
            {
                wyniki[podsekwencja] = 0;
            }
            wyniki[podsekwencja]++;
        }

        var sb = new StringBuilder();
        sb.AppendLine("Wyniki analizy sekwencji DNA:\n");
        sb.AppendLine("Znalezione 4-nukleotydowe sekwencje:");

        foreach (var wynik in wyniki.OrderByDescending(x => x.Value))
        {
            sb.AppendLine($"• {wynik.Key}: {wynik.Value} wystąpień");
        }

        wynikiBox.Text = sb.ToString();
    }
}

