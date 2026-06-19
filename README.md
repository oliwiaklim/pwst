using LifeGuard.Domain;

namespace LifeGuard.Domain.Interfaces;

public interface IPrzyjecieRepository
{
    Task SaveAsync(PrzyjecieLeku przyjecie);
    Task<IEnumerable<PrzyjecieLeku>> FindHistoryByPacjentIdAsync(Guid pacjentId);
    Task<IEnumerable<PrzyjecieLeku>> FindPendingOlderThanAsync(TimeSpan minuty);
}
