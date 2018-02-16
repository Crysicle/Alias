namespace Alias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        WordId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.WordId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Words");
        }
    }
}
