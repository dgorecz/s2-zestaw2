# Trudniejszy zestaw

## Zadanie 1 – List<T>
Napisz program, który:
1. Tworzy List<int> z liczbami:
4, 12, 7, 19, 3, 15, 8, 21, 6
2. Za pomocą Find() znajdź:
* pierwszą liczbę większą niż 10
* pierwszą liczbę podzielną przez 3
3. Wyświetl znalezione wartości.
4. Usuń wszystkie liczby mniejsze niż 5.
5. Wyświetl listę po usunięciu elementów.

## Zadanie 2 – List<T> + LINQ (filtrowanie)
Utwórz List<int> zawierającą liczby:
5, 14, 22, 3, 17, 8, 10, 31, 6, 27
Używając LINQ:
1. Wybierz wszystkie liczby parzyste.
2. Wybierz liczby większe niż 15.
3. Posortuj liczby malejąco.
4. Oblicz:
* sumę
* średnią
* największą wartość.

## Zadanie 3 – Lista obiektów + Find()
Utwórz klasę:

`class Student
{
public string Imie;
public int Wiek;
public double Srednia;
}`

Utwórz List<Student> z danymi:
* Jan, 20, 4.2
* Anna, 22, 4.8
* Piotr, 19, 3.5
* Kasia, 21, 4.6

Z użyciem Find():
1. Znajdź studenta o imieniu Anna.
2. Znajdź pierwszego studenta ze średnią powyżej 4.5.
3. Wyświetl dane znalezionych studentów.

## Zadanie 4 – Lista obiektów + LINQ
Użyj tej samej listy studentów.
Z użyciem LINQ:
1. Wyświetl studentów ze średnią > 4.0.
2. Posortuj studentów według średniej malejąco.
3. Wyświetl tylko imiona studentów (Select).
4. Oblicz średnią wszystkich średnich ocen.

## Zadanie 5 – Dictionary + LINQ
Utwórz słownik:
Dictionary<string, int>
Dane:
* Jan → 4
* Anna → 5
* Piotr → 3
* Kasia → 5
* Tomek → 2
Z użyciem LINQ:
1. Znajdź osoby z oceną 5.
2. Znajdź osoby z oceną ≥ 4.
3. Posortuj słownik według ocen malejąco.
4. Wyświetl tylko imiona osób.

## Zadanie 6 – Kolekcja + FindAll + LINQ
Utwórz listę:
List<int> liczby = {12, 5, 8, 19, 23, 4, 16, 7, 30}
1. Za pomocą Find() znajdź pierwszą liczbę > 20.
2. Za pomocą FindAll() znajdź wszystkie liczby parzyste.
3. Używając LINQ:
* wybierz liczby > 10
* posortuj je rosnąco
* wyświetl wynik.
