namespace KhachHANG0123.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Phong : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phongs",
                c => new
                    {
                        IDPhong = c.String(nullable: false, maxLength: 128),
                        LoaiPhong = c.String(),
                    })
                .PrimaryKey(t => t.IDPhong);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Phongs");
        }
    }
}
