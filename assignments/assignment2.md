# Základy cloudových technológií - Zadanie 2

Druhé zadanie je zamerané na využitie už existujúcich cloudových služieb pri vytvorení vlastných aplikácií. Výstupom zadania bude aplikácia (lokálna, mobilná alebo cloudová), ktorá bude používať aspoň tri cloudové služby pre rozšírenie svojej funkcionality.

## Cloudové služby
Vo Vašich zadaniach potrebujete použiť aspoň tri cloudové služby pre podporu aplikácie. Komunikácia s týmito službami nech je uskutočnená cez volania Rest API.

Voľbu cloudových služieb necháme na Vás, avšak Vaša aplikácia **musí byť** obohatená funkcionalitou umelej inteligencie. Môžete to riešiť cez ľubovoľnú službu z [Microsoft Cognitive Services](https://azure.microsoft.com/en-us/services/cognitive-services/) alebo zodpovedajúcimi službami iných providerov.

Návrh na ďalšie služby (nemusíte ich použiť, slúžia len ako inšpirácia):

* ľubovoľná databázová technológia (pre prihlasovanie používateľov, zaznamenanie ich údajov, synchronizáciu, atď.)
* úložiská pre rôzne súbory
* [GMail API](https://developers.google.com/gmail/api/) alebo podobná služba pre prácu s emailom
* [Calendar API](https://developers.google.com/calendar/) alebo podobná služba pre zaznamenanie udalostí, meetingov, atď.
* [Notification Hubs](https://azure.microsoft.com/en-us/services/notification-hubs/) pre posielanie notifikácií na mobilné telefóny

## Popis riešenia
Zadanie sa skladá z aplikácie, ktorá počas svojho behu používa cloudové služby ponúkané poskytovateľom. Samotná funkcionalita aplikácie je ľubovoľná, podstatné je to, aby ste získali skúsenosti s použitím cloudových služieb a volaním cez API requesty.

Ak Vaša bakalárska práca sa zaoberá cloudmi, je možnosť odovzdať časť práce ako zadanie.

## Hodnotenie zadania
Za riešenie zadania je možné získať celkovo 20 bodov. Body sa udeľujú nasledovne:

1. prezentácia návrhu - 25. 3. 2019 (5 bodov)
	* návrh funkcionality aplikácie (2 body)
	* popis vybratých cloudových služieb (1.5 boda)
	* predstavenie API cloudových služieb a popis komunikácie aplikácie so službami (1.5 boda)
2. prezentácia riešenia - do 19. 4. 2019 (15 bodov)
	* aplikácia (6 bodov)
	* využitie cloudových služieb (9 bodov, 3 za každú použitú službu)