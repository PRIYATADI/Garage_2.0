namespace Garage_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class priya3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(maxLength: 10));
        }
    }
}
