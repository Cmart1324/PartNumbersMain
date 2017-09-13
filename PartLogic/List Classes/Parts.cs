using System.ComponentModel;

namespace PartLogic.List_Classes
{
    public class Parts
    {
        public Parts(string partNumber, 
                     double partPrice,
                     string partDescription)
        {
            PartNumber = partNumber;
            PartPrice= partPrice;
            PartDesciption = partDescription;
        }

        [DisplayName("Part number")]
        public string PartNumber { get; set; }

        [DisplayName("Part price")]
        public double PartPrice { get; set; }

        [DisplayName("Part description")]
        public string PartDesciption { get; set; }

        public Parts ShallowCopy()
        {
            return (Parts)MemberwiseClone();
        }
    }
    
}
