using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace logicTest
{
     [TestFixture]
     public class logicTests
     {
          [Test]
          public void HelloTest()
          {
               Assert.Pass();
          }

          [Test]
          public void testFormat()
          {
               // Arrange test parameters
               var input = "hello";
               var expected = "hello";

               // Action to be performed

               var actual = expected;

               // Assert, test
               Assert.AreEqual(expected, actual);
          }

          [Test]
          [TestCase("hello", "hello")]
          [TestCase("BOOM", "BOOM")]
          [TestCase("hello123", "hello123")]
          public void SuccessfulScenariosTest(string input, string expectedOutput)
          {
               // Act
               var actualOutput = input;

               // Assert
               Assert.AreEqual(expectedOutput, actualOutput, "Invalid value returned");
          }
     }
}
