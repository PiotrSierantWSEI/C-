/* Listy */
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

/* Kolejka i stos */
// Utwórz pustą kolejkę i pusty stos napisów (typu string).
var kolejka = new Queue<string>();
var stos = new Stack<string>();

// Wstaw na stos kolejno elementy: 1, 2, 3, 4.
stos.Push("1");
stos.Push("2");
stos.Push("3");
stos.Push("4");

// Wstaw do kolejki kolejno elementy: a, b, c, d.
kolejka.Enqueue("a");
kolejka.Enqueue("b");
kolejka.Enqueue("c");
kolejka.Enqueue("d");

// Wypisz na konsoli zawartość stosu i zawartość kolejki.
foreach (var element in stos)
{
    Console.WriteLine(element);
}

// Zdejmij ze stosu dwa elementy i wstaw je do kolejki.
kolejka.Enqueue(stos.Pop());

// Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.
foreach (var element in stos)
{
    Console.WriteLine(element);
}

// Wypisz na konsoli (nie usuwając) element szczytowy stosu i element czołowy z kolejki.
Console.WriteLine(stos.Peek());
Console.WriteLine(kolejka.Peek());

// Usuń ze stosu dwa elementy i wstaw do kolejki element e.
stos.Pop();
stos.Pop();
kolejka.Enqueue("e");

// Wypisz na konsoli zawartość stosu i zawartość kolejki po zmianach.
foreach (var element in stos)
{
    Console.WriteLine(element);
}

// Spróbuj przesunąć ze stosu element szczytowy i wstawić go do kolejki.
var elementSzczytowy = stos.Pop();
if (elementSzczytowy != null)
{
    kolejka.Enqueue(elementSzczytowy);
}

/* Zbiór */

// Utwórz dwa zbiory liczb całkowitych: A = {1, 3, 5, 2, 7, 8} oraz B = {2, 1, 5, 3, 9, 6}.
var A = new HashSet<int> { 1, 3, 5, 2, 7, 8 };
var B = new HashSet<int> { 2, 1, 5, 3, 9, 6 };

// Wypisz zawartość tych zbiorów na konsoli.
foreach (var item in A)
{
    Console.WriteLine(item);
}
foreach (var item in B)
{
    Console.WriteLine(item);
}

// Napisz metodę void DisplaySet<T>(ISet<T> set) wypisującą na konsolę elementy zbioru podanego jako argument.
static void DisplaySet<T>(ISet<T> set)
{
    foreach (var item in set)
    {
        Console.WriteLine(item);
    }
}

// Utwórz zbiór C będący sumą zbiorów A oraz B. Posortuj go malejąco. Wypisz na konsolę jego elementy.
var C = new HashSet<int>(A);
C.UnionWith(B);
var CList = C.ToList();
CList.Sort((x, y) => y.CompareTo(x));
foreach (var item in CList)
{
    Console.WriteLine(item);
}

// Oblicz średnią arytmetyczną zbioru C i wypisz ją na konsolę.
var srednia = CList.Average();
Console.WriteLine(srednia);

// Wypisz na konsolę część wspólną zbiorów A oraz B.
var wspolne = new HashSet<int>(A);
wspolne.IntersectWith(B);
DisplaySet(wspolne);

// Sprawdź, czy zbiór {6, 9} jest podzbiorem różnicy symetrycznej zbiorów B oraz A.
var podzbior = new HashSet<int> { 6, 9 };
var roznicaSymetryczna = new HashSet<int>(B);
roznicaSymetryczna.SymmetricExceptWith(A);
Console.WriteLine(podzbior.IsSubsetOf(roznicaSymetryczna));

/* Słownik */

// Za pomocą klasy Dictionary, stwórz co najmniej 5-elementowy słownik zawierający listę zwierząt ("kot", "pies", "krowa”, "wąż", ...) i odpowiadającą im liczbę nóg.
var zwierzeta = new Dictionary<string, int>
{
    { "kot", 4 },
    { "pies", 4 },
    { "krowa", 4 },
    { "wąż", 0 },
    { "pająk", 8 }
};

// Wydrukuj zawartość słownika na konsolę.
foreach (var item in zwierzeta)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

// Przetestuj, czy zawiera on wybrany element za pomocą metod ContainsKey i TryGetValue.
Console.WriteLine(zwierzeta.ContainsKey("krowa"));
if (zwierzeta.TryGetValue("krowa", out int value))
{
    Console.WriteLine(value);
}

// Sprawdź, czy w słowniku są zwierzęta z 6 nogami.
foreach (var item in zwierzeta)
{
    if (item.Value == 6)
    {
        Console.WriteLine(item.Key);
    }
}

// Dodaj do słownika zwierzę "pająk" z liczbą nóg 6.
zwierzeta["pająk"] = 6;

// Wypisz na konsoli zawartość słownika.
foreach (var item in zwierzeta)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

// Zmień pająkowi liczbę nóg na 8.
zwierzeta["pająk"] = 8;

// Wypisz na konsoli zwierzęta zapamiętane w słowniku, w kolejności rosnącej (Keys).
foreach (var item in zwierzeta.Keys.OrderBy(x => x))
{
    Console.WriteLine(item);
}

// Wypisz na konsoli zbiór nóg zapamiętanych w słowniku (Values).
foreach (var item in zwierzeta.Values)
{
    Console.WriteLine(item);
}

// Wypisz na konsoli te zapamiętane zwierzęta, które maja 4 nogi.
foreach (var item in zwierzeta)
{
    if (item.Value == 4)
    {
        Console.WriteLine(item.Key);
    }
}

// Wypisz na konsoli sumę nóg zapisanych w słowniku zwierząt.
Console.WriteLine(zwierzeta.Values.Sum());

// Spróbuj ponownie dodać do słownika pająka z liczbą nóg 8.
zwierzeta.TryAdd("pająk", 8);

// Usuń wpis dotyczący pająka ze słownika.
zwierzeta.Remove("pająk");

// Wypisz na konsoli zwierzęta oraz liczbę nóg, w kolejności od najmniejszej liczby nóg do największej. W przypadku tej samej liczby nóg wypisz zwierzęta w kolejności rosnącej (porządek leksykograficzny).
foreach (var item in zwierzeta.OrderBy(x => x.Value).ThenBy(x => x.Key))
{
    Console.WriteLine($"{item.Key} {item.Value}");
}
