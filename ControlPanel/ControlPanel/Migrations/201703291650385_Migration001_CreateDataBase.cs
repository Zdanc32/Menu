namespace ControlPanel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration001_CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        login = c.String(),
                        email = c.String(),
                        name = c.String(),
                        surname = c.String(),
                        phoneNumber = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
