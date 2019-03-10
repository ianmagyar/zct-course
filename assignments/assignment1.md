# Základy cloudových technológií - Zadanie 1

Vytvorte a deploynite webovú aplikáciu na MS Azure, ktorá bude slúžiť ako používateľské rozhranie pre klasifikáciu údajov. Klasifikácia bude dostupná vo forme služby MS Azure Machine Learning Studio. Webová aplikácia má takisto poskytovať vizualizáciu údajov (základných a používateľom pridaných). Zadanie odovzdajú tímy dvoch alebo troch študentov (prípadne samostatne).

## Datasety
Ako datasety pre klasifikáciu použite [voľne dostupné dáta](http://archive.ics.uci.edu/ml/index.php). Každý tím vyberie jeden dataset. Tímy majú možnosť spracovať aj vlastné údaje po dohode s cvičiacim.

Datasety:

1. [Drug consumption](http://archive.ics.uci.edu/ml/datasets/Drug+consumption+%28quantified%29)
2. [Adult](http://archive.ics.uci.edu/ml/datasets/Adult)
3. [Occupancy detection](http://archive.ics.uci.edu/ml/datasets/Occupancy+Detection)
4. [Wine quality](http://archive.ics.uci.edu/ml/datasets/Wine+Quality)
5. [Poker hand](http://archive.ics.uci.edu/ml/datasets/Poker+Hand)
6. [Flags](http://archive.ics.uci.edu/ml/datasets/Flags)
7. [Facebook metrics](http://archive.ics.uci.edu/ml/datasets/Facebook+metrics)
8. [Air quality](http://archive.ics.uci.edu/ml/datasets/Air+Quality)
9. [Facebook comments](http://archive.ics.uci.edu/ml/datasets/Facebook+Comment+Volume+Dataset)
10. [Mushroom](http://archive.ics.uci.edu/ml/datasets/Mushroom)

## Popis riešenia
Zadanie sa skladá z dvoch základných častí: služba pre klasifikáciu údajov a webová aplikácia.

### Služba pre klasifikáciu údajov
Na vytvorenie služby pre klasifikáciu údajov použite [MS Azure Machine Learning Studio](https://studio.azureml.net). Pre úspešné odovzdanie je potrebné vytvoriť službu, natrénovať model, službu následne deploynúť a použiť vo webovej aplikácii.

### Webová aplikácia
Pri vytvorení webovej aplikácie Vám odporúčame použiť systémový vzor MVC, nie je to však vyžadované! Webová aplikácia sa má skladať z dvoch základných častí: rozhranie pre klasifikáciu údajov a rozhranie pre vizualizáciu klasifikovaných údajov. Pre vizualizáciu údajov je potrebné vytvoriť jednoduchú databázu, kde uložíte vstupy zadané používateľom a výsledky klasifikácie. Svoje riešenie môžete rozšíriť o ďalšiu funkcionalitu pre ďalšie body.

Pre úspešné odovzdanie zadania je potrebné webovú aplikáciu deploynúť na MS Azure a následne prezentovať jej funkčnosť vo forme live demo.

## Hodnotenie zadania
Za riešenie zadania je možné získať celkovo 20 bodov. Body sa udeľujú nasledovne:

1. prezentácia návrhu – 25. 2. 2018 (5 bodov) – **prezentácia musí byť online**
	* analýza údajov (2 body) - aké údaje dataset obsahuje, ktoré použijete v riešení, čo budete klasifikovať
	* návrh štruktúry riešenia (2 body) - systémová architektúra, popis komunikácie medzi jednotlivými prvkami
	* vytvorenie git projektu na [školskom gitlabe](https://gitlab.cit.fei.tuke.sk/) alebo na [githube](https://github.com) (1 bod)
2. prezentácia riešenia – 11. 3. 2018 (15 bodov)
	* Machine Learning Studio služba (5 bodov)
	* web app (5 bodov)
	* kvalita riešenia, rozšírená funkcionalita (5 bodov)