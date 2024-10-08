/*
 * Створити базовий клас «Музичний інструмент» і похідні класи: «Скрипка», «Тромбон», «Укулеле», «Віолончель».
 * За допомогою конструктора, встановити назву до кожного музичного інструменту і його характеристики.
 * Реалізуйте для кожного з класів методи:
 * ■ Sound — видає звук музичного інструменту (пишемо текстом у консоль);
 * ■ Show — відображає назву музичного інструменту;
 * ■ Desc — відображає опис музичного інструменту;
 * ■ History — відображає історію створення музичного інструменту.
 * Додати iнкапсуляцiю до полiв та методiв якщо треба.
 */
namespace C_Pro_Practice.HW2;

public class MusicalInstrument
{
 public string Name { get; private set; }
 public string Description { get; private set; }
 public string HistoryInfo { get; private set; }
 
 public MusicalInstrument(string name, string description, string history)
 {
  Name = name;
  Description = description;
  HistoryInfo = history;
 }
 
 public virtual void Sound()
 {
  Console.WriteLine("This musical instrument makes a sound.");
 }

 public void Show()
 {
  Console.WriteLine($"Instrument name: {Name}");
 }

 public void Desc()
 {
  Console.WriteLine($"Instrument description: {Description}");
 }

 public void History()
 {
  Console.WriteLine($"Instrument history: {HistoryInfo}");
 }
}