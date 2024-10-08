using C_Pro_Practice.HW2;

// Task 1. Examples
Console.WriteLine("Task 1. Examples:");

Money userMoney = new Money("Dollar", "Cent", 20, 150);
Console.WriteLine($"User balance is: {userMoney}");

userMoney.SetNewBalance(35, 99);
Console.WriteLine($"New balance is: {userMoney}");

Console.WriteLine();

Product newProd = new Product(new Money("Dollar", "Cent", 10, 50));
Console.WriteLine($"Product price is: {newProd.Price}");

newProd.DecreasePrice(new Money("Dollar", "Cent", 5, 60));
Console.WriteLine($"Discount price is: {newProd.Price}");

// Task 2. Examples
Console.WriteLine();
Console.WriteLine("Task 1. Examples:");