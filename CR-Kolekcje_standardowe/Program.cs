// Utwórz listę elementów typu string reprezentującą zwyczajowe nazwy gatunków zwierząt (np. kot, pies, ...).

var zwierzaki = new List<string>();

// Dodaj do niej co najmniej 5 elementów.
zwierzaki.Add("kot");
zwierzaki.Add("pies");
zwierzaki.Add("rybka");
zwierzaki.Add("papuga");
zwierzaki.Add("mysz");

// Wydrukuj zawartość listy na konsoli.
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Usuń z listy element ostatni oraz element drugi.
zwierzaki.RemoveAt(zwierzaki.Count - 1);
zwierzaki.RemoveAt(1);

// Ponownie wydrukuj zawartość listy na konsoli.
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Wstaw na koniec listy element mucha.
zwierzaki.Add("mucha");

// Wstaw na pozycji 1 element gazela.
zwierzaki.Insert(1, "gazela");

// Ponownie wydrukuj zawartość listy na konsoli.
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Usuń z listy element gazela.
zwierzaki.Remove("gazela");

// Ponownie wydrukuj zawartość listy na konsoli.
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Wypisz na konsoli true jeśli element krowa jest na liście, w przeciwnym przypadku wypisz false.
Console.WriteLine(zwierzaki.Contains("krowa"));

// Wypisz na konsoli indeks elementu mucha.
Console.WriteLine(zwierzaki.IndexOf("mucha"));

// Odwróć kolejność elementów na liście i wypisz ma konsoli zawartość listy.
zwierzaki.Reverse();

// Posortuj listę w kolejności rosnącej i wypisz ją. Wykorzystamy domyślny sposób porównywania napisów.
zwierzaki.Sort();
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Posortuj listę w kolejności malejącej i wypisz ją. Wskazówka: argumentem metody sortującej będzie obiekt typu Comparison<string>, czyli funkcja porównująca: (x,y) => y.CompareTo(x).
zwierzaki.Sort((x, y) => y.CompareTo(x));
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}

// Dodatkowe: Posortuj listę w kolejności od najkrótszego do najdłuższego napisu. Jeśli napisy są tej samej długości, przyjmij naturalny porządek zdefiniowany w typie string.
zwierzaki.Sort((x, y) => x.Length.CompareTo(y.Length));
foreach (var zwierzak in zwierzaki)
{
    Console.WriteLine(zwierzak);
}
