using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001_FirstTest
{
    [TestClass]
    public class OurFirstUnitTest
    {
        [TestMethod]
        public void AgeIs31()
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
            Assert.AreEqual(31, actualAge);
        }


        [TestMethod]
        public void HairIsNotBrown()
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
            var actualHairColour = person.GetHairColour();

            //Assert
            Assert.AreNotEqual("Brown", actualHairColour);
        }

        [TestMethod]
        public void IsCalledSean()
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
            Assert.AreEqual("Sean", actualName);
        }

        [TestMethod]
        public void IsCalledSeanCaseInsensitive()
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

            //Assert - adding a bool insensitive override, this is denoted by adding True to the Are Equal Assertion
            Assert.AreEqual("sean", actualName, true);
        }
    }
}