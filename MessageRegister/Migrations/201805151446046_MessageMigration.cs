namespace MessageRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MesaggeTime = c.DateTime(nullable: false),
                        MessageUser = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
