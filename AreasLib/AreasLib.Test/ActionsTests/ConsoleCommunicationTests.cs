using AreasLib.Actions;
using AreasLib.Helpers;
using AreasLib.Helpers.IHelpers;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasLib.Test.ActionsTests
{
    public class ConsoleCommunicationTests
    {
        [Fact]
        public void GetSomeDoubleValueFromUser_OnQSymbFromUser_ReturnNull()
        {
            //-------------
            var _helpers = new Mock<IActionsHelpers>();
            _helpers.Setup(t => t.ConsoleReadLineWrapper()).Returns("Q");

            var target = new ConsoleCommunication(_helpers.Object);
            //----------
            var result = target.GetSomeDoubleValueFromUser("some test message");
            //----------
            result.Should().Be(null);
        }
    }
}
