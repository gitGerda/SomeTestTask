using AreasLib.Actions.IActions;
using AreasLib.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace AreasLib.Test.ModelsTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(2, 4 * Math.PI)]
        [InlineData(3.5, 12.25 * Math.PI)]
        public void GetArea_OnInvoke_ReturnValidResult(double R, double result)
        {
            //-------
            var _consoleCommunicMock = new Mock<IConsoleCommunication>();
            _consoleCommunicMock.Setup(t => t.GetSomeDoubleValueFromUser("Введите радиус")).Returns(R);
            Circle target = new Circle(_consoleCommunicMock.Object);
            //-------
            var _res = target.GetArea();
            //-------
            _res.Should().Be(result);
        }
        [Fact]
        public void GetArea_OnNullRadius_ReturnNull()
        {
            //-------
            var _consoleCommunicMock = new Mock<IConsoleCommunication>();
            _consoleCommunicMock.Setup(t => t.GetSomeDoubleValueFromUser("Введите радиус")).Returns(() => null);
            Circle target = new Circle(_consoleCommunicMock.Object);
            //-------
            var _res = target.GetArea();
            //-------
            _res.Should().Be(null);
        }

    }
}
