using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace Facade_Pattern_Application_Test.Service.LoginServices
{


    public interface ILoginUserServices
    {
        void Exequte();
    }
    public class LoginUserServices : ILoginUserServices
    {
        public void Exequte()
        {
            Action1();
        }
        private void Action1() { }
    }
}
