package domain.interfaces;


/**
 * Interfejs serwisu powiadomien. Odpowiedzialnosci: wysylanie powiadomien push
 * (FCM) i SMS do uzytkownika i jego opiekunow. Mechanizmy: rozproszenie,
 * bezpieczenstwo (autoryzowany token FCM).
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:18
 */
public interface INotificationService {

	public sendPush();

	public sendSMS();

}