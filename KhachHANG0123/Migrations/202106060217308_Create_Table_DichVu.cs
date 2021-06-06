namespace KhachHANG0123.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DichVu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        DichVuID = c.String(nullable: false, maxLength: 128),
                        LoaiDV = c.String(),
                    })
                .PrimaryKey(t => t.DichVuID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DichVus");
        }
    }
}
