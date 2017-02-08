using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSeries.Code;
using Shouldly;

namespace SeleniumSeries.Tests._002_Our_First_Shouldy_Test
{
    [TestClass]
    public class OurFirstShouldyTest
    {
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