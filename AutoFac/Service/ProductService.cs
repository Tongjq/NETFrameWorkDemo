using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        public IUserInfoService userInfoService { get; set; }
        List<string> products = new List<string>();
        public void AddNew(string proName)
        {
            if (proName!=null)
            {
                products.Add(proName);
            }

            userInfoService.AddNew("lisi","456");
        }
    }
}
