using System.Collections.Generic;

namespace ControlPanel.appData.Table
{
    public class CarUser
    {
        public int CarUserId { get; set; }
        public User User { get; set; }
        public List<Car> Car { get; set; }
    }
}
