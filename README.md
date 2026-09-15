# IPT1 · Lernsession 03 · GitHub-Flow & Markdown

> **Name:** _Leonidas Kästner_  
> **Datum:** _08.09.2026_

## Ziel

Ich kann die wichtigsten Begriffe rund um **Git**, **GitHub**, den **GitHub-Flow** und **Markdown** kurz erklären und meinen Lernfortschritt mit einem eigenen README dokumentieren.

> **Hinweis:** Ersetze die Platzhalter `DEINE ANTWORT` durch deine eigenen kurzen Antworten. Committe die ausgefüllte Datei anschliessend mit einer aussagekräftigen Commit-Nachricht.

---

## 1 · Git und GitHub verstehen

### 1. Was ist Git?

**Meine Antwort:** Git ist ein Versionskontrollsystem, mit dem Änderungen an Dateien gespeichert und verfolgt werden können.

### 2. Was ist GitHub?

**Meine Antwort:** GitHub ist eine Plattform im Internet, auf der Git-Repositories gespeichert und gemeinsam bearbeitet werden können.

### 3. Was ist der wichtigste Unterschied zwischen Git und GitHub?

**Meine Antwort:** Git ist das Programm zur Versionskontrolle, GitHub ist eine Online-Plattform für Git-Projekte.

### 4. Funktioniert Git auch ohne GitHub?

**Meine Antwort:** Ja, Git funktioniert auch lokal auf dem Computer ohne GitHub.

### 5. Was ist ein Repository (Repo)?

**Meine Antwort:** Ein Repository ist ein Projektordner, in dem Dateien und deren Änderungen gespeichert werden.

### 6. Was ist der `main`-Branch?

**Meine Antwort:** Der main-Branch ist normalerweise der Hauptzweig eines Projekts.

### 7. Was ist Markdown?

**Meine Antwort:** Markdown ist eine einfache Sprache, mit der Text formatiert werden kann.

### 8. Was bedeutet GitHub-Flavoured Markdown (GFM)?

**Meine Antwort:** GitHub-Flavoured Markdown ist die von GitHub erweiterte Version von Markdown.

---

## 2 · GitHub-Flow

### 9. Bringe die Schritte in die richtige Reihenfolge

`Commit · Issue · Pull Request · Branch`

**Meine Antwort:** Issue - Branch - Commit - Pull Request

### 10. Was ist ein Issue?

**Meine Antwort:** Ein Issue beschreibt eine Aufgabe, ein Problem oder eine geplante Änderung.

### 11. Was ist ein Branch?

**Meine Antwort:** Ein Branch ist ein eigener Arbeitszweig eines Projekts.

### 12. Warum arbeitet man für eine Änderung häufig auf einem eigenen Branch?

**Meine Antwort:** Damit man Änderungen machen kann, ohne direkt den main-Branch zu verändern.

### 13. Was ist ein Commit?

**Meine Antwort:** Ein Commit ist ein gespeicherter Stand der Änderungen.

### 14. Wozu dient eine Commit-Nachricht?

**Meine Antwort:** Sie beschreibt kurz, was bei diesem Commit geändert wurde.

### 15. Was ist ein Pull Request?

**Meine Antwort:** Ein Pull Request ist eine Anfrage, Änderungen aus einem Branch in einen anderen zu übernehmen.

### 16. Was bedeutet Review?

**Meine Antwort:** Bei einem Review werden die Änderungen von jemandem überprüft.

### 17. Was bedeutet Merge?

**Meine Antwort:** Merge bedeutet, dass Änderungen aus verschiedenen Branches zusammengeführt werden.

### 18. Wann sollte ein Pull Request gemergt werden?

**Meine Antwort:** Wenn die Änderungen fertig und überprüft sind und funktionieren.

---

## 3 · Wichtige Git-Begriffe und Befehle

### 19. Was bedeutet Push?

**Meine Antwort:** Push lädt lokale Commits zu einem entfernten Repository, zum Beispiel auf GitHub, hoch.

### 20. Was bedeutet Pull?

**Meine Antwort:** Pull holt Änderungen aus einem entfernten Repository auf den eigenen Computer.

### 21. Was ist der Unterschied zwischen Commit und Push?

**Meine Antwort:** Commit speichert Änderungen lokal. Push lädt die Commits zu GitHub hoch.

### 22. Was ist der Unterschied zwischen Pull und Pull Request?

**Meine Antwort:** Pull lädt Änderungen herunter. Ein Pull Request bittet darum, Änderungen in einen anderen Branch zu übernehmen.

### 23. Was bedeutet Clone?

**Meine Antwort:** Clone erstellt eine lokale Kopie eines Repositorys auf dem Computer.

### 24. Was macht `git status`?

**Meine Antwort:** Zeigt den aktuellen Zustand des Repositorys und geänderte Dateien an.

### 25. Was macht `git add`?

**Meine Antwort:** Bereitet ausgewählte Änderungen für den nächsten Commit vor.

### 26. Was ist die Staging Area?

**Meine Antwort:** Die Staging Area ist der Bereich, in dem Änderungen für den nächsten Commit vorbereitet werden.

### 27. Was macht `git log`?

**Meine Antwort:** Zeigt die bisherigen Commits an.

### 28. Was bedeutet Branch wechseln?

**Meine Antwort:** Man wechselt von einem Arbeitszweig zu einem anderen.

### 29. Speichert `git add` bereits eine neue Version?

