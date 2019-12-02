namespace HomeWork2019._12._03.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteListTags_AddStringTag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Tag");
        }
    }
}
