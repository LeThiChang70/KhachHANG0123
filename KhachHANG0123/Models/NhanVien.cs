using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KhachHANG0123.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string NhanVienID { get; set; }
        public string HoTenNV { get; set; }
    }
}