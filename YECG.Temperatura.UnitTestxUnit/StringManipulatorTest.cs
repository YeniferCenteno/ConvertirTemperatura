using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YECG.Temperatura.UnitTestxUnit
{
        public class StringManipulatorTest
        { 
            private StringManipulator _manipulator;

            public StringManipulatorTest()
            {
                _manipulator = new StringManipulator();
            }

            [Fact]
            public void ReverseString_ShouldReturnReversedString()
            { 
                string input = "hello";
                string expected = "olleh";

                string result = _manipulator.ReverseString(input);

                Assert.Equal(expected, result);
            }

            [Fact]
            public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
            {
                string input = "hello world";
                string expected = "helloworld";

                string result = _manipulator.RemoveSpaces(input);

                Assert.Equal(expected, result);
            }
        }
}
