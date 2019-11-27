using EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebUI.Models
{
    public class HomeIndexViewModel
    {
        public Class Class { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}