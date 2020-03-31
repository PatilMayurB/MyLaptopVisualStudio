using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OperationsLibrary.Tests
{
    public class DataBaseClassTest
    {
        [Theory]
        [InlineData("Vihan", "Vihan", 0)]
        [InlineData("Ganesh", "Patil", 0)]
        public void saveName_DataBaseTest(string firstname, string lastname, int expected)
        {
            int actual = DatabaseClass.saveName(firstname, lastname);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Mayur", "Mayur", 1)]
        [InlineData("Varad", "Varad", 1)]
        public void retrieveName_AvailabilityTest(string firstname, string lastname, int expected)
        {
            int actual = DatabaseClass.retrieveName(firstname, lastname);
            Assert.Equal(expected, actual);
        }
    }
}
