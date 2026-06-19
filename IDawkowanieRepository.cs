namespace LifeGuard.Domain;

public class Dawkowanie
{
    public Guid Id { get; set; }
    public Guid PacjentId { get; set; }
    public Lek Lek { get; set; } = null!;
    public string Czestotliwosc { get; set; } = string.Empty;
    public string GodzinyPrzyjecia { get; set; } = string.Empty;
    public bool Aktywny { get; set; } = true;

    public void Aktywuj() => Aktywny = true;
    public void Dezaktywuj() => Aktywny = false;

    public IEnumerable<TimeOnly> ParsujGodziny() =>
        GodzinyPrzyjecia
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .Select(TimeOnly.Parse);
}
