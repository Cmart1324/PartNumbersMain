
namespace PartDataLayer.DTO
{
    public class DtoPart
    {
        public DtoPart(string partNumber, 
                           double partPrice, 
                           string partDesciption)
        {
            PartNumber = partNumber;
            PartPrice= partPrice;
            PartDesciption=partDesciption;
        }
        public string PartNumber { get; set; }

        public double PartPrice { get; set; }

        public string PartDesciption { get; set; }
    }
}
