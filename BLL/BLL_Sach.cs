using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Sach
    {
        QLThuVienDataContext DB=new QLThuVienDataContext();
        //Kiểm tra sách có tồn tại không
        public bool IsCheckMaSach(int masach)
        {

            bool exists = DB.SACHes.Any(s => s.MaSach == masach);

            return exists;
        }
    }
}
