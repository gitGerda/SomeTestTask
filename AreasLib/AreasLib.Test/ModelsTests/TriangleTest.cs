using AreasLib.Actions.IActions;
using AreasLib.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Test.ModelsTests
{
    public class TriangleTest
    {
        //================================================================================================
        // IsRectangular
        //================================================================================================
        [Theory]
        [InlineData(5, 5, null)]
        [InlineData(5, null, 5)]
        [InlineData(null, 5, 5)]
        public void IsRectangular_OnNullSides_ReturnNull(int? a, int? b, int? c)
        {
            var _consoleCommunic = new Mock<IConsoleCommunication>();
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны А")).Returns(a);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны B")).Returns(b);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны C")).Returns(c);

            var target = new Triangle(_consoleCommunic.Object);
            //---------------
            var result = target.IsRectangular();
            //---------------
            result.Should().Be(null);
        }
        [Theory]
        [InlineData(6, 8, 10)]
        [InlineData(8, 6, 10)]
        [InlineData(10, 8, 6)]
        public void IsRectangular_OnRectangleTriangleSides_ReturnTrue(double a, double b, double c)
        {
            var _consoleCommunic = new Mock<IConsoleCommunication>();
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны А")).Returns(a);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны B")).Returns(b);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны C")).Returns(c);

            var target = new Triangle(_consoleCommunic.Object);
            //---------------
            bool? result = target.IsRectangular();
            //---------------
            result.Should().Be(true);
        }
        [Theory]
        [InlineData(6, 8, 9)]
        public void IsRectangular_OnNotRectangleTriangleSides_ReturnFalse(double a, double b, double c)
        {
            var _consoleCommunic = new Mock<IConsoleCommunication>();
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны А")).Returns(a);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны B")).Returns(b);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны C")).Returns(c);

            var target = new Triangle(_consoleCommunic.Object);
            //---------------
            bool? result = target.IsRectangular();
            //---------------
            result.Should().Be(false);
        }

        //================================================================================================
        // GetArea
        //================================================================================================
        [Theory]
        [InlineData(5, 5, null)]
        [InlineData(5, null, 5)]
        [InlineData(null, 5, 5)]
        public void GetArea_OnNullSides_ReturnNull(int? a, int? b, int? c)
        {
            var _consoleCommunic = new Mock<IConsoleCommunication>();
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны А")).Returns(a);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны B")).Returns(b);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны C")).Returns(c);

            var target = new Triangle(_consoleCommunic.Object);
            //---------------
            var result = target.GetArea();
            //---------------
            result.Should().Be(null);
        }
        [Theory]
        [InlineData(5, 5, 6, 12)]
        [InlineData(5, 4, 3, 6)]
        public void GetArea_OnInvoke_ReturnValidArea(double a, double b, double c, double area)
        {
            var _consoleCommunic = new Mock<IConsoleCommunication>();
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны А")).Returns(a);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны B")).Returns(b);
            _consoleCommunic.Setup(t => t.GetSomeDoubleValueFromUser("Введите длину стороны C")).Returns(c);

            var target = new Triangle(_consoleCommunic.Object);
            //---------------
            var result = target.GetArea();
            //---------------
            result.Should().Be(area);
        }
    }
}
