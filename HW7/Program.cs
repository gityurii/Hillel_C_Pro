namespace HW7;

class Program
{
    static void Main(string[] args)
    {
        const int waitSeatNumber = 3;
        Barbershop barbershop = new Barbershop(waitSeatNumber);
        Thread barberThread = new Thread(barbershop.BarberWork);
        barberThread.Start();

        Random random = new Random();

        for (int i = 1; i <= 10; i++) // 10 visitors
        {
            int visitorId = i;
            Thread.Sleep(random.Next(1500, 2500)); // Visitors arrive at intervals
            new Thread(() => barbershop.NewVisitor(visitorId)).Start();
        }

        barberThread.Join();
    }
}

