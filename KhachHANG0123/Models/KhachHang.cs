using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KhachHANG0123.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string HoTenKH { get; set; }
    }
}