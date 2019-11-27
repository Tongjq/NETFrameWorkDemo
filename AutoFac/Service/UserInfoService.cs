using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserInfoService : IUserInfoService,IRoleInfoService
    {
        List<object> users = new List<object>();
        public void AddNew(string name, string pwd)
        {
            if (name != null && pwd != null)
            {
                users.Add(new { Name=name, Pwd=pwd});
            }
        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public bool Login(string name, string pwd)
        {
            return name == "admin" && pwd == "123" == true ? true : false;         
        }
    }
}
