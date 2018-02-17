namespace Alias.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Words", "WordType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Words", "WordType");
        }
    }
}
