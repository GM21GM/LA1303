# LA1301

Unity 2D Street Fighter

Giovanni Innamorato, Giuliano Martullo, Steven Salie

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

| AP-№ | Frist    | Zuständig         | Beschreibung                             | geplante Zeit |
| ---- | -------- | ----------------- | ---------------------------------------- | ------------- |
| 1.A  | 10.01.24 | Giovanni Giuliano | Projektbeschluss                         | 90'           |
| 1.A  | 10.01.24 | Giuliano          | Repository aufstellen.                   | 45'           |
| 1.A  | 10.01.24 | Giovanni Giuliano | Informieren                              | 45'           |
| 1.A  | 10.01.24 | Giuliano          | Userstorys                               | 90'           |
| 1.A  | 10.01.24 | Giovanni          | Testfälle                                | 90'           |
| 1.A  | 17.01.24 | Giovanni          | Arbeitspakete                            | 90'           |
| 1.A  | 17.01.24 | Giuliano          | Projekt erstellen                        | 90'           |
| 1.A  | 17.01.24 | Giovanni          | benötigte Erweiterungen auflisten        | 45'           |
| 1.A  | 17.01.24 | Giuliano          | Projekt Umgebung einstellen              | 45'           |
| 1.A  | 17.01.24 | Giuliano          | SQL Server verbindung herstellen         | 45'           |
| 1.A  | 17.01.24 | Giuliano          | Datenbank modell erstellen               | 45'           |
| 1.A  | 17.01.24 | Giovanni          | Personen generator implementieren        | 90'           |
| 1.A  | 24.01.24 | Giovanni          | Personen generator implementieren        | 90'           |
| 1.A  | 24.01.24 | Giuliano          | Post und Get Methoden implementieren     | 135'          |
| 1.A  | 24.01.24 | Giovanni          | Get Mehtode nach id filtern              | 90'           |
| 1.A  | 24.01.24 | Giovanni          | Personen Generator testen und optimieren | 45'           |
| 1.A  | 24.01.24 | Giuliano          | Post und Get Methoden testen             | 45'           |
| 1.A  | 24.01.24 | Giuliano          | Git Repo auf Visual Studio einrichten    | 45'           |
| 1.A  | 14.02.24 | Giovanni          | Delete Methode implementieren und testen | 90'           |
| 1.A  | 14.02.24 | Giuliano          | Applikation Testen und Debuggen          | 135'          |
| 1.A  | 14.02.24 | Giovanni          | Code überarbeiten und verbessern         | 90'           |
| 1.A  | 14.02.24 | Giuliano Giovanni | Review                                   | 45'           |
| 1.A  | 21.02.24 | Giovanni Giuliano | Portfolio Beitrag schreiben              | 225'          |

## 3 Realisieren

| AP-№ | Datum    | Zuständig                  | Geplante Zeit | Tatsächliche Zeit |
| ---- | -------- | -------------------------- | ------------- | ----------------- |
| 1.A  | 20.09.23 | Giovanni                   | 180 Minuten   | 180 Minuten       |
| 1.B  | 20.09.23 | Giovanni                   | 180 Minuten   | 180 Minuten       |
| 9.A  | 20.09.23 | Giovanni                   | 10            | 10                |
| 2.A  | 18.10.23 | Steven                     | 180 Minuten   | 180 Minuten       |
| 3.A  | 18.10.23 | Giuliano                   | 180 Minuten   | 180 Minuten       |
| 4.A  | 18.10.23 | Giovanni                   | 120 Minuten   | 120 Minuten       |
| 9.A  | 18.10.23 | Giuliano                   | 10            | 10                |
| 5.A  | 01.11.23 | Giovanni                   | 240 Minuten   | 240 Minuten       |
| 6.A  | 01.11.23 | Steven                     | 120 Minuten   | 120 Minuten       |
| 7.A  | 01.11.23 | Giuliano                   | 180 Minuten   | 180 Minuten       |
| 8.A  | 01.11.23 | Giovanni                   | 180 Minuten   | 180 Minuten       |
| 9.A  | 01.11.23 | Steven                     | 10            | 10                |
| 9.B  | 08.11.23 | Steven, Giovanni, Giuliano | 90 Minuten    | 90 Minuten        |

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
