package application.registration;

import domain.interfaces.IUserAccountRepository;
import domain.interfaces.IUserRepository;
import domain.interfaces.IRegistrationService;

/**
 * Mechanizmy: logika rejestracji i weryfikacji konta; bezpieczenstwo (haszowanie
 * hasla BCrypt); trwalosc (zapis uzytkownika w bazie). Wzorzec: Service.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:58
 */
public class RegistrationService implements IRegistrationService {

	private IUserAccountRepository accountRepository;
	private IUserRepository userRepository;

	public RegistrationService(){

	}

	public void finalize() throws Throwable {

	}
	public getUser(){

	}

	public register(){

	}

	public verifyEmail(){

	}
}//end RegistrationService