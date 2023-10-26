namespace Domain.Entities;

public class Diet : BaseEntity
{
    public string DietName { get; set; } = default!;
    public string FoodName { get; set; } = default!;
    public double Quantity { get; set; }
    public string Unit { get; set; } = default!;
    public int TimesPerDay { get; set; }

    public ICollection<DietDetail> DietDetails { get; set; } = new List<DietDetail>();
}
