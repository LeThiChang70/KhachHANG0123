using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KhachHANG0123.Models
{
    [Table("DichVus")]
    public class DichVu
    {
        [Key]
        public string DichVuID { get; set; }
        public string LoaiDV { get; set; }
    }
}