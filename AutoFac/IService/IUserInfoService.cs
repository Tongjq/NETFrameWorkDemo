using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IUserInfoService
    {
        bool Login(string name, string pwd);
        void AddNew(string name, string pwd);

    }
}
