package domain.interfaces;


/**
 * Interfejs podsystemu RegistrationSubsystem. Odpowiedzialnosci: rejestracja
 * nowego uzytkownika, weryfikacja adresu email tokenem, pobranie danych
 * uzytkownika po loginie.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:18
 */
public interface IRegistrationService {

	public register();

	public verifyEmail();

}