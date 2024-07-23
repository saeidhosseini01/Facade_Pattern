using Facade_Pattern_Application_Test.FacadePattern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Facade_Pattern_EndPoint.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private IFacadePaternServices _facadePaternServices;
        public IndexModel(IFacadePaternServices facadePaternServices)
        {
            _facadePaternServices = facadePaternServices;
        }
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public void OnGet()
        {
            _facadePaternServices.LoginUserServices.Exequte();
            _facadePaternServices.RegisterUserService.Exequt();
        }
    }
}
