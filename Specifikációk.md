Klasszikus Snake játék megvalósítása C# nyelven, konzolos környezetben.
A játék célja: a játékos a nyílbillentyűkkel irányítva vezeti a kígyót, és minél
több ételt („X”) gyűjt össze anélkül, hogy falnak vagy saját magának ütközne.

Játékmenet:

Játéktér:
Méret: fix méretű (pl. 20×20 karakteres pálya)
Konzolos megjelenítés
Határok megadása (pálya széle fal)

Kígyó:
Kezdeti hossza: 1 egység
Mozgása: minden ciklusban 1 mezőt lép az aktuális irányba
Ha ételt eszik, nő
Ha falba vagy saját magába ütközik, játék vége ( Game Over )

Étel:
A pályán egy étel ( x ) található
Minden étkezés után új pozícióra kerül ( random, nem a kígyón )

Mozgás:
A játékos “W-A-S-D”-vel mozgatja a kígyót
A kígyó nem fordulhat vissza közvetlenül ellentétes irányba

Játék vége:
Kíirás: “Vége a játéknak! - Elért pontszám: (x)”
A pontszám a megevett ételt mutatja ( Kígyó hossza -1 )
