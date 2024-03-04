using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   
    public class BLL_Account
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
        public bool Register(string username,string matkhau,int quyen=3)
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
        public DOCGIA Loggin(string username,string password)
        {
            var query=DB.DOCGIAs.Where(dg => dg.HoTen == username && dg.MatKhau == password).FirstOrDefault();
            if (query != null)
            {
                try
                {
                    return query;
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
            else
            {
                return null ;
            }
        }
    }
}
