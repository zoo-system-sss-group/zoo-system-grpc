namespace Grpc.DTOs
{
    public class DietDto
    {
        public string DietName { get; set; } = default!;
        public string FoodName { get; set; } = default!;
        public double Quantity { get; set; }
        public string Unit { get; set; } = default!;
        public int TimesPerDay { get; set; }
    }
}
