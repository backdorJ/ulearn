

namespace Task2
{
    class Car
    {
        private int speed = 0;

        public void PrintSpeed()
        {
            if (speed == 0)
                Console.WriteLine("Стоим на месте...");
            if  (speed > 0)
                Console.WriteLine($"Едем со скоростью {speed} км/ч");
            else if (speed < 0)
                Console.WriteLine($"Едем назад со скростью {speed}");
        }

        public void GoingStraight() => speed = 60;
        public void GoingBack() => speed = -5;
        public void StandStill() => speed = 0;
    }
    class Lesson
    {
        static void Main()
        {
            var car = new Car();
            Console.WriteLine("--- First car ---");
            car.PrintSpeed();
            car.GoingStraight();
            car.PrintSpeed();
            car.GoingBack();
            car.PrintSpeed();
        }
    }
}