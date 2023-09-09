using Microsoft.AspNetCore.Mvc;
using WebDemo.Models.TinhLaiSuat;

namespace WebDemo.Controllers.NewFolder
{
    public class TinhLaiSuatController : Controller
    {
        public IActionResult TinhLaiSuat()
        {
            var model = new ModelTinhLaiSuat();
            ViewData["Message"] = "";
            return View(model);
        }
        [HttpPost]
        public IActionResult TinhLaiSuat(ModelTinhLaiSuat input)
        {
           
            
                var model = new ModelTinhLaiSuat();
                var rexin = new ModelTinhLaiSuat(input.soTien, input.laiSuat, input.kyHan);
                ViewData["Message"] = "";
                return View(rexin);
           
            
        }
    }
}
