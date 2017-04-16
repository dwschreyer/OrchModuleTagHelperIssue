using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace PortalFramework
{
    public abstract class BaseController : Controller
    {
        public DateTime Now { get; set; }
        
        public void DoStuff()
        {
            Now = DateTime.Now;
        }
    }
}
