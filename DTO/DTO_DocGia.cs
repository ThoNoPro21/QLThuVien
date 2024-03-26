using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class DTO_DocGia
    {
        public static int MaDocGia {  get; set; }
    }
    public class DTO_DocGiaList
    {
        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Quyen { get; set; }
        public string MatKhau { get; set; }

    }
}
