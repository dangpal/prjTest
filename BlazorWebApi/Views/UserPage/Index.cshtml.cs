using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorWebApi.Views.UserPage
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            RedirectToRoute("/Index");
        }
        public override RedirectToRouteResult RedirectToRoute(string routeName)
        {
            return base.RedirectToRoute(routeName);
        }
    }
}
