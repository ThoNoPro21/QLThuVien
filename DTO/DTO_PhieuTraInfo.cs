using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTraInfo
    {
        public int MaPhieuMuon { get; set; }
        public int MaPhieuTra { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayPhaiTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public string MaSach { get; set; }
        public string NguoiTao { get; set; }
    }
}
