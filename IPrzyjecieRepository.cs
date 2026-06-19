using LifeGuard.Application;

namespace LifeGuard.Presentation;

public class PrzypomnienieView
{
    private readonly IHarmonogramService _harmonogramService;

    public PrzypomnienieView(IHarmonogramService harmonogramService)
    {
        _harmonogramService = harmonogramService;
    }

    // Krok sekwencji: kontroler -> ekran: pokazPrzypomnienie(lekNazwa, dawka)
    public void PokazPrzypomnienie(string lekNazwa, string dawka)
    {
        Console.WriteLine($"[Przypomnienie] Czas przyjac: {lekNazwa} ({dawka})");
        // TODO: implementacja UI (.NET MAUI / Blazor) - wyswietlenie powiadomienia push
    }

    // Wywolywane po klikniеciu przez pacjenta przycisku "Przyjete"
    public async Task PotwierdzPrzyjecie(Guid przyjecieId)
    {
        await _harmonogramService.PotwierdzPrzyjecieAsync(przyjecieId);
    }
}
