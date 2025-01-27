namespace CR_ANALIZA_LOGOW
{
    class Program
    {
        static void Main()
        {

            var logs = @"2021-06-10 5:20 mirek 180.40.41.120
2021-06-10 10:20 adam 80.40.41.120
2021-06-10 10:21 admin 192.168.4.10
2021-06-11 8:09 maciek 149.40.53.12
2021-06-11 8:10 adam 80.40.41.120
2021-06-11 18:10 mirek 180.40.41.120";

            var logs2 = @"2021-06-10 5:20 mirek 180.40.41.120
2021-06-10 10:20 adam 80.40.41.120
2021-06-10 10:21 admin 192.168.4.10
2021-06-11 8:09 maciek 149.40.53.12
2021-06-11 8:10 kazik 80.40.41.120";

            Analyze(logs);
            Analyze(logs2);
        }

        public static void Analyze(string logs)
        {
            /*
                wypisującą na standardowe wyjście, w porządku rosnącym, loginy użytkowników, którzy w badanym okresie zalogowali się do serwisu przynajmniej jeden raz każdego dnia.
                Nie wypisuj duplikatów.
                Loginy użytkowników wypisz w jednej linii, oddzielając je przecinkiem i pojedynczą spacją.
                W przypadku braku użytkowników spełniających warunki zadania wypisz słowo empty.
                ⚠️ Rozwiąż zadanie wykorzystując właściwie dobrane do problemu standardowe kolekcje C#. Zabronione jest używanie operatorów LINQ.
            */

            var lines = logs.Split('\n');
            var users = new SortedDictionary<string, SortedSet<string>>();
            var usersInEveryDay = new SortedSet<string>();

            foreach(var line in lines)
            {
                var temp = line.Split(' ');
                var date = temp[0];
                var user = temp[2];

                if(users.ContainsKey(date))
                {
                    users[date].Add(user);
                }
                else
                {
                    users.Add(date, new SortedSet<string>(){user});
                }
            }

            foreach(var item in users) {
                // utworzyc listę userow ktorzy powtarzają się przynajmniej raz w każdym dniu
                foreach(var user in item.Value)
                {
                    var isUserInEveryDay = true;
                    foreach(var item2 in users)
                    {
                        if(!item2.Value.Contains(user))
                        {
                            isUserInEveryDay = false;
                            break;
                        }
                    }
                    if(isUserInEveryDay)
                    {
                        usersInEveryDay.Add(user);
                    }
                }
            }
            Console.WriteLine(usersInEveryDay.Count == 0 ? "empty" : $"{string.Join(", ", usersInEveryDay)}");
        }
    }
}