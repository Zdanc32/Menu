using ControlPanel.appData.Enums;

namespace ControlPanel.appData.Table
{
    public class Car
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Quantity { get; set; }
        public string IsAvailable { get; set; }
        public CarType Type { get; set; }
        public Brand Brand { get; set; }
    }
}