package domain.interfaces;


/**
 * Interfejs podsystemu MonitoringSubsystem. Odpowiedzialnosci: uruchomienie i
 * zatrzymanie monitorowania danych biometrycznych, pobranie aktualnych danych,
 * wygenerowanie raportu zdrowotnego.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:18
 */
public interface IMonitoringService {

	public generateReport();

	public getLatestBiometricData();

	public startMonitoring();

	public stopMonitoring();

}