using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class YoneticiController : Controller
    {
        public IWebHostEnvironment _environment;

        public YoneticiController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Git()
        {
            return View();
        }

        public IActionResult AdminLogout()
        {
            return SignOut("Cookies", "oidc");
        }

        [HttpPost]
        public async Task<string> Upload(IFormFile file)
        {
            string dosyaAdi = "";
            string dosyaninYuklenecegiKlasorYolu = Path.Combine(_environment.WebRootPath, "InContent");

            if (!Directory.Exists(dosyaninYuklenecegiKlasorYolu))
            {
                Directory.CreateDirectory(dosyaninYuklenecegiKlasorYolu);
            }

            if (file.FileName != null)
            {
                dosyaAdi = file.FileName;
                string filePath = Path.Combine(dosyaninYuklenecegiKlasorYolu, dosyaAdi);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    //seçilen resim ilgili klasörü ilgili ismi ile birlikte oluşturulur
                    await file.CopyToAsync(fileStream);
                }

            }
            return dosyaAdi;
        }

        [HttpPost]
        public async Task<string> UploadSound([FromForm] IFormFile voiceFile)
        {
            var dosyaAdi = "";
            string dosyaninYuklenecegiKlasorYolu = Path.Combine(_environment.WebRootPath, "SoundContent");

            if (!Directory.Exists(dosyaninYuklenecegiKlasorYolu))
            {
                Directory.CreateDirectory(dosyaninYuklenecegiKlasorYolu);
            }

            dosyaAdi = voiceFile.FileName;


            string filePath = Path.Combine(dosyaninYuklenecegiKlasorYolu, dosyaAdi);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                //seçilen resim ilgili klasörü ilgili ismi ile birlikte oluşturulur
                await voiceFile.CopyToAsync(fileStream);
            }


            return dosyaAdi;

        }


    }
}
