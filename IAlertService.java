package domain.interfaces;


/**
 * Interfejs podsystemu AlertSubsystem. Odpowiedzialnosci: tworzenie alertow na
 * podstawie wykrytych anomalii, eskalacja alertow krytycznych, pobieranie listy
 * aktywnych alertow uzytkownika.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:17
 */
public interface IAlertService {

	public createAlert();

	public escalate();

	public getActiveAlerts();

}