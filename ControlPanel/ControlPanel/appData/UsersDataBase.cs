using ControlPanel.appData.Table;
using System.Data.Entity;

namespace ControlPanel.appData
{
    public class UsersDataBase : DbContext
    {
        public UsersDataBase() : base("UsersDataBase") { }
        public DbSet<User> User{ get; set; }
    }
}
