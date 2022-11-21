using Microsoft.AspNetCore.Mvc;
using Web_Vize_Proje.Models;

namespace Web_Vize_Proje.Controllers
{
    public class DuyuruController : Controller

    {
        EFDuyuruRepository duyuruRepository = new EFDuyuruRepository(new UniWebSiteContext());

        public IActionResult Index()
        {
           var veriler= duyuruRepository.DuyurularıListele();
            return View(veriler);
        }
    }
}
