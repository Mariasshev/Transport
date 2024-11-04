using System;

namespace ConsoleApp15
{
    class Program
    {
        public static void DescribeTransport(ITransport transport)
        {
            string description = transport switch
            {
                GroundTransport => $"Тип: Наземный транспорт\n" +
                                   $"{transport.Move()}\n" +
                                   $"Тип топлива: {transport.FuelType()}\n" +
                                   $"Максимальная скорость: {transport.maxSpeed()} км/ч" +
                                   $"\n--------------------------\n",

                WaterTransport => $"Тип: Водный транспорт\n" +
                                  $"{transport.Move()}\n" +
                                  $"Тип топлива: {transport.FuelType()}\n" +
                                  $"Максимальная скорость: {transport.maxSpeed()} м/ч" +
                                  $"\n--------------------------\n",

                AirTransport => $"Тип: Воздушный транспорт\n" +
                                $"{transport.Move()}\n" +
                                $"Тип топлива: {transport.FuelType()}\n" +
                                $"Максимальная скорость: {transport.maxSpeed()} км/ч" +
                                $"\n--------------------------\n",

                _ => "Неизвестный тип транспорта."
            };

            Console.WriteLine(description);
        }

        static void Main(string[] args)
        {
            ITransport car = new GroundTransport();
            ITransport boat = new WaterTransport();
            ITransport airplane = new AirTransport();

            DescribeTransport(car);
            DescribeTransport(boat);
            DescribeTransport(airplane);
        }
    }
}
