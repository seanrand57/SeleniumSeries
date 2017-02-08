namespace SeleniumSeries.Code
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int HeightInCm { get; set; }
        public string HairColour { get; set; }
        public int GetAge() => Age;
        public string GetName() => Name;
        public string GetHairColour() => HairColour;
        public int GetHeightInCm() => HeightInCm;
    }
}