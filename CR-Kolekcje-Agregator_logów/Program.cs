using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {   
        // wczytanie danych
        int n = int.Parse(Console.ReadLine());
        string[] tab = new string[n];
        for (int i = 0; i < n; i++)
        {
            tab[i] = Console.ReadLine();
        }

        var userTime = new SortedDictionary<string, int>();
        var userIps = new Dictionary<string, SortedSet<string>>();

        // przetwarzanie danych
        foreach(var komorka in tab)
        {
            var temp = komorka.Split(' ');
            var ip = temp[0];
            var login = temp[1];
            var time = int.Parse(temp[2]);

            if(userTime.ContainsKey(login))
                userTime[login] += time;
            else
                userTime.Add(login, time);

            if(userIps.ContainsKey(login))
                userIps[login].Add(ip);
            else
                userIps.Add(login, new SortedSet<string>(){ip});
        }

        // drukuj wynik
        
        foreach(var item in userTime)
        {
            var user = item.Key;
            var sumTime = item.Value;
            var ips = userIps[user];

            Console.WriteLine($"{user}: {sumTime} [{string.Join(", ", ips)}]");
        }
    }
}