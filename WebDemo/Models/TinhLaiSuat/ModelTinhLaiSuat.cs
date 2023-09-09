using System.Text.RegularExpressions;

namespace WebDemo.Models.TinhLaiSuat
{
    public class ModelTinhLaiSuat
    {
        //Khởi tạo hàm mặc định
        public ModelTinhLaiSuat() { }
        public int soTien { get; set; }

        public int laiSuat { get; set; }

        public int kyHan { get; set; }

        public int Total { get; set; }

        public int Sum { get; set; }

        // khởi tạo hàm có tham số 
        public ModelTinhLaiSuat(int soTien, int laiSuat, int kyHan)
        {
            this.soTien = soTien;
            this.laiSuat = laiSuat;
            this.kyHan = kyHan;
            this.Total = soTien * laiSuat / 100 * kyHan / 360;
            this.Sum = soTien + Total;
        }
    }
}
