# LA1301

Unity 2D Street Fighter

Giovanni Innamorato, Giuliano Martullo, Steven Salie

| Datum    | Version | Zusammenfassung |
| -------- | ------- | --------------- |
| 20.09.23 | 0.0.1   |                 |
| 18.10.23 | 0.0.2   |                 |
| 25.10.23 | 0.1     |                 |
| 01.11.23 | 1.0.0   |                 |

## 1 Informieren

### 1.1 Ihr Projekt

Wir erstellen eine API die Namen zufällig zusammenstellt, sie speichert und verändert werden können.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ | Beschreibung                                                                                                         |
| ---- | --------------- | --- | -------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | F   | Als ein Spieler möchte ich, dass das Player-Movement funktioniert, damit ich meinen Charakter im Spiel steuern kann. |

### 1.3 Testfälle

| TC-№ | Ausgangslage                                                          | Eingabe                                                                             | Erwartete Ausgabe                                                                                             |
| ---- | --------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| 1.1  | Das Spiel läuft.                                                      | Der Spieler versucht, den Charakter zu bewegen.                                     | Der Charakter bewegt sich entsprechend der Eingabe des Spielers.                                              |
| 2.1  | Das Spiel befindet sich im Hauptmenü.                                 | Der Spieler klickt auf die Starttaste im Hauptmenü.                                 | Das Spiel startet und die Spielumgebung wird geladen.                                                         |
| 3.1  | Das Spiel läuft und der Spielercharakter hat einen Gesundheitsbalken. | Der Spielercharakter erleidet Schaden.                                              | Der Gesundheitsbalken des Charakters wird aktualisiert, um den verlorenen Gesundheitszustand anzuzeigen.      |
| 4.1  | Das Spiel läuft.                                                      | Der Spieler beobachtet die Bewegungen des Charakters.                               | Der Charakter zeigt flüssige und ansprechende Animationen entsprechend seinen Aktionen.                       |
| 5.1  | Das Spiel läuft und der Spielercharakter kann gegen Gegner kämpfen.   | Der Spielercharakter greift einen Gegner an.                                        | Der Gegner erleidet Schaden, die Healthbar sinkt.                                                             |
| 6.1  | Das Spiel läuft und der Spieler hat das Spiel beendet.                | Der Spieler beendet das Spiel oder erreicht ein Game Over.                          | Die Game Over Scene wird angezeigt, um den Spieler über das Spielende zu informieren.                         |
| 8.1  | Der Spielercharakter kann sich bewegen.                               | Der Spieler versucht, den Charakter ducken zu lassen und sich langsamer zu bewegen. | Der Charakter duckt sich und bewegt sich langsamer, um es dem Spieler zu ermöglichen, Angriffen auszuweichen. |
|      |                                                                       |                                                                                     |                                                                                                               |

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

| TC-№ | Datum | Resultat | Tester   |
| ---- | ----- | -------- | -------- |
| 1.1  | 08.11 | OK       | Giuliano |
| 2.1  | 08.11 | OK       | Giuliano |
| 3.1  | 08.11 | OK       | Giuliano |
| 4.1  | 08.11 | OK       | Giuliano |
| 5.1  | 08.11 | OK       | Giuliano |
| 6.1  | 08.11 | OK       | Giuliano |
| 8.1  | 08.11 | NOK      | Giuliano |