using HW3;
// Напишіть код для тестування отриманої функціональності.

// #1
Console.WriteLine("\nTask #1");

var firstArray = new MyArray([2, 3, 5, -6, 8]);

firstArray.Show();
firstArray.Show("The first array items: ");

// #2
Console.WriteLine("\nTask #2");

var secondArray = new MyArray
{
    Array = [25, 3, -5, 6, 18]
};
secondArray.Show("The second array items: ");
Console.WriteLine($"Max value: {secondArray.Max()}");
Console.WriteLine($"Min value: {secondArray.Min()}");
Console.WriteLine($"Average value: {secondArray.Avg()}");

var x1 = -4;
Console.WriteLine($"Number {x1} is in array: {secondArray.Search(x1)}");
var x2 = 18;
Console.WriteLine($"Number {x2} is in array: {secondArray.Search(x2)}");

// #3
Console.WriteLine("\nTask #3");
 
var isAsc = true;
firstArray.SortByParam(isAsc);
firstArray.Show("The first array is sorted Ascending: ");

isAsc = false;
secondArray.SortByParam(isAsc);
secondArray.Show("The second array is sorted Descending: ");