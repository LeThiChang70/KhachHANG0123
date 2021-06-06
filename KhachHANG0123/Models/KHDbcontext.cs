using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KhachHANG0123.Models
{
    public partial class KHDbcontext : DbContext
    {
        public KHDbcontext()
            : base("name=KHDbcontext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
