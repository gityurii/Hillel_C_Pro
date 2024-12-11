namespace HW3;
/*
 #1
 * Створіть клас MyArray (масив цілого типу) із необхідними методами.
 * Цей клас має імплементувати інтерфейс IOutput.
 * Метод Show() — відображає на екран елементи масиву.
 * Метод Show(string info) — відображає на екрані елементи масиву та
    інформаційне повідомлення, зазначене у параметрі info.
 #2
 * Клас, створений у першому завданні Array, має імплементувати інтерфейс IMath.
   Метод Max — повертає максимум серед елементів масиву.
   Метод Min — повертає мінімум серед елементів масиву.
   Метод Avg — повертає середньоарифметичне серед елементів масиву.
   Метод Search — шукає значення всередині масиву.
   - Повертає true, якщо значення знайдено.
   - Повертає false, якщо значення не знайдено.
 #3
   Метод SortAsc — сортує масив за зростанням.
   Метод SortDesc — сортує масив за спаданням.
   Спосіб SortByParam — сортує масив залежно від переданого параметра.
   Якщо isAsc дорівнює true, сортуємо за зростанням.
   Якщо isAsc дорівнює false, сортуємо за зменшенням.
 */

public class MyArray : IOutput, IMath, ISort
{
    public int[] Array { get; set; }
    public MyArray(int[] initialArray)
    {
        Array = initialArray;
    }

    public MyArray() {}
    // #1
    public void Show()
    {
        Console.Write("Array items: ");
        {
            Console.WriteLine(string.Join(", ", Array));
        }
    }
    public void Show(string info)
    {
        Console.Write($"{info}: ");
        {
            Console.WriteLine(string.Join(", ", Array));
        }
    }
    // #2
    public int Max()
    {
        return Array.Max();
    }
    public int Min()
    {
        return Array.Min();
    }
    public float Avg()
    {
        return (float)Array.Average();
    }
    public bool Search(int valueToSearch)
    {
        return Array.Contains(valueToSearch);
    }
    // #3
    public void SortAsc()
    {
        Array = Array.OrderBy(x => x).ToArray();
    }
    public void SortDesc()
    {
        Array = Array.OrderByDescending(x => x).ToArray();
    }
    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}