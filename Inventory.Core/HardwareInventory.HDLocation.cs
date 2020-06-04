using System.ComponentModel.DataAnnotations;

namespace Inventory.Core
{
    public partial class HardwareInventory
    {
        public enum HDLocation
        {
            [Display(Name = "Portable VM")]
            Portable_VM,
            [Display(Name = "Portable Computer")]
            Portable_Computer,
            [Display(Name = "Home Server")]
            Home_Server

        }

    }
}
