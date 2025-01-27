namespace W_Sprawdzian_OOP
{
    class Program
    {
        static void Main()
        {
            // Test: poprawne tworzenie obiektu Player, dane poprawne
//       typowe czynności poprawne
           	
// Test: tworzenie obiektu Player, name do skorygowania,
// spacje w środku, białe znaki na początku i końcu, wielkość liter
// Test: AddScore
Player p = new Player(name: "mol123", password: "aB12.,aC");
Console.WriteLine(p);
try{
  p.AddScore(-1);
}
catch(ArgumentOutOfRangeException e) {
    Console.WriteLine(e.Message);
}
try {
  p.AddScore(101);
}
catch(ArgumentOutOfRangeException e) {
    Console.WriteLine(e.Message);
}
p.AddScore(100);
Console.WriteLine(p);
p.AddScore(0);
Console.WriteLine(p);

//             var logs = @"2021-06-10 5:20 mirek 180.40.41.120
// 2021-06-10 10:20 adam 80.40.41.120
// 2021-06-10 10:21 admin 192.168.4.10
// 2021-06-11 8:09 maciek 149.40.53.12
// 2021-06-11 8:10 adam 80.40.41.120
// 2021-06-11 18:10 mirek 180.40.41.120";

//             var logs2 = @"2021-06-10 5:20 mirek 180.40.41.120
// 2021-06-10 10:20 adam 80.40.41.120
// 2021-06-10 10:21 admin 192.168.4.10
// 2021-06-11 8:09 maciek 149.40.53.12
// 2021-06-11 8:10 kazik 80.40.41.120";

//             Analyze(logs);
//             Analyze(logs2);

        }

        public static void Analyze(string logs)
        {
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