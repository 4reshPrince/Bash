Kratos theKratos = new Kratos();
Zeus theZeus = new Zeus();

Console.WriteLine($"{theKratos.name} - {theKratos.health} health");

Console.WriteLine();

Console.WriteLine($"{theZeus.name} - {theZeus.health} health");

Console.WriteLine();

Console.WriteLine("Kratos impales the Blade of Olympus in the chest of Zeus");
theZeus.health -= 95;

Console.WriteLine();

Console.WriteLine($"{theZeus.name} - {theZeus.health} health");

Console.WriteLine();

Console.WriteLine("Zeus is barely living as he is dying of the impaled Blade of Olympus.");
Console.WriteLine();
Console.WriteLine("The same blade that Zeus used to kill Kratos which made Kratos go back");
Console.WriteLine("to hell and slaughter everyone on his way back from the home of Hades.");

Console.WriteLine();

Console.WriteLine("Press key to Exit");
Console.ReadKey();

