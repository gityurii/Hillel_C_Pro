namespace HW3;
/*
 * Створіть інтерфейс ISort.
   У ньому мають бути три методи:
   ■ void SortAsc() — сортування за зростанням;
   ■ void SortDesc() — сортування за зменшенням;
   ■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра.
   Якщо isAsc дорівнює true, сортуємо за зростанням.
   Якщо isAsc дорівнює false, сортуємо за зменшенням
 */
public interface ISort
{
  void SortAsc();
  void SortDesc();
  void SortByParam(bool isAsc);
}