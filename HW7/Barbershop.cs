namespace HW7;

public class Barbershop
    {
        private readonly int _waitingRoomSeats;
        private readonly Queue<int> _waitingRoom;
        private readonly object _lockObject = new();
        private bool _barberSleeping = true;

        public Barbershop(int waitingRoomSeats)
        {
            _waitingRoomSeats = waitingRoomSeats;
            _waitingRoom = new Queue<int>();
        }

        public void BarberWork()
        {
            while (true)
            {
                int currentVisitor;

                lock (_lockObject)
                {
                    // Barber waits until there are visitors in the queue
                    while (_waitingRoom.Count == 0)
                    {
                        Console.WriteLine("The barber is sleeping...");
                        _barberSleeping = true;
                        Monitor.Wait(_lockObject); // Barber waits to be woken up
                    }

                    currentVisitor = _waitingRoom.Dequeue();
                }

                // Barber starts cutting the visitor's hair
                Console.WriteLine($"The barber is cutting the hair of visitor {currentVisitor}...");
                Thread.Sleep(2000); // Simulate haircut
                Console.WriteLine($"Visitor {currentVisitor} has finished their haircut.");

                lock (_lockObject)
                {
                    // Check if there are more visitors in the queue
                    if (_waitingRoom.Count == 0)
                    {
                        Console.WriteLine("The barber checked: no clients, going to sleep.");
                        _barberSleeping = true;
                    }
                    else
                    {
                        Console.WriteLine("The barber checked: there are clients, continuing work.");
                    }
                }
            }
        }

        public void NewVisitor(int visitorId)
        {
            lock (_lockObject)
            {
                // Check if there is space in the waiting room
                if (_waitingRoom.Count < _waitingRoomSeats)
                {
                    _waitingRoom.Enqueue(visitorId);
                    Console.WriteLine($"Visitor {visitorId} took a seat in the waiting room.");

                    // Wake up the barber if they are sleeping
                    if (_barberSleeping)
                    {
                        _barberSleeping = false;
                        Monitor.Pulse(_lockObject); // Notify the barber
                        Console.WriteLine($"Visitor {visitorId} wakes up barber.");
                    }
                }
                else
                {
                    // Visitor leaves if there are no seats available
                    Console.WriteLine($"Visitor {visitorId} left: no seats available in the waiting room.");
                }
            }
        }
    }