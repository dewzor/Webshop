using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Webbshop.Data;

namespace Webbshop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            //await DbPopulate.AddDataAsync();
            return Redirect("Store/Index");
        }
    }
}