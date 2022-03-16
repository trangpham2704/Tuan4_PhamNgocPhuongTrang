using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TUAN4_Phamngocphuongtrang.Models
{
    public class GioHang
    {
        myDataDataContext data = new myDataDataContext();
        public int masach { get; set; }

        [Display(Name ="TÊN SÁCH")]
        public String tensach { get; set; }

        [Display(Name = "HÌNH SÁCH")]
        public String hinh { get; set; }

        [Display(Name = "GIÁ BÁN")]
        public Double giaban { get; set; }

        [Display(Name = "SỐ LƯỢNG")]
        public int soluong { get; set; }

        [Display(Name = "THÀNH TIỀN")]
        public Double thanhtien { get { return soluong * giaban; } }

        public GioHang(int id)
        {
            masach = id;
            Sach AC = data.Saches.Single(n => n.masach== masach);
            tensach = AC.tensach;
            hinh = AC.hinh;
            giaban = double.Parse(AC.giaban.ToString());
            soluong = 1;
        }


    }
}