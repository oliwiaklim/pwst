package domain.model;


/**
 * Mechanizmy: trwalosc (ORM/JPA, tabela alerts); rozproszenie (synchronizacja
 * stanu alertu miedzy urzadzeniami). Wymagania dodatkowe: historia alertow
 * przechowywana min. 12 miesiecy.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:53:48
 */
public class Alert {

	private int createdAt;
	private int id;
	private int severityLevel;
	private int status;
	private int type;
	private int userId;

	public Alert(){

	}

	public void finalize() throws Throwable {

	}
	public isCritical(){

	}

	public markResolved(){

	}
}//end Alert