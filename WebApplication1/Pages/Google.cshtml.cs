using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class GoogleModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "You have signed in with your google account";
        }
    }
}