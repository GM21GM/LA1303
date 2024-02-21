# LA1301

Unity 2D Street Fighter

Giovanni Innamorato, Giuliano Martullo, Steven Salie

| Datum    | Version | Zusammenfassung                                         |
| -------- | ------- | ------------------------------------------------------- |
| 24.01.24 | 0.0.1   | API kann einen neu erstellten Namen als response geben. |
| 18.10.23 | 0.0.2   |                                                         |
| 25.10.23 | 0.1     |                                                         |
| 01.11.23 | 1.0.0   |                                                         |

## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen eine API die Namen zufällig zusammenstellt, sie speichert und verändert werden können.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ | Beschreibung                                                                                                          |
| ---- | --------------- | --- | --------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | F   | Als ein User möchte ich, dass ich mit einer GET Request eine Neu Erstellte Person als Response erhalte.               |
| 2    | Muss            | F   | Als ein User möchte ich, dass ich mit einer GET Request eine bestimmte oder alle Personen als Response erhalte.       |
| 3    | Muss            | F   | Als ein User möchte ich, dass ich mit einem POST Request eine neue Personen erstellen können.                         |
| 4    | Muss            | F   | Als ein User möchte ich, dass ich mit einem PUT Request eine bestehende Personen verändern können.                   |
| 5    | Muss            | F   | Als ein User möchte ich, dass die bestehenden Personen und alle veränderungen gespeichert werden auf einer Datenbank. |
| 6    | Muss            | F   | Als ein User möchte ich, dass ich mit einer DELETE Request eine bestehende Personen löschen kann.                     |

### 1.3 Testfälle

| TC-№ | Ausgangslage     | Eingabe                                         | Erwartete Ausgabe                                                |
| ---- | ---------------- | ----------------------------------------------- | ---------------------------------------------------------------- |
| 1.1  | https://localhost:7211/api/Person/NewPerson| Execute | 201  |
| 2.1| |https://localhost:7211/api/Person  |Execute |201 Alle Personen|
|2.2| https://localhost:7211/api/Person/31|Id: 31 Execute|201 Person mit Id 31|
|3.1|https://localhost:7211/api/Person| Daten der Person nach Vorlage| 201|
|4.1|https://localhost:7211/api/Person/11| Daten der Person| 201|
|5.1|https://localhost:7211/api/Person/NewPerson|Execute| Person auf Datenbank mit neuer Id gespeichert|
|6.1|https://localhost:7211/api/Person/49|Id:12 Execute| 204|

## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung                                                                                        | geplante Zeit |
| ---- | -------- | --------- | --------------------------------------------------------------------------------------------------- | ------------- |
| 1.A  | 20.09.23 | Giovanni  | Implementierung des grundlegenden Player-Movements, einschliesslich Bewegung nach links und rechts. | 180'          |

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

| TC-№ | Datum | Resultat | Tester   |Testumgebung|Kommentar|
| ---- | ----- | -------- | -------- |Swagger||
| 1.1  | 21.02 | OK       | Giuliano |Swagger||
| 2.1  | 21.02 | OK       | Giuliano |Swagger||
| 2.2  | 21.02 | OK       | Giuliano |Swagger||
| 3.1  | 21.02 | NOK      | Giuliano |Swagger|Put funktioniert nicht, Fehler konnte nicht behoben werden.|
| 4.1  | 21.02 | OK       | Giuliano |Swagger||
| 5.1  | 21.02 | OK       | Giuliano |Swagger + Microsoft SQL||
| 6.1  | 21.02 | OK       | Giuliano |Swagger||


