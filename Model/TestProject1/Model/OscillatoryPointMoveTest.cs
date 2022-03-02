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
    class OscillatoryPointMoveTest
    {
        [Test]
        //Тестирую сразу четыре координаты
        [TestCase(int.MaxValue, TestName = "Тестирование x,y при присваивании int.MaxValue.")]
        [TestCase(int.MinValue, TestName = "Тестирование x,y при присваивании int.MinValue.")]
        [TestCase(4, TestName = "Тестирование x,y при присваивании 4.")]
        [TestCase(-4, TestName = "Тестирование x,y при присваивании -4.")]
        [TestCase(0, TestName = "Тестирование x,y при присваивании 0.")]
        public void CoordTest(int count)
        {
            var testClass = new OscillatoryPointMove();
            testClass.X = count;
            testClass.Y = count;
            testClass.TargetX = count;
            testClass.TargetY = count;
        }

        [Test]
        //Тестирую параметр
        [TestCase(2, TestName = "Тестирование параметра при присваивании 2.")]
        [TestCase(4, TestName = "Тестирование параметра при присваивании 4.")]
        [TestCase(int.MaxValue, TestName = "Тестирование параметра при присваивании int.MaxValue.")]

        public void AccellTest(int count)
        {
            var testClass = new OscillatoryPointMove();
            testClass.Parametr = count;
        }
        [Test]
        //ExpectedException в 3 версии nunit не работает
        //стековефлоу предлагает сделать для теста исключений отдельный тест
        //https://stackoverflow.com/questions/35061336/testing-for-exceptions-with-testcase-attribute-in-nunit-3
        [TestCase(1, TestName = "Тестирование ускорений при присваивании 1.")]
        [TestCase(0, TestName = "Тестирование ускорений при присваивании 0.")]
        [TestCase(-1, TestName = "Тестирование ускорений при присваивании -1.")]
        [TestCase(int.MinValue, TestName = "Тестирование ускорений при присваивании int.MinValue.")]
        public void AccellTestExceptions(int Accel)
        {
            var testClass = new OscillatoryPointMove();
            Assert.That(() => testClass.Parametr = Accel, Throws.TypeOf<ArgumentException>());
        }


        [Test]
        //Тестирую перемещение при разных скоростях и координатах
        [TestCase(0, 0, 0, 0, 2, TestName = "Тестирование MovePoiont() при нулевых данных")]
        [TestCase(-100, 100, 10, -10, 4, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(100, -100, 10, -10,7, TestName = "Тестирование MovePoiont() при разнонаправленных данных")]
        [TestCase(-10, -10, -10, -10,10, TestName = "Тестирование MovePoiont() при отлидцательных данных")]
        [TestCase(10, 10, 10, 10,20, TestName = "Тестирование MovePoiont() при положительных данных")]
        public void MovePoiontTest(int x, int y, int targetX, int targetY,int Param)
        {
            var testClass = new OscillatoryPointMove();
            testClass.X = x;
            testClass.Y = y;
            testClass.TargetX = targetX;
            testClass.TargetY = targetY;
            testClass.Parametr = Param;
            testClass.MovePoint();
        }
    }
}
