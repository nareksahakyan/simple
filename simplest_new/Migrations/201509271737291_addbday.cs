namespace simplest_new.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "birthday");
        }
    }
}
