package application.alert;

import domain.interfaces.IAlertRepository;
import domain.interfaces.INotificationService;
import domain.interfaces.IAlertService;

/**
 * Mechanizmy: logika eskalacji alertow; rozproszenie (powiadomienia push/SMS);
 * trwalosc (zapis alertow w bazie). Wzorzec: Service.
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:53:49
 */
public class AlertService implements IAlertService {

	private IAlertRepository alertRepository;
	private INotificationService notificationService;

	public AlertService(){

	}

	public void finalize() throws Throwable {

	}
	public escalate(){

	}

	public generateAlert(){

	}

	public getActiveAlerts(){

	}

	public createAlert(){

	}
}//end AlertService