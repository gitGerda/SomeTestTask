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
            Circle target = new Circle();
            //-------
            var _res = target.GetArea(R);
            //-------
            _res.Should().Be(result);
        }

        [Fact]
        public void CircleCtor_OnNegativeRadius_ThrowException()
        {
            //-------
            Circle target = new Circle();
            //------
            Assert.ThrowsAny<Exception>(() => target.GetArea(-1));
        }
    }
}
