package domain.model;


/**
 * Mechanizmy: trwalosc (ORM/JPA, tabela user_accounts); bezpieczenstwo (haslo
 * hashowane BCrypt, blokada po 5 blednych probach). Wymagania dodatkowe:
 * weryfikacja email przed aktywacja.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:55:25
 */
public class UserAccount {

	private int id;
	private int login;
	private int passwordHash;
	private int status;
	private User user;

	public UserAccount(){

	}

	public void finalize() throws Throwable {

	}
	public activate(){

	}

	public verifyPassword(){

	}
}//end UserAccount