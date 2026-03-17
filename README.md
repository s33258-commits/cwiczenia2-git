# cwiczenia2-git

Prosty projekt konsolowy w .NET przygotowany w ramach ćwiczeń z Git i GitHub.

Projekt zawiera metody do wykonywania prostych operacji na liczbach:
- obliczanie kwadratu liczby,
- obliczanie średniej dwóch liczb,
- obliczanie średniej z tablicy `int[]`,
- obliczanie maksimum z tablicy `int[]`,
- obliczanie minimum z tablicy `int[]`.

## Fast-forward i merge commit

Git wykona merge typu **fast-forward** wtedy, gdy gałąź `main` nie ma nowych commitów od momentu utworzenia drugiej gałęzi. W takiej sytuacji Git tylko przesuwa wskaźnik gałęzi do przodu i nie tworzy osobnego commita scalającego.

**Merge commit** powstaje wtedy, gdy obie gałęzie mają własne nowe commity i historia zmian się rozeszła. W takiej sytuacji Git musi utworzyć osobny commit scalający.

## Merge a rebase

W praktyce **merge** łączy historię dwóch gałęzi i może tworzyć osobny commit scalający. Dzięki temu zachowana jest pełna historia rozgałęzienia.

**Rebase** przenosi commity z jednej gałęzi na szczyt drugiej gałęzi. Dzięki temu historia jest bardziej liniowa i czytelna, ale zmienia identyfikatory commitów.



