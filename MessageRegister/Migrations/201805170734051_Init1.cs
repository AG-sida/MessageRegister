namespace MessageRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Messages", "MessageUser", c => c.String(maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Messages", "MessageUser", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
