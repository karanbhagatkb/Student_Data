namespace Student_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiload_studdent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        ClassName = c.String(),
                        RollNo = c.Int(nullable: false),
                        Precentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
