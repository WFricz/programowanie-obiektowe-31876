// Zadanie 0

// const int requiredAge = 18;
// const int requiredAge2 = 14;
// const string accessDenied = "Musisz mieć minimum 14 lat.";
// const string accessAllowed = "Witamy pana(ią) w naszym sklepie.";
// const string partialAccess = "Witamy, młodzieńcze, w naszym sklepie.";
//
// int age = 19;
//
// do
// {
//     Console.WriteLine("Podaj swój wiek: ");
//
//     string input = Console.ReadLine();
//
//     bool success = int.TryParse(input, out age);
//
//     if (!success)
//     {
//         Console.WriteLine("Podaj poprawną wartość!");
//     }
//     else
//     {
//         if (age < requiredAge2)
//         {
//             Console.WriteLine(accessDenied);
//         }
//         else if (age < requiredAge)
//         {
//             Console.WriteLine(partialAccess);
//         }
//         else
//         {
//             Console.WriteLine(accessAllowed);
//         }
//     }
// } while (age < requiredAge);

// Example 2

// var names = new[] { "Artur", "Alicja", "Michał", "Gosia" };
//
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }
//
// foreach (var name in names)
// {
//     Console.WriteLine(name);
// }

//Zadanie 1

// string password;
// do
// {
//     Console.Write("Podaj hasło: ");
//     password = Console.ReadLine();
// }
// while (password != "admin123");
// Console.WriteLine("Zalogowano pomyślnie!");

//Zadanie 2

// double liczba;
// do
// {
//     Console.Write("Podaj liczbę dodatnią: ");
//     liczba = Convert.ToDouble(Console.ReadLine());
// }
// while (liczba <= 0);
// Console.WriteLine("Poprawna odpowiedź");

//Zadanie 3

string[] miasta = {"Kraków", "Rzeszów", "Poznań", "Łódź", "Gdańsk"};
foreach (string miasto in miasta)
{
    Console.WriteLine("Miasto: " + miasto);
}