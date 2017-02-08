using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSeries.Code;
using Shouldly;

namespace SeleniumSeries.Tests._003_MsTestAttributes
{
    [TestClass]
    public class UsingTestAttributes
    {
        [TestCategory("HIGH")]
        [TestCategory("PERSON-TESTS")]
        [TestMethod]
        public void Shouldy_IsCalledSean()
        {
            //Arrange
            var person = new Person
            {
                HairColour = "Blonde",
                Age = 31,
                HeightInCm = 183,
                Name = "Sean"
            };

            //Act
            var actualName = person.GetName();

            //Assert
            actualName.ShouldBe("Sean");
        }


        [TestCategory("MEDIUM")]
        [TestCategory("PERSON-TESTS")]
        [TestMethod]
        public void Shouldy_IsCalledSean_CaseInsensitive()
        {
            //Arrange
            var person = new Person
            {
                HairColour = "Blonde",
                Age = 31,
                HeightInCm = 183,
                Name = "Sean"
            };

            //Act
            var actualName = person.GetName();

            //Assert
            actualName.ShouldBe("sean", StringCompareShould.IgnoreCase);
        }

        [TestCategory("LOW")]
        [TestCategory("PERSON-TESTS")]
        [TestMethod]
        public void Shouldly_AgeIsGreaterThan30()
        {
            //Arrange
            var person = new Person
            {
                HairColour = "Blonde",
                Age = 31,
                HeightInCm = 183,
                Name = "Sean"
            };

            //Act
            var actualAge = person.GetAge();

            //Assert
            actualAge.ShouldBeGreaterThan(30);
        }
    }
}