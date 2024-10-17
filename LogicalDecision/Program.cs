// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin") & level > 55 ) {
    Console.WriteLine("Welcome, Super Admin user");
    return;
}

if(permission.Contains("Admin") & level <= 55) {
    Console.WriteLine("Welcome, Admin user");
    return;
}

if(permission.Contains("Manager") & level >= 20) {
    Console.WriteLine("Contact an Admin for access.");
    return;
}

if(permission.Contains("Manager") & level < 20) {
    Console.WriteLine("You do not have sufficient privilages.");
    return;
}


// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }