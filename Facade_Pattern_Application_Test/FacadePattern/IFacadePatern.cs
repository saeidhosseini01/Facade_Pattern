using Facade_Pattern_Application_Test.Service.LoginServices;
using Facade_Pattern_Application_Test.Service.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern_Application_Test.FacadePattern
{
    public interface IFacadePaternServices
    {
      public   IRegisterUserService RegisterUserService { get; }
      public   ILoginUserServices LoginUserServices { get; }
    }
    public class FacadePaternServices: IFacadePaternServices
    {
        private ILoginUserServices _loginUserServices;
        private IRegisterUserService _registerUserService;
        public ILoginUserServices LoginUserServices
        {
            get { return _loginUserServices = _loginUserServices ?? new LoginUserServices(); }
        }

        public IRegisterUserService RegisterUserService
        {
            get { return _registerUserService = _registerUserService ?? new RegisterUserService(); }
        }

       
    }
}
