package domain.model;


/**
 * Mechanizmy: trwalosc (ORM/JPA, tabela health_reports); bezpieczenstwo (dostep
 * tylko dla wlasciciela i upowaznionych opiekunow). Wymagania dodatkowe:
 * generowany automatycznie co 24h.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:03
 */
public class HealthReport {

	private BiometricData biometricData;
	private int createdAt;
	private int id;
	private int riskLevel;
	private int userId;

	public HealthReport(){

	}

	public void finalize() throws Throwable {

	}
	public getSummary(){

	}
}//end HealthReport