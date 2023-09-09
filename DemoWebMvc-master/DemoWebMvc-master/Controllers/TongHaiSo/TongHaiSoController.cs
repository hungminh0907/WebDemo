using Microsoft.AspNetCore.Mvc;

namespace DemoWebMvc.Controllers.TongHaiSo
{
    public class TongHaiSoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(int soNguyen1, int soNguyen2)
        {
            ViewData["SoNguyen1"] = soNguyen1;
            ViewData["SoNguyen2"] = soNguyen2;
            ViewData["KetQua"] = soNguyen1 + soNguyen2;
            return View();
        }






        //[HttpPost]
        //public IActionResult Index(int soNguyen1, int soNguyen2)
        //{
        //    try
        //    {
        //        ViewData["SoNguyen1"] = soNguyen1;
        //        ViewData["SoNguyen2"] = soNguyen2;
        //        ViewData["KetQua"] = soNguyen1 / soNguyen2;
        //        ViewData["Message"] = "";
        //    }
        //    catch (DivideByZeroException dex)
        //    {
        //        ViewData["Message"] = "Khong dc phep chia cho 0";
        //    }
        //    catch (Exception ex)
        //    {
        //        ViewData["Message"] = ex.Message;
        //    }
        //    return View();
        //}
    }
}
