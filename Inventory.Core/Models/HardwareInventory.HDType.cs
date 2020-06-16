namespace Inventory.Core.Models
{
    public partial class HardwareInventory
    {
        //public HDType ChassisType { get; set; }
        public enum HDType {
            Laptop,
            Desktop,
            Server,
            Mobile,
            OtherVM

        }

    }
}
