# LA1301

Personen Generator API

Giovanni Innamorato, Giuliano Martullo

| Datum    | Version | Zusammenfassung                                                                                      |
| -------- | ------- | ---------------------------------------------------------------------------------------------------- |
| 24.01.24 | 0.0.1   | API kann einen neu erstellten Namen als response geben. Personen werden in der Datenbank gespeichert |
| 14.02.24 | 0.0.2   | API kann Post anfragen und Personen nach Id gefiltert zurückgeben                                    |
| 21.02.24 | 1.0.0   | API kann alle HTTP Methoden handeln.                                                                 |

## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen eine API die Namen zufällig zusammenstellt, sie speichert und verändert werden können.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ | Beschreibung                                                                                                          |
| ---- | --------------- | --- | --------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | F   | Als ein User möchte ich, dass ich mit einer GET Request eine Neu Erstellte Person als Response erhalte.               |
| 2    | Muss            | F   | Als ein User möchte ich, dass ich mit einer GET Request eine bestimmte oder alle Personen als Response erhalte.       |
| 3    | Muss            | F   | Als ein User möchte ich, dass ich mit einem POST Request eine neue Personen erstellen können.                         |
| 4    | Muss            | F   | Als ein User möchte ich, dass ich mit einem POST Request eine bestehende Personen verändern können.                   |
| 5    | Muss            | F   | Als ein User möchte ich, dass die bestehenden Personen und alle veränderungen gespeichert werden auf einer Datenbank. |
| 6    | Muss            | F   | Als ein User möchte ich, dass ich mit einer DELETE Request eine bestehende Personen löschen kann.                     |

### 1.3 Testfälle

| TC-№ | Ausgangslage                           | Eingabe | Erwartete Ausgabe |
| ---- | -------------------------------------- | ------- | ----------------- |
| 1.1  | API gestartet, Swagger / Postman offen |         |                   |

## 2 Planen

| AP-№ | Frist    | Zuständig         | Beschreibung                             | Geplante Zeit |
| ---- | -------- | ----------------- | ---------------------------------------- | ------------- |
| 1.A  | 10.01.24 | Giovanni Giuliano | Projektbeschluss                         | 90'           |
| 1.B  | 10.01.24 | Giuliano          | Repository aufstellen.                   | 45'           |
| 1.C  | 10.01.24 | Giovanni Giuliano | Informieren                              | 45'           |
| 1.D  | 10.01.24 | Giuliano          | Userstorys                               | 90'           |
| 1.E  | 10.01.24 | Giovanni          | Testfälle                                | 90'           |
| 1.F  | 17.01.24 | Giovanni          | Arbeitspakete                            | 90'           |
| 1.G  | 17.01.24 | Giuliano          | Projekt erstellen                        | 90'           |
| 1.H  | 17.01.24 | Giovanni          | benötigte Erweiterungen auflisten        | 45'           |
| 1.I  | 17.01.24 | Giuliano          | Projekt Umgebung einstellen              | 45'           |
| 1.J  | 17.01.24 | Giuliano          | SQL Server verbindung herstellen         | 45'           |
| 1.K  | 17.01.24 | Giuliano          | Datenbank modell erstellen               | 45'           |
| 1.L  | 17.01.24 | Giovanni          | Personen generator implementieren        | 90'           |
| 1.M  | 24.01.24 | Giovanni          | Personen generator implementieren        | 90'           |
| 1.N  | 24.01.24 | Giuliano          | Post und Get Methoden implementieren     | 135'          |
| 1.O  | 24.01.24 | Giovanni          | Get Mehtode nach id filtern              | 90'           |
| 1.P  | 24.01.24 | Giovanni          | Personen Generator testen und optimieren | 45'           |
| 1.Q  | 24.01.24 | Giuliano          | Post und Get Methoden testen             | 45'           |
| 1.R  | 24.01.24 | Giuliano          | Git Repo auf Visual Studio einrichten    | 45'           |
| 1.S  | 14.02.24 | Giovanni          | Delete Methode implementieren und testen | 90'           |
| 1.T  | 14.02.24 | Giuliano          | Applikation Testen und Debuggen          | 135'          |
| 1.U  | 14.02.24 | Giovanni          | Code überarbeiten und verbessern         | 90'           |
| 1.V  | 14.02.24 | Giuliano Giovanni | Code Review                              | 45'           |
| 1.W  | 21.02.24 | Giovanni Giuliano | Portfolio Beitrag schreiben              | 225'          |

## 3 Realisieren

| AP-№ | Datum    | Zuständig         | Geplante Zeit | Tatsächliche Zeit |
| ---- | -------- | ----------------- | ------------- | ----------------- |
| 1.A  | 10.01.24 | Giovanni Giuliano | 90'           | 100'              |
| 1.B  | 10.01.24 | Giuliano          | 45'           | 45'               |
| 1.C  | 10.01.24 | Giovanni Giuliano | 45'           | 45'               |
| 1.D  | 10.01.24 | Giuliano          | 90'           | 90'               |
| 1.E  | 10.01.24 | Giovanni          | 90'           | 90'               |
| 1.F  | 17.01.24 | Giovanni          | 90'           | 90'               |
| 1.G  | 17.01.24 | Giuliano          | 90'           | 90'               |
| 1.H  | 17.01.24 | Giovanni          | 45'           | 45'               |
| 1.I  | 17.01.24 | Giuliano          | 45'           | 45'               |
| 1.J  | 17.01.24 | Giuliano          | 45'           | 45'               |
| 1.K  | 17.01.24 | Giuliano          | 45'           | 45'               |
| 1.L  | 17.01.24 | Giovanni          | 90'           | 90'               |
| 1.M  | 24.01.24 | Giovanni          | 90'           | 90'               |
| 1.N  | 24.01.24 | Giuliano          | 135'          | 135'              |
| 1.O  | 24.01.24 | Giovanni          | 90'           | 90'               |
| 1.P  | 24.01.24 | Giovanni          | 45'           | 45'               |
| 1.Q  | 24.01.24 | Giuliano          | 45'           | 45'               |
| 1.R  | 24.01.24 | Giuliano          | 45'           | 45'               |
| 1.S  | 14.02.24 | Giovanni          | 90'           | 90'               |
| 1.T  | 14.02.24 | Giuliano          | 135'          | 135'              |
| 1.U  | 14.02.24 | Giovanni          | 90'           | 90'               |
| 1.V  | 14.02.24 | Giuliano Giovanni | 45'           | 45'               |
| 1.W  | 21.02.24 | Giovanni Giuliano | 225'          | 225'              |

## 4 Kontrollieren

### Testprotokoll

| TC-№ | Datum | Resultat | Tester   |
| ---- | ----- | -------- | -------- |
| 1.1  | 08.11 | OK       | Giuliano |
| 2.1  | 08.11 | OK       | Giuliano |
| 3.1  | 08.11 | OK       | Giuliano |
| 4.1  | 08.11 | OK       | Giuliano |
| 5.1  | 08.11 | OK       | Giuliano |
| 6.1  | 08.11 | OK       | Giuliano |
| 8.1  | 08.11 | NOK      | Giuliano |
