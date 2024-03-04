using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DocGia
    {
        QLThuVienDataContext DB=new QLThuVienDataContext();
        //Kiểm tra độc giả có tồn tại hay không
        public bool IsCheckMaDocGia(int madocgia)
        {
            bool exists = DB.DOCGIAs.Any(dg => dg.MaDocGia == madocgia);

            return exists;
        }
    }
}
