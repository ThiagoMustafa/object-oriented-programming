
namespace OOP
{
    //A class is da data structure that aims to represent something that exists in the real world
    public class House
    {
        public int SquareFeet { get; set; }
        public int Floors { get; set; }
        public decimal Amount  { get; set; }
        public int CarSpots { get; set; }
    }

    // An object is an instance of a class
    public class Object
    {
        public Object()
        {
            var house = new House
            {
                SquareFeet = 100,
                Floors = 2,
                Amount = 100000,
                CarSpots = 3
            };
        }
    }
}
