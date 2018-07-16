namespace _001_FirstTest
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int HeightInCm { get; set; }
        public string HairColour { get; set; }

        public int GetAge()
        {
            return Age;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHairColour()
        {
            return HairColour;
        }

        public int GetHeightInCm()
        {
            return HeightInCm;
        }
    }
}