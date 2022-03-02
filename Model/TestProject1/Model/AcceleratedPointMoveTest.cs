using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Model
{
    [TestFixture]
    class AcceleratedPointMoveTest
    {
        [Test]
        //Тестирую сразу обе координаты
        [TestCase(int.MaxValue, TestName = "Тестирование x,y при присваивании int.MaxValue.")]
        [TestCase(int.MinValue, TestName = "Тестирование x,y при присваивании int.MinValue.")]
        [TestCase(4, TestName = "Тестирование x,y при присваивании 4.")]
        [TestCase(-4, TestName = "Тестирование x,y при присваивании -4.")]
        [TestCase(0, TestName = "Тестирование x,y при присваивании 0.")]
        public void CoordTest(int count)
        {
            var testClass = new AcceleraatedPointMove();
            testClass.X = count;
            testClass.Y = count;
        }

        [Test]
        //Тестирую сразу обе скорости
        [TestCase(4, TestName = "Тестирование ускорений при присваивании 4.")]
        [TestCase(-4, TestName = "Тестирование ускорений при присваивании -4.")]
        [TestCase(0, TestName = "Тестирование ускорений при присваивании 0.")]

        public void AccellTest(int count)
        {
            var testClass = new AcceleraatedPointMove();
            testClass.AccelerateX = count;
            testClass.AccelerateY = count;
        }
        [Test]
        //ExpectedException в 3 версии nunit не работает
        //стековефлоу предлагает сделать для теста исключений отдельный тест
        //https://stackoverflow.com/questions/35061336/testing-for-exceptions-with-testcase-attribute-in-nunit-3
        [TestCase(int.MaxValue, TestName = "Тестирование ускорений при присваивании int.MaxValue.")]
        [TestCase(int.MinValue, TestName = "Тестирование ускорений при присваивании int.MinValue.")]
        public void AccellTestExceptions(int Accel)
        {
            var testClass = new AcceleraatedPointMove();
            Assert.That(() => testClass.AccelerateX = Accel, Throws.TypeOf<ArgumentException>());
            Assert.That(() => testClass.AccelerateY = Accel, Throws.TypeOf<ArgumentException>());
        }


        [Test]
        //Тестирую перемещение при разных скоростях и координатах
        [TestCase(0, 0, 0, 0, TestName = "Тестирование MovePoiont() при нулевых данных")]
        [TestCase(-100, 100, 10, -10, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(100, -100, 10, -10, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(-10, -10, -10, -10, TestName = "Тестирование MovePoiont() при отлидцательных данных")]
        [TestCase(10, 10, 10, 10, TestName = "Тестирование MovePoiont() при положительных данных")]
        public void MovePoiontTest(int x, int y, int accelX, int accelY)
        {
            var testClass = new AcceleraatedPointMove();
            testClass.X = x;
            testClass.Y = y;
            testClass.AccelerateX = accelX;
            testClass.AccelerateY = accelY;
            testClass.MovePoint();
        }
    }
}
