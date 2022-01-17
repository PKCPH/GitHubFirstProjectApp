Person p = new("Niels", "Olesen", new DateTime(1992, 4, 5));

Console.WriteLine(p.GetFullName());

Person p2 = new();

Console.WriteLine(p2.GetFullName());

//birthday
Console.WriteLine(p.birthDateInDanishFormat);

//age
Console.WriteLine(p.Age);

//timespan
Console.WriteLine(p.TimeSpanInTotalDays);