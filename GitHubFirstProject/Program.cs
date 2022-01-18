
Car car = new("Jan Nielsen", "Volvo", "AB123456", new DateTime(2008, 5, 1));

Console.WriteLine($"Customer Name: {car.NameOfOwner}");
Console.WriteLine($"Car Brand: {car.Brand}");
Console.WriteLine($"License Plate: {car.LicensePlate}");
Console.WriteLine($"Date for car buy date: {car.CarAgeYear}");

car.CheckCarVisionStatus();
Console.ReadLine();