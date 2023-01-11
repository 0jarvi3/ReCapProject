namespace Entities.DTOs;

public class CarDetailsDto
{
    public int CarId { get; set; }
    public string CarName { get; set; }
    public string CarDescription { get; set; }
    public string ColorName { get; set; }
    public string BrandName { get; set; }
    public decimal DailyPrice { get; set; }
    public short ModelYear { get; set; }

}