﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        // AbstractProductA
        abstract class Car
        {
            public abstract void Info();
        }

        // ConcreteProductA1
        class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }
        class Mersedes : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mersedes");
            }
        }

        //ConcreteProductA2
        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }

        // AbstractProductB
        abstract class Engine
        {
            public virtual void GetPower()
            {
            }
        }

        // ConcreteProductB1
        class FordEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }

        //ConcreteProductB2
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }
        class MersedesEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mersedes Engine 3.9");
            }
        }

        abstract class Wheels
        {
            public virtual void GetDiametr()
            {
            }
        }

        // ConcreteProductB1
        class FordWheels : Wheels
        {
            public override void GetDiametr()
            {
                Console.WriteLine("Diametr 15");
            }
        }

        //ConcreteProductB2
        class ToyotaWheels : Wheels
        {
            public override void GetDiametr()
            {
                Console.WriteLine("Diametr 19");
            }
        }
        class MersedesWheels : Wheels
        {
            public override void GetDiametr()
            {
                Console.WriteLine("Diametr 17");
            }
        }

        // AbstractFactory
        interface ICarFactory
        {
            Car CreateCar();
            Engine CreateEngine();
            Wheels CreateWheels();
        }

        // ConcreteFactory1
        class FordFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Ford();
            }

            Engine ICarFactory.CreateEngine()
            {
                return new FordEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new FordWheels();
            }
        }

        // ConcreteFactory2
        class ToyotaFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Toyota();
            }

            Engine ICarFactory.CreateEngine()
            {
                return new ToyotaEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new ToyotaWheels();
            }
        }
        class MersedesFactory : ICarFactory
        {
            // from CarFactory
            Car ICarFactory.CreateCar()
            {
                return new Mersedes();
            }

            Engine ICarFactory.CreateEngine()
            {
                return new MersedesEngine();
            }
            Wheels ICarFactory.CreateWheels()
            {
                return new MersedesWheels();
            }
        }

        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();

            Car myCar = carFactory.CreateCar();
            myCar.Info();
            Engine myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            Wheels myWheels = carFactory.CreateWheels();
            myWheels.GetDiametr();

            carFactory = new FordFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            myWheels = carFactory.CreateWheels();
            myWheels.GetDiametr();

            carFactory = new MersedesFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            myWheels = carFactory.CreateWheels();
            myWheels.GetDiametr();

            Console.ReadKey();
        }

    }
}