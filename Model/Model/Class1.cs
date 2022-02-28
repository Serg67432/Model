using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public interface IPointMoveInterface
    {
        
        //Координаты как свойства
        int X
        {
            get;
            set;
        }
        int Y
        {
            get;
            set;
        }

        //Это тип. нужен для сериализации
        string PointType
        {
            get;
            
        }

        //передвинуть точку согласно законам движения
        void MovePoint();

       
    }

    [Serializable]//это нужно чтобы класс сериализовался
    //Класс линейного движения
    public class LinearPointMove :IPointMoveInterface
    {
        //Координаты реализованы как свойства
        //координаты старта могут быть любыми
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        public string PointType
        {
            get 
            {
                return this.GetType().ToString();
            }
        }

        //скорости как внутренние поля класса 
        private int speedX, speedY;

     

        //Скорость движения
        //скорость не должна превышать 1000 и быть меньше -1000
        //иначе на многоих экранах следующего шага просто будет невидно.
        public int SpeedX
        {
            set 
            {
                if (value > 1000 || value < -1000)
                    throw new ArgumentException("IncorrectArgumentException: speed can not be more 1000 and less -1000");
                else
                    speedX = value;
            }
            get { return speedX; }
        }
        public int SpeedY
        {
            set
            {
                if (value > 1000 || value < -1000)
                    throw new ArgumentException("IncorrectArgumentException: speed can not be more 1000 and less -1000");
                else
                    speedY = value;
            }
            get { return speedY; }
        }


        //передвинуть точку согласно законам движения
        public void MovePoint()
        {
            X = X + speedX;
            Y = Y + speedY;
        }
    }

    [Serializable]
    //Класс равноускоренного движения
    public class AcceleraatedPointMove : IPointMoveInterface
    {
        //Координаты реализованы как свойства
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }

        //ускорения как внутренние поля класса 
        private int accelerateX, accelerateY;

        //ускорения как свойства
        //у ускорений будут ограничения в 100 и -100
        public int AccelerateX
        {
            set
            {
                if (value > 100 || value < -100)
                    throw new ArgumentException("IncorrectArgumentException: Acceleration can not be more 100 and less -100");
                else
                    accelerateX = value;
            }
            get { return accelerateX; }
        }
        public int AccelerateY
        {
            set
            {
                if (value > 100 || value < -100)
                    throw new ArgumentException("IncorrectArgumentException: Acceleration can not be more 100 and less -100");
                else
                    accelerateY = value;
            }
            get { return accelerateY; }
        }
        //скорости по координатам
        private int SpeedX;
        private int SpeedY;
        public string PointType
        {
            get
            {
                return this.GetType().ToString();
            }
        }



        //передвинуть точку согласно законам движения
        public void MovePoint()
        {
            //Сначала применяю ускорение к скорости
            SpeedX = SpeedX + accelerateX;
            SpeedY = SpeedY + accelerateY;
            //а потом применяю скорость к координатам
            X = X + SpeedX;
            Y = Y + SpeedY;
        }
    }

    [Serializable]
    //Класс Колебательного движения 
    public class OscillatoryPointMove : IPointMoveInterface
    {
        //Координаты реализованы как свойства
        public int X
        {
            get;
            set;
        }
        public int Y
        {
            get;
            set;
        }


        //Точка - центр колебательного движения
        //вокруг этой точки будет колебаться исходная точка
       
        public int TargetX
        {
            get;
            set;
        }
        public int TargetY
        {
            get;
            set;
        }

        //Внутренний параметр. По умолчанию - 5
        int parametr = 5;

        //параметр для вычисления ускорения, чем ближе к целевой точке, тем меньше ускорение
        //параметр должен быть больше 1
        //чем больше параметр, тем плавнее нарастает/убывает скорость
        //работает как груз на резинке
        public int Parametr
        {
            set
            {
                if (value <= 1)
                    throw new ArgumentException("IncorrectArgumentException: parameter must be more 1");
                else
                    parametr = value;
            }
            private get
            {
                return parametr;
            }
           
        }

        //скорости по координатам
        private int SpeedX;
        private int SpeedY;

      
        //передвинуть точку согласно законам движения
        public void MovePoint()
        {
            //вычисляю ускорение по расстоянию до точки
            int AccelerateX = -(X - TargetX)/ parametr;
            int AccelerateY = -(Y - TargetY)/ parametr;

            //Сначала применяю ускорение к скорости
            SpeedX = SpeedX + AccelerateX;
            SpeedY = SpeedY + AccelerateY;
            //а потом применяю скорость к координатам
            X = X + SpeedX;
            Y = Y + SpeedY;
        }

        public string PointType
        {
            get
            {
                return this.GetType().ToString();
            }
        }

    }
}
