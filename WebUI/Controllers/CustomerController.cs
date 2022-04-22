using Microsoft.AspNetCore.Mvc;
using WebUI.Resources;

namespace WebUI.Controllers
{
    public class CustomerController : Controller
    {
        private readonly LocalizationService _localizationService;

        public CustomerController(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }

        public IActionResult Index()
        {
            var fullName = _localizationService.GetLocalizedHtmlString("FullName");
            var city = _localizationService.GetLocalizedHtmlString("City");
            var phoneNumber = _localizationService.GetLocalizedHtmlString("PhoneNumber");
            
            return View();
        }
    }
}
