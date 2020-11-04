namespace GuildCars.Models.Tables
{
    public class Cars
    {


        public int CarId { get; set; }
        public int ModelId { get; set; }
        public string Model { get; set; }
        public int MakeId { get; set; }
        public string Make { get; set; }
        public string CarYr { get; set; }
        public int CarType { get; set; }
        public string BodyStyle { get; set; }
        public decimal MSRP { get; set; }
        public decimal SalePrice { get; set; }
        public string VIN  { get; set; }
        public string ExtColor { get; set; }
        public string IntColor { get; set; }
        public int CarTrans { get; set; }
        public string Trans { get; set; }
        public int CarMileage { get; set; }
        public string CarDescription { get; set; }
        public string CarImageName { get; set; }
        public string CarPhoto { get; set; }
        public string PhotoPath { get; set; }
        public bool CarSold {get; set; }
        public int FeaturedVehicle { get; set; }
        public string postedFile { get; set; }
        public int Count { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsSpecial { get; set; }
        public bool IsSold { get; set; }
    }
}