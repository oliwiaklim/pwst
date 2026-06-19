namespace LifeGuard.Domain;

public enum StatusPrzyjecia
{
    Oczekuje,
    Przyjety,
    Pominiety
}

public class PrzyjecieLeku
{
    public Guid Id { get; set; }
    public Dawkowanie Dawkowanie { get; set; } = null!;
    public DateTime ZnacznikCzasu { get; set; }
    public StatusPrzyjecia Status { get; set; } = StatusPrzyjecia.Oczekuje;
    public DateTime? CzasPotwierdzenia { get; set; }

    public void OznaczPrzyjety()
    {
        if (Status != StatusPrzyjecia.Oczekuje)
            throw new InvalidOperationException("Przyjecie zostalo juz rozstrzygniete.");

        Status = StatusPrzyjecia.Przyjety;
        CzasPotwierdzenia = DateTime.UtcNow;
    }

    public void OznaczPominiety()
    {
        if (Status != StatusPrzyjecia.Oczekuje)
            throw new InvalidOperationException("Przyjecie zostalo juz rozstrzygniete.");

        Status = StatusPrzyjecia.Pominiety;
    }

    public bool CzyPrzeterminowane(TimeSpan limit) =>
        Status == StatusPrzyjecia.Oczekuje && DateTime.UtcNow - ZnacznikCzasu > limit;
}
