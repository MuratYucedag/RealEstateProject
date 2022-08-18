namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_estate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estates",
                c => new
                    {
                        EstateID = c.Int(nullable: false, identity: true),
                        EstateSquareMeter = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstateCity = c.String(),
                        EstateTown = c.String(),
                        EstateType = c.String(),
                        EstatePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EstateID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estates");
        }
    }
}
