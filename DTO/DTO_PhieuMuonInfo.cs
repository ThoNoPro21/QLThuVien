using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuMuonInfo
    {
        public int MaPhieuMuon { get; set; }
        public string HoTenDocGia { get; set; }
        public string TenSach {  get; set; }
        public DateTime NgayMuon { get;set; }
        public DateTime? NgayPhaiTra { get;set; }
        public string NguoiTao { get; set; }
        public int Status { get; set; }
    }
}
