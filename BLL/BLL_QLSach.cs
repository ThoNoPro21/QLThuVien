using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_QLSach
    {
        private QLThuVienDataContext db;

        public BLL_QLSach()
        {
            db = new QLThuVienDataContext();
        }
        public bool IsCheckMaSach(int masach)
        {

            bool exists = db.SACHes.Any(s => s.MaSach == masach);

            return exists;
        }
        public object GetAllSach()
        {
            var query = from sach in db.SACHes
                        join tinhtrang in db.TINHTRANGs
                        on sach.TinhTrangID equals tinhtrang.ID
                        join theloai in db.THELOAIs
                        on sach.TheLoaiID equals theloai.ID
                        join tacgia in db.TACGIAs
                        on sach.TacGiaID equals tacgia.ID
                        join nxb in db.NHAXUATBANs
                        on sach.NhaXuatBanID equals nxb.ID
                        select new
                        {
                            MaSach = sach.MaSach,
                            TenSach = sach.TenSach,
                            GiaSach = sach.GiaSach,
                            SoLuong = sach.SoLuong,
                            
                            TinhTrang = tinhtrang.Ten, 
                            TheLoai = theloai.TenTheLoai,
                            TacGia = tacgia.TenTacGia,
                            NhaXuatBan = nxb.TenNXB
                        };
            return query.ToList();
        }

        public object SearchSach(string searchString)
        {
            var query = from sach in db.SACHes
                        join tinhtrang in db.TINHTRANGs on sach.TinhTrangID equals tinhtrang.ID
                        join theloai in db.THELOAIs on sach.TheLoaiID equals theloai.ID
                        join tacgia in db.TACGIAs on sach.TacGiaID equals tacgia.ID
                        join nxb in db.NHAXUATBANs on sach.NhaXuatBanID equals nxb.ID
                        where sach.TenSach.Contains(searchString)
                        select new
                        {
                            sach.MaSach,
                            sach.TenSach,
                            sach.GiaSach,
                            sach.SoLuong,
                            TinhTrang = tinhtrang.Ten,
                            TheLoai = theloai.TenTheLoai,
                            TacGia = tacgia.TenTacGia,
                            NhaXuatBan = nxb.TenNXB

                        }
                            ;

            return query.ToList();
        }
        
        public List<THELOAI> GetTheLoai()
        {
            return db.THELOAIs.ToList();
        }
        public object GetSachByTheLoaiName(string theLoaiName)
        {
            var query = from sach in db.SACHes
                        join tinhtrang in db.TINHTRANGs on sach.TinhTrangID equals tinhtrang.ID
                        join theloai in db.THELOAIs on sach.TheLoaiID equals theloai.ID
                        join tacgia in db.TACGIAs on sach.TacGiaID equals tacgia.ID
                        join nxb in db.NHAXUATBANs on sach.NhaXuatBanID equals nxb.ID
                        where theloai.TenTheLoai == theLoaiName
                        select new
                        {
                            sach.MaSach,
                            sach.TenSach,
                            sach.GiaSach,
                            sach.SoLuong,
                            TinhTrang = tinhtrang.Ten,
                            TheLoai = theloai.TenTheLoai,
                            TacGia = tacgia.TenTacGia,
                            NhaXuatBan = nxb.TenNXB

                        };

        return query.ToList();
        }

        public List<string> GetTenTinhTrang()
        {
            return db.TINHTRANGs.Select(tinhtrang => tinhtrang.Ten).ToList();
        }
        public List<string> GetTenTheLoai()
        {
            return db.THELOAIs.Select(theloai => theloai.TenTheLoai).ToList();
        }
        public List<string> GetTenTacGia()
        {
            return db.TACGIAs.Select(tacgia => tacgia.TenTacGia).ToList();
        }
        public List<string> GetTenNXB()
        {
            return db.NHAXUATBANs.Select(nxb => nxb.TenNXB).ToList();
        }

        public int AddTheLoai(string TheLoainame)
        {
            if (string.IsNullOrWhiteSpace(TheLoainame))
            {
                throw new ArgumentException("Thể loại không được để trống.");
            }
            var theloai = db.THELOAIs.FirstOrDefault(g => g.TenTheLoai == TheLoainame);
            if(theloai == null)
            {
                theloai = new THELOAI { TenTheLoai = TheLoainame };
                db.THELOAIs.InsertOnSubmit(theloai);
                db.SubmitChanges();
            }
            return theloai.ID;
        }

        public int AddTacGia(string TacGianame)
        {
            if (string.IsNullOrWhiteSpace(TacGianame))
            {
                throw new ArgumentException("Tác giả không được để trống.");
            }
            var tacgia = db.TACGIAs.FirstOrDefault(g => g.TenTacGia == TacGianame);
            if (tacgia == null)
            {
                tacgia = new TACGIA { TenTacGia = TacGianame };
                db.TACGIAs.InsertOnSubmit(tacgia);
                db.SubmitChanges();
            }
            return tacgia.ID;
        }

        public int AddNhaXuatBan(string NXBname)
        {
            if (string.IsNullOrWhiteSpace(NXBname))
            {
                throw new ArgumentException("Nhà xuất bản không được để trống.");
            }
            var nhaxb = db.NHAXUATBANs.FirstOrDefault(g => g.TenNXB == NXBname);
            if (nhaxb == null)
            {
                nhaxb = new NHAXUATBAN { TenNXB = NXBname };
                db.NHAXUATBANs.InsertOnSubmit(nhaxb);
                db.SubmitChanges();
            }
            return nhaxb.ID;
        }


        public bool AddNewSach(string tenSach, string giaSachStr, int soLuong, int theLoaiID, int tacGiaID, int nhaXuatBanID)
        {
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                throw new ArgumentException("Tên sách không được để trống.");
            }
            if (!decimal.TryParse(giaSachStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal giaSach))
            {
                throw new ArgumentException("Giá sách không hợp lệ.");
            }
            var existingSach = db.SACHes.FirstOrDefault(s => s.TenSach.ToLower() == tenSach.ToLower());
            if (existingSach == null)
            {
                SACH newSach = new SACH
                {
                    TenSach = tenSach,
                    GiaSach = giaSach.ToString(CultureInfo.InvariantCulture),
                    SoLuong = soLuong,
                    TinhTrangID = soLuong > 0 ? 1 : 2,
                    TheLoaiID = theLoaiID,
                    TacGiaID = tacGiaID,
                    NhaXuatBanID = nhaXuatBanID
                };
                db.SACHes.InsertOnSubmit(newSach);
                db.SubmitChanges();
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public bool UpdateSach(int maSach, string tenSach, string giaSachStr, int soLuong, int theLoaiID, int tacGiaID, int nhaXuatBanID)
        {
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                throw new ArgumentException("Tên sách không được để trống.");
            }
            if (!decimal.TryParse(giaSachStr, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal giaSach))
            {
                throw new ArgumentException("Giá sách không hợp lệ.");
            }
            var existingSachWithSameName = db.SACHes.FirstOrDefault(s => s.TenSach.ToLower() == tenSach.ToLower() && s.MaSach != maSach);
            if (existingSachWithSameName != null)
            {
                return false;
            }
            else
            {
                var sachToUpdate = db.SACHes.SingleOrDefault(s => s.MaSach == maSach);
                if (sachToUpdate != null)
                {
                    sachToUpdate.TenSach = tenSach;
                    sachToUpdate.GiaSach = giaSach.ToString(CultureInfo.InvariantCulture);
                    sachToUpdate.SoLuong = soLuong;
                    sachToUpdate.TinhTrangID = soLuong > 0 ? 1 : 2;
                    sachToUpdate.TheLoaiID = theLoaiID;
                    sachToUpdate.TacGiaID = tacGiaID;
                    sachToUpdate.NhaXuatBanID = nhaXuatBanID;

                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    throw new Exception("Sách không tồn tại");
                }
            }
               
        }

        public void DeleteSach(int maSach)
        {
            var sachToDelete = db.SACHes.SingleOrDefault(s => s.MaSach == maSach);
            if(sachToDelete != null)
            {
                db.SACHes.DeleteOnSubmit(sachToDelete);
                db.SubmitChanges();
            }
            else
            {
                throw new Exception("Sách không tồn tại");
            }
        }
    }
}
