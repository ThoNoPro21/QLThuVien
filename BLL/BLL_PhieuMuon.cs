using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhieuMuon
    {
       QLThuVienDataContext DB=new QLThuVienDataContext();
        // Lấy tất cả thông tin phiếu mượn
        public List<DTO_PhieuMuonInfo> LayTatCa()
        {
            var query = from phieuMuon in DB.PHIEUMUONs
                        join docGia in DB.DOCGIAs on phieuMuon.MaDocGia equals docGia.MaDocGia
                        join sach in DB.SACHes on phieuMuon.MaSach equals sach.MaSach
                        join nhanVien in DB.DOCGIAs on phieuMuon.NguoiTao equals nhanVien.MaDocGia
                        join phieuTra in DB.PHIEUTRAs on phieuMuon.MaPhieuMuon equals phieuTra.MaPhieuMuon into phieuTraGroup
                        from phieuTraItem in phieuTraGroup.DefaultIfEmpty()
                        select new DTO_PhieuMuonInfo
                        {
                            MaPhieuMuon = phieuMuon.MaPhieuMuon,
                            HoTenDocGia = docGia.HoTen,
                            TenSach = sach.TenSach,
                            NgayMuon = phieuMuon.NgayMuon,
                            NgayPhaiTra = phieuMuon.NgayPhaiTra,
                            NguoiTao = nhanVien.HoTen,
                            Status = phieuTraItem != null ? 1 : 0
                        };

            return query.ToList();
        }
        // Kiểm tra mã phiếu đã tồn tại hay chưa
        public bool IsCheckMaPhieuMuon(int maphieumuon)
        {
            bool exists = DB.PHIEUMUONs.Any(ma => ma.MaPhieuMuon == maphieumuon);
            return exists;
        }
        // Thêm phiếu mượn
        public bool InsertPhieuMuon(int maphieumuon,int madocgia,int masach,DateTime ngaymuon,DateTime ngayphaitra,int nguoitao)
        {
            bool result= CheckSoLuong(masach);
            if (result)
            {
                PHIEUMUON phieumuon = new PHIEUMUON();
                phieumuon.MaPhieuMuon = maphieumuon;
                phieumuon.MaDocGia = madocgia;
                phieumuon.MaSach = masach;
                phieumuon.NgayMuon = ngaymuon;
                phieumuon.NgayPhaiTra = ngayphaitra;
                phieumuon.NguoiTao = nguoitao;
                try
                {
                    DB.PHIEUMUONs.InsertOnSubmit(phieumuon);
                    DB.SubmitChanges();
                    return true;
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                return false;
            }
        }
        // Xóa phiếu mượn
        public bool DeletePhieuMuon(int maphieumuon)
        {
            PHIEUMUON phieumuon = DB.PHIEUMUONs.FirstOrDefault(ma => ma.MaPhieuMuon == maphieumuon);
            try
            {
                if (phieumuon != null)
                {
                    if (phieumuon.PHIEUTRAs.Any())
                    {
                        return false;
                    }
                    else{
                        DB.PHIEUMUONs.DeleteOnSubmit(phieumuon);
                        DB.SubmitChanges();
                        return true;
                    }                        
                }
                return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xảy ra khi xóa phiếu mượn: " + ex.Message);
                return false;
            }

        }
        // Tìm phiếu mượn theo Mã Phiếu
        public PHIEUMUON TimPhieuMuon(int maphieumuon)
        {
            return DB.PHIEUMUONs.Where(mp=>mp.MaPhieuMuon==maphieumuon).FirstOrDefault();   
        }
        // Sửa phiếu mượn
        public bool UpdatePhieuMuon(int maphieumuon, int madocgia, int masach, DateTime ngaymuon, DateTime ngayphaitra, int nguoitao)
        {
            try
            {
                PHIEUMUON phieumuon = DB.PHIEUMUONs.Where(mp => mp.MaPhieuMuon == maphieumuon).FirstOrDefault();
                if (phieumuon != null)
                {
                    phieumuon.MaDocGia = madocgia;
                    phieumuon.MaSach = masach;
                    phieumuon.NgayMuon = ngaymuon;
                    phieumuon.NgayPhaiTra = ngayphaitra;
                    phieumuon.NguoiTao = nguoitao;
                    DB.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                throw new ArgumentException("Error here ?");
            }
        }
        // Xử lý số lượng sách khi mượn thành công !
        public void GiamSoLuong(int masach)
        {
            SACH sach=DB.SACHes.Where(ma => ma.MaSach == masach).FirstOrDefault();
            if(sach != null)
            {
                try
                {
                    sach.SoLuong -= 1;
                }
                catch { }
            }
        }
        // Check số lượng sách đã hết chưa
        public bool CheckSoLuong(int masach)
        {
            SACH result = DB.SACHes.Where(ma => ma.MaSach == masach ).FirstOrDefault();
            if (result.SoLuong>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Check masach có thay đổi không trước khi trừ số lượng
        public bool CheckMaSachCoThayDoiKhong(int masach,int maphieumuon)
        {
            int result=DB.PHIEUMUONs.Where(ma=>ma.MaSach==masach&&ma.MaPhieuMuon==maphieumuon).Count();
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Tìm kiếm phiếu mượn
        public List<DTO_PhieuMuonInfo> TimKiemPhieuMuon(int madocgia)
        {
            var query = from phieuMuon in DB.PHIEUMUONs
                        join docGia in DB.DOCGIAs on phieuMuon.MaDocGia equals docGia.MaDocGia
                        join sach in DB.SACHes on phieuMuon.MaSach equals sach.MaSach
                        join nhanVien in DB.DOCGIAs on phieuMuon.NguoiTao equals nhanVien.MaDocGia
                        join phieuTra in DB.PHIEUTRAs on phieuMuon.MaPhieuMuon equals phieuTra.MaPhieuMuon into phieuTraGroup
                        from phieuTraItem in phieuTraGroup.DefaultIfEmpty()
                        where phieuMuon.MaDocGia== madocgia
                        select new DTO_PhieuMuonInfo
                        {
                            MaPhieuMuon = phieuMuon.MaPhieuMuon,
                            HoTenDocGia = docGia.HoTen,
                            TenSach = sach.TenSach,
                            NgayMuon = phieuMuon.NgayMuon,
                            NgayPhaiTra = phieuMuon.NgayPhaiTra,
                            NguoiTao = nhanVien.HoTen,
                            Status = phieuTraItem != null ? 1 : 0
                        };

            return query.ToList();
        }
    }
}
