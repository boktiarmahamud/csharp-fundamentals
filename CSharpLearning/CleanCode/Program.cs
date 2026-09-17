using CleanCode;

Customer customer = new(
    "Boktiar Mahamud",
    "boktiarmahamud@gmail.com");

CustomerService customerService = new();

customerService.Register(customer);

Console.ReadKey();