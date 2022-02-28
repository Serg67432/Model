using System;
using Model;

namespace ConsoleLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            //тест равномерного движения
            LinearPointMove lPoint = new LinearPointMove();
            lPoint.X = 1;
            lPoint.Y = 1;
            lPoint.SpeedX = 1;
            lPoint.SpeedY = 2;

            Console.WriteLine("равномерное движение");

            Output(lPoint);

            //тест равноускоренного движения
            AcceleraatedPointMove aPoint = new AcceleraatedPointMove();
            aPoint.X = 1;
            aPoint.Y = 1;
            aPoint.AccelerateX = 1;
            aPoint.AccelerateY = 2;

            Console.WriteLine("равноускоренное движение");
            Output(aPoint);

            //тест колебательного движения
            OscillatoryPointMove oPoint = new OscillatoryPointMove();
            oPoint.X = 1;
            oPoint.Y = 1;
            oPoint.TargetX = 20;
            oPoint.TargetY = 40;

            Console.WriteLine("колебательное движение");
            Output(oPoint,40);

        }

        //метод вывода 10 позиций(по умолчанию) движения точки
        //метод должен быть статическим, чтобы его можно было вызвать из статического Main
        //передаю в него объект типа интерфейс, потому, что
        //для его работы достаточно только методов и свойств интерфейса
        static void Output(IPointMoveInterface point,int pointsCount = 10)
        {
            for (int i = 0; i < pointsCount; i++)
            {
                point.MovePoint();
                Console.WriteLine("x=" + point.X.ToString() + " y=" + point.Y);
            }
        }
    }
}
