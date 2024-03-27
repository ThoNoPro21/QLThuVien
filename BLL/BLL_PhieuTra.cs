using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhieuTra
    {
        QLThuVienDataContext DB = new QLThuVienDataContext();
       
        // Lấy tất cả thông tin phiếu trả
        public List<DTO_PhieuTraInfo> LayTatCa(string MaPHIEUTRA)
        {
            var query = from a in DB.PHIEUTRAs
                        join b in DB.PHIEUMUONs on a.MaPhieuMuon equals b.MaPhieuMuon
                             join c in DB.SACHes on b.MaSach equals c.MaSach
                                join d in DB.DOCGIAs on a.NguoiTao equals d.MaDocGia
                        select new DTO_PhieuTraInfo
                                        {
                                            MaPhieuMuon = a.MaPhieuMuon,
                                            MaPhieuTra = a.MaPhieuTra,
                                            NgayMuon = b.NgayMuon,
                                            NgayPhaiTra = b.NgayPhaiTra,
                                            NgayTra = a.NgayTra,
                                            MaSach = c.TenSach,
                                            NguoiTao = d.HoTen
                                };


            return query.ToList();
        }
        // Thêm phiếu trả
        public bool InsertPHIEUTRA(int MaPhieuMuon, DateTime NgayTra, int NguoiTao)
        {
            PHIEUTRA PHIEUTRA = new PHIEUTRA();
            PHIEUTRA.MaPhieuMuon = MaPhieuMuon;
            PHIEUTRA.NgayTra = NgayTra;
            PHIEUTRA.NguoiTao = NguoiTao;
            try
            {
                DB.PHIEUTRAs.InsertOnSubmit(PHIEUTRA);
                DB.SubmitChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // Sửa phiếu trả
        public bool UpdatePHIEUTRA(int MaPhieuTra, DateTime NgayTra,int NguoiTao)
        {
            PHIEUTRA PHIEUTRA = DB.PHIEUTRAs.Where(dg => dg.MaPhieuTra == MaPhieuTra).FirstOrDefault();
            if (PHIEUTRA != null)
            {
                PHIEUTRA.NgayTra = NgayTra;
                PHIEUTRA.NguoiTao = NguoiTao;
                DB.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // Xóa phiếu trả
        public bool DeletePHIEUTRA(int MaPHIEUTRA)
        {
            PHIEUTRA PHIEUTRA = DB.PHIEUTRAs.Where(ma => ma.MaPhieuTra == MaPHIEUTRA).FirstOrDefault();
            try
            {
                if (PHIEUTRA != null)
                {
                    DB.PHIEUTRAs.DeleteOnSubmit(PHIEUTRA);
                    DB.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lấy ngày mượn của phiếu mượn
        public List<DTO_PhieuMuonInfo> GetNgayMuon(int MaPhieuMuon)
        {
            var query = from a in DB.PHIEUMUONs.Where(x=>x.MaPhieuMuon == MaPhieuMuon)
                        select new DTO_PhieuMuonInfo
                        {
                            NgayMuon = a.NgayMuon,
                        };
            return query.ToList();
        }
        // Lấy thông tin phiếu mượn
        public List<DTO_PhieuMuonInfo> LayThongTinPhieuMuon()
        {
            var query = from phieuMuon in DB.PHIEUMUONs
                        where !(from o in DB.PHIEUTRAs
                                select o.MaPhieuMuon)
                        .Contains(phieuMuon.MaPhieuMuon)
                        
                        select new DTO_PhieuMuonInfo
                        {
                            MaPhieuMuon = phieuMuon.MaPhieuMuon,
                        };

            return query.ToList();
        }
    }
}
