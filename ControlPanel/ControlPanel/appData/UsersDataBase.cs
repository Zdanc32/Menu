using ControlPanel.appData.Table;
using System.Data.Entity;

namespace ControlPanel.appData
{
    public class UsersDataBase : DbContext
    {
        public UsersDataBase() : base("CarRental") { }
        public DbSet<User> User{ get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarUser> CarUser { get; set; }
    }
}
