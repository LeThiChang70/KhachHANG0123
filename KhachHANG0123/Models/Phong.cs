using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KhachHANG0123.Models
{
    [Table("Phongs")]
    public class Phong
    {
        [Key]
        public string IDPhong { get; set; }
        public string LoaiPhong { get; set; }
    }
}