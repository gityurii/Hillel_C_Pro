namespace HW3;
/*
 * Створіть інтерфейс IMath.
   У ньому мають бути чотири методи:
   ■ int Max() — повертає максимум;
   ■ int Min() — повертає мінімум;
   ■ float Avg() — повертає середньоарифметичне;
   ■ bool Search(int valueToSearch) — шукає valueSearch всередині контейнера даних.
   - Повертає true, якщо значення знайдено.
   - Повертає false, якщо значення не знайдено.
 */

public interface IMath
{
    int Max();
    int Min();
    float Avg();
    bool Search(int valueToSearch);
}