package domain.model;


/**
 * Mechanizmy: trwalosc (ORM/JPA, tabela users); bezpieczenstwo (dane osobowe -
 * RODO/GDPR, dostep kontrolowany rolami). Wymagania dodatkowe: prawo do usuniecia
 * danych (right to be forgotten).
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:55:25
 */
public class User {

	private int email;
	private int firstName;
	private int id;
	private int lastName;
	private int role;

	public User(){

	}

	public void finalize() throws Throwable {

	}
	public isActive(){

	}
}//end User