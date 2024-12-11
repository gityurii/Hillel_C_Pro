namespace HW4;

public class Worker
{
    public decimal Salary { get; set; }
    public string Currency { get; set; }
    public string Position { get; set; }

    public Worker(decimal salary, string currency, string position)
    {
        Salary = salary;
        Currency = currency;
        Position = position;
    }

    public static Worker operator +(Worker worker, decimal amount)
    {
        worker.Salary += amount;
        return worker;
    }
    
    public static Worker operator -(Worker worker, decimal amount)
    {
        worker.Salary -= amount;
        return worker;
    }
    public static bool operator ==(Worker worker1, Worker worker2)
    {
        if (worker1 is null || worker2 is null)
        {
            return false;
        }
        return worker1.Salary == worker2.Salary;
    }

    public static bool operator !=(Worker worker1, Worker worker2)
    {
        return !(worker1 == worker2);
    }

    public static bool operator <(Worker worker1, Worker worker2)
    {
        if (worker1 is null || worker2 is null)
        {
            throw new ArgumentNullException("Workers cannot be null");
        }
        return worker1.Salary < worker2.Salary;
    }

    public static bool operator >(Worker worker1, Worker worker2)
    {
        if (worker1 is null || worker2 is null)
        {
            throw new ArgumentNullException("Workers cannot be null");
        }
        return worker1.Salary > worker2.Salary;
    }

    public override bool Equals(object obj)
    {
        if (obj is Worker otherWorker)
        {
            return Salary == otherWorker.Salary &&
                   Currency == otherWorker.Currency &&
                   Position == otherWorker.Position;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Salary.GetHashCode();
    }
}