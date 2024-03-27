using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DocGia
    {
        QLThuVienDataContext DB=new QLThuVienDataContext();
    public string CalculateMD5Hash(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }
            return sb.ToString();
        }
    }

    // Xử lý đăng ký
    public bool Register(string username, string matkhau, int quyen = 3)
    {
        try
        {
            DOCGIA dg = new DOCGIA();
            dg.HoTen = username;
            dg.MatKhau = matkhau;
            dg.Quyen = quyen;
            DB.DOCGIAs.InsertOnSubmit(dg);
            DB.SubmitChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
            throw;

        }
    }
    // Xử lý đăng nhập
    public DOCGIA Loggin(string username, string password)
    {
        try
        {
            var user = DB.DOCGIAs.Where(dg => dg.HoTen == username && dg.MatKhau == password).FirstOrDefault();
            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        catch
        {
            throw new ArgumentException("Invalid username or password.");
        }
    }
    //Lấy độc giả theo mã độc giả
    public int getDocGiaByMaDocGia(int madocgia)
    {
         DOCGIA docgia = DB.DOCGIAs.FirstOrDefault(dg => dg.MaDocGia == madocgia);
            try
            {
                if (docgia !=null)
                {
                    return docgia.Quyen;
                }
                else { 
                return 0;
                }
            }
            catch { return 0; }
    }

        //Kiểm tra độc giả có tồn tại hay không
        public bool IsCheckMaDocGia(int madocgia)
    {
        bool exists = DB.DOCGIAs.Any(dg => dg.MaDocGia == madocgia);

        return exists;
    }
        // Lấy tất cả thông tin độc giả
    public List<DTO_DocGiaList> LayTatCa(string MaDocGia, string HoTen)
    {
        var query = from DOCGIA in DB.DOCGIAs.Where(oh => oh.MaDocGia.ToString().Contains(MaDocGia) && oh.HoTen.Contains(HoTen))
                    select new DTO_DocGiaList
                    {
                        MaDocGia = DOCGIA.MaDocGia,
                        HoTen = DOCGIA.HoTen,
                        NgaySinh = DOCGIA.NgaySinh,
                        GioiTinh = DOCGIA.GioiTinh,
                        DiaChi = DOCGIA.DiaChi,
                        Quyen = DOCGIA.Quyen.ToString(),
                        MatKhau = DOCGIA.MatKhau
                    };


        return query.ToList();
    }
    // Thêm độc giả
    public bool InsertDocGia(string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi ,string MatKhau="123",int Quyen=3)
    {

        DOCGIA docgia = new DOCGIA();
        docgia.HoTen = HoTen;
        docgia.NgaySinh = NgaySinh;
        docgia.GioiTinh = GioiTinh;
        docgia.DiaChi = DiaChi;
        docgia.MatKhau = MatKhau;
        docgia.Quyen = Quyen;
            try
            {
            DB.DOCGIAs.InsertOnSubmit(docgia);
            DB.SubmitChanges();
            return true;
        }
        catch (Exception)
        {

            throw;
        }
    }
    // Sửa độc giả
    public bool UpdateDocGia(int MaDocGia, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi,string MatKhau="123",int Quyen=3)
    {
        DOCGIA docgia = DB.DOCGIAs.Where(dg => dg.MaDocGia == MaDocGia).FirstOrDefault();
        if (docgia != null)
        {
            docgia.HoTen = HoTen;
            docgia.NgaySinh = NgaySinh;
            docgia.GioiTinh = GioiTinh;
            docgia.DiaChi = DiaChi;
            docgia.MatKhau = MatKhau;
            docgia.Quyen = Quyen;
            DB.SubmitChanges();
            return true;
        }
        else
        {
            return false;
        }
    }
    // Xóa độc giả
    public bool DeleteDocGia(int MaDocGia)
    {
        DOCGIA docgia = DB.DOCGIAs.Where(ma => ma.MaDocGia == MaDocGia).FirstOrDefault();
        try
        {
            if (docgia != null)
            {
                DB.DOCGIAs.DeleteOnSubmit(docgia);
                DB.SubmitChanges();
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    }
}
