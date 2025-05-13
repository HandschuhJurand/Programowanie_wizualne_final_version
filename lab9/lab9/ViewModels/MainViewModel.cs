using ReactiveUI;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace lab9.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string? DataWypelnienia { get; set; }
    public string? NumerAlbumu { get; set; }
    public string? NazwiskoImie { get; set; }
    public string? SemestrRok { get; set; }
    public string? KierunekStopien { get; set; }
    public string? Przedmiot { get; set; }
    public string? Punkty { get; set; }
    public string? Prowadzacy { get; set; }
    public string? Uzasadnienie { get; set; }
    public string? DataPodpisStudenta { get; set; }
    public string? Decyzja { get; set; }
    public string? Komisja1 { get; set; }
    public string? Komisja2 { get; set; }
    public string? Komisja3 { get; set; }
    public string? DataDecyzji { get; set; }

    public ObservableCollection<Wniosek> Wnioski { get; } = new();

    private DatabaseManager _db = new();

    public ICommand ZapiszCommand => ReactiveCommand.Create(Zapisz);
    public ICommand PokazWpisyCommand => ReactiveCommand.Create(PokazWpisy);

    private void Zapisz()
    {
        var wniosek = new Wniosek
        {
            DataWypelnienia = this.DataWypelnienia,
            NumerAlbumu = this.NumerAlbumu,
            NazwiskoImie = this.NazwiskoImie,
            SemestrRok = this.SemestrRok,
            KierunekStopien = this.KierunekStopien,
            Przedmiot = this.Przedmiot,
            Punkty = this.Punkty,
            Prowadzacy = this.Prowadzacy,
            Uzasadnienie = this.Uzasadnienie,
            DataPodpisStudenta = this.DataPodpisStudenta,
            Decyzja = this.Decyzja,
            Komisja1 = this.Komisja1,
            Komisja2 = this.Komisja2,
            Komisja3 = this.Komisja3,
            DataDecyzji = this.DataDecyzji
        };
        _db.WriteData(wniosek);
        PokazWpisy();
    }

    private void PokazWpisy()
    {
        Wnioski.Clear();
        foreach (var w in _db.PobierzWnioski())
            Wnioski.Add(w);
    }

}
