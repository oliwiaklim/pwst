namespace LifeGuard.Domain;

public class Lek
{
    public Guid Id { get; set; }
    public string Nazwa { get; set; } = string.Empty;
    public string? Postac { get; set; }
    public string? Opis { get; set; }
}
