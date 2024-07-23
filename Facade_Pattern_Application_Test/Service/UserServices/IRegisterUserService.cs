using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern_Application_Test.Service.UserServices
{



    public interface IRegisterUserService
    {
        void Exequt();
    }
    public class RegisterUserService : IRegisterUserService
    {
        public void Exequt()
        {
            Action1();
            Action2();
            Action3();
        }
        private void Action1()
        {

        }
        private void Action3()
        {

        }
        private void Action2()
        {

        }
    }
}
