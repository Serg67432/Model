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
    class LinearPointMoveTest
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
            var testClass = new LinearPointMove();
            testClass.X = count;
            testClass.Y = count;
        }

        [Test]
        //Тестирую сразу обе скорости
        [TestCase(4, TestName = "Тестирование скоростей при присваивании 4.")]
        [TestCase(0, TestName = "Тестирование скоростей при присваивании 0.")]
        [TestCase(-4, TestName = "Тестирование скоростей при присваивании -4.")]
        public void SpeedTest(int count)
        {
            var testClass = new LinearPointMove();
            testClass.SpeedX = count;
            testClass.SpeedY = count;
        }
        [Test]
        //ExpectedException в 3 версии nunit не работает
        //стековефлоу предлагает сделать для теста исключений отдельный тест
        //https://stackoverflow.com/questions/35061336/testing-for-exceptions-with-testcase-attribute-in-nunit-3
        [TestCase(int.MaxValue, TestName = "Тестирование скоростей при присваивании int.MaxValue.")]
        [TestCase(int.MinValue, TestName = "Тестирование скоростей при присваивании int.MinValue.")]
        public void SpeedTestExceptions(int Speed)
        {
            var testClass = new LinearPointMove();
            Assert.That(() => testClass.SpeedX = Speed, Throws.TypeOf<ArgumentException>());
            Assert.That(() => testClass.SpeedY = Speed, Throws.TypeOf<ArgumentException>());
        }


        [Test]
        //Тестирую перемещение при разных скоростях и координатах
        [TestCase(0, 0, 0, 0, TestName = "Тестирование MovePoiont() при нулевых данных")]
        [TestCase(-100, 100, 10, -10, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(100, -100, 10, -10, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(-10, -10, -10, -10, TestName = "Тестирование MovePoiont() при отлидцательных данных")]
        [TestCase(10, 10, 10, 10, TestName = "Тестирование MovePoiont() при положительных данных")]
        public void MovePoiontTest(int x,int y, int speedX,int speedY)
        {
            var testClass = new LinearPointMove();
            testClass.X = x;
            testClass.Y = y;
            testClass.SpeedX = speedX;
            testClass.SpeedY = speedY;
            testClass.MovePoint();
        }

    }
}