**Meine Antwort:** Nein. Es bereitet die Änderungen nur für einen Commit vor.

### 30. Speichert `git push` deine noch nicht committeten Dateiänderungen?

**Meine Antwort:** Nein. Push überträgt nur bereits erstellte Commits.

---

## 4 · GitHub-Flow praktisch erklären

### 31. Erkläre den GitHub-Flow in einem kurzen Satz.

**Meine Antwort:** Man erstellt für eine Aufgabe einen Branch, macht Commits, erstellt einen Pull Request und führt die Änderungen nach der Überprüfung zusammen.

### 32. Ordne die Begriffe zu

| Bedeutung | Git-/GitHub-Begriff |
|---|---|
| Aufgabe | Issue |
| Arbeitszweig | Branch |
| Speicherpunkt | Commit |
| Änderungsantrag | Pull Request |
| Zusammenführen | Merge |

### 33. Welche Richtung beschreibt Push?

**Meine Antwort:** Vom eigenen Computer → GitHub.

### 34. Welche Richtung beschreibt Pull?

**Meine Antwort:** Von GitHub → eigener Computer.

### 35. Warum sind mehrere sinnvolle Commits oft besser als ein einziger riesiger Commit?

**Meine Antwort:** Weil man dadurch Änderungen besser nachvollziehen und einzelne Arbeitsschritte erkennen kann.

### 36. Nenne ein Beispiel für eine gute Commit-Nachricht.

```text
README mit GitHub-Flow Antworten ergänzt
```

### 37. Warum ist die Commit-Nachricht `update` wenig hilfreich?

**Meine Antwort:** Weil man nicht erkennen kann, was genau geändert wurde.

---

## 5 · Markdown und README

### 38. Überschrift Ebene 1

Ergänze darunter eine Markdown-Überschrift der Ebene 1:

# Meine Lernsession

### 39. Ungeordnete Liste

Erstelle eine Liste mit mindestens drei Begriffen aus dieser Lernsession:

- Git
- GitHub
- Markdown

### 40. Link

Erstelle einen funktionierenden Markdown-Link zu GitHub oder Microsoft Learn:

[GitHub](https://github.com)

### 41. Bild

Schreibe die Markdown-Syntax für ein Bild mit Alternativtext:

```text
![Alternativtext](bild.png)
```

### 42. Inline-Code

Schreibe `git status` als Inline-Code in einem sinnvollen Satz:

Mit `git status` kann ich den aktuellen Zustand meines Repositorys sehen.

### 43. Codeblock

Ergänze mindestens drei Git-Befehle in diesem Codeblock:

```bash
git status
git add .
git commit -m "README aktualisiert"
```

### 44. Was sollte ein gutes Portfolio-README mindestens leisten?

**Meine Antwort:** Es sollte das Projekt verständlich erklären und zeigen, was ich gemacht und gelernt habe.

---

## 6 · Mein fachlicher Lernnachweis

### Was habe ich heute über Git und GitHub gelernt?

Ich habe gelernt, was der Unterschied zwischen Git und GitHub ist und wie der GitHub-Flow funktioniert.

### Was habe ich heute praktisch umgesetzt?

Ich habe mit Branches, Commits und Markdown gearbeitet und mein README bearbeitet.

### Meine konkrete Verbesserung aus dem Selbst- oder Peer-Check

Ich habe darauf geachtet, bessere und verständlichere Commit-Nachrichten zu schreiben.

### Mein nächster Portfolio-Schritt

Ich möchte mein README weiter verbessern und meine nächsten Projekte darin dokumentieren.

---

## 7 · Microsoft Learn · Abschlusskontrolle

- [ ] **Einführung in GitHub**: Übung, Modulbewertung und Zusammenfassung abgeschlossen
- [ ] **Effektive Kommunikation auf GitHub mithilfe von Markdown** abgeschlossen
- [ ] Ich habe meinen Lernfortschritt / meine Modulbewertung kontrolliert.

## 8 · Begriffe · deutsche Merkhilfe

Fülle die zweite Spalte mit einer kurzen deutschen Merkhilfe aus.

| Begriff | Deutsche Merkhilfe |
|---|---|
| Issue | Aufgabe / Problem |
| Branch | Arbeitszweig |
| Commit | Speicherpunkt |
| Push | Hochladen |
| Pull | Herunterladen |
| Pull Request | Änderungsantrag |
| Review | Überprüfung |
| Merge | Zusammenführen |
| Clone | Kopie erstellen |
| Repository | Projektablage |

---

## 9 · Selbstcheck

- [ ] Ich kann **Git** und **GitHub** unterscheiden.
- [ ] Ich kann **Issue → Branch → Commit → Pull Request → Merge** erklären.
- [ ] Ich kenne den Unterschied zwischen **Commit** und **Push**.
- [ ] Ich kenne den Unterschied zwischen **Pull** und **Pull Request**.
- [ ] Ich kann Überschriften, Listen, Links, Bilder und Codeblöcke in Markdown verwenden.
- [ ] Mein README wird auf GitHub korrekt gerendert.
- [ ] Ich habe mindestens eine konkrete Verbesserung umgesetzt.
- [ ] Ich habe meine Änderung mit einer aussagekräftigen Commit-Nachricht dokumentiert.

## Meine Commit-Nachricht für diese Abgabe

```text
DEINE COMMIT-NACHRICHT
```
