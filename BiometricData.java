package domain.model;


/**
 * Mechanizmy: trwalosc (ORM/JPA, tabela biometric_data); bezpieczenstwo (dane
 * wrazliwe - szyfrowanie w spoczynku AES-256). Wymagania dodatkowe: dane
 * anonimizowane po usunieciu konta.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:03
 */
public class BiometricData {

	private int heartRate;
	private int id;
	private int stepCount;
	private int timestamp;
	private int userId;

	public BiometricData(){

	}

	public void finalize() throws Throwable {

	}
	public isAnomaly(){

	}

	public validate(){

	}
}//end BiometricData