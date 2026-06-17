package application.monitoring;

import domain.interfaces.IAlertService;
import domain.interfaces.IBiometricRepository;
import domain.interfaces.IMonitoringService;

/**
 * Mechanizmy: logika biznesowa monitorowania; trwalosc (deleguje do
 * IBiometricRepository); rozproszenie (dane z urzadzenia IoT przez REST API).
 * Wzorzec: Service (warstwa aplikacji).
 * @author oliwia.klimaszewska
 * @version 1.0
 * @created 17-cze-2026 21:54:18
 */
public class MonitoringService implements IMonitoringService {

	private IAlertService alertService;
	private IBiometricRepository biometricRepository;

	public MonitoringService(){

	}

	public void finalize() throws Throwable {

	}
	public detectAnomaly(){

	}

	public generateHealthReport(){

	}

	public monitor(){

	}

	public generateReport(){

	}

	public getLatestBiometricData(){

	}

	public startMonitoring(){

	}

	public stopMonitoring(){

	}
}//end MonitoringService