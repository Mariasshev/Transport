using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    //Реализовать иерархию транспортных средств как на фото. Обьязательно использовать паттерны switch и matching.
    ///Предусмотреть необходимые интерфейсы и уровень абстракции. Работа с объекстами через ссылку на абстрактный класс(или интерфейс). 
    /// Предусмотреть необходимые интерфейсы и уровень абстракции. Работа с объекстами через ссылку на абстрактный класс(или интерфейс). 


    //По выбору пользователя создать объект конкретного класса и показать методы!


    public interface ITransport
    {
        string Name { get; }
        void Move();
        string FuelType();
        double maxSpeed();


    }

    public class GroundTransport : ITransport
    {
        public string Name => "Ground transport";
        private int peopleAmount;
        private int drivers;

        public GroundTransport()
        {
            peopleAmount = 0;
            drivers = 0;
        }

        public GroundTransport(int peopleAmount, int drivers)
        {
            this.peopleAmount = peopleAmount;
            this.drivers = drivers;
        }

        public void Move()
        {
            Console.WriteLine("Ground transport ride on road");
        }

        public string FuelType()
        {

            return "Diesel";
        }

        public double maxSpeed()
        {
            return 135.0;
        }
    }

    public class WaterTransport : ITransport
    {
        public string Name => "Water transport";
        private int peopleAmount;

        public WaterTransport()
        {
            peopleAmount = 0;
        }

        public WaterTransport(int peopleAmount)
        {
            this.peopleAmount = peopleAmount;
        }

        public void Move()
        {
            Console.WriteLine("Water transport moves on water");
        }

        public string FuelType()
        {

            return "Electrical";
        }

        public double maxSpeed()
        {
            return 55.0;
        }
    }

    public class AirTransport: ITransport
    {
        public string Name => "Air transport";
        private int peopleAmount;

        public AirTransport()
        {
            peopleAmount = 0;
        }

        public AirTransport(int peopleAmount)
        {
            this.peopleAmount = peopleAmount;
        }

        public void Move()
        {
            Console.WriteLine("Water transport moves on air");
        }

        public string FuelType()
        {

            return "Kerosene";
        }

        public double maxSpeed()
        {
            return 700.0;
        }
    }




}
