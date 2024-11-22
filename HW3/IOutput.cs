namespace HW3;
/*
    У ньому мають бути два методи:
   ■ void Show() — відображає інформацію;
   ■ void Show(string info) — відображає інформацію та інформаційне повідомлення, зазначене у параметрі info.
 */
public interface IOutput
{
    void Show();
    void Show(string info);
}