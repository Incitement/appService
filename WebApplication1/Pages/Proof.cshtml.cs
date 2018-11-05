using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class ProofModel : PageModel
    {
        public string Message { get; set; }
        public string Loop { get; set; }

        public void OnGet()
        {
            Message = "This is a test page to see how the navigation bar handles new pages.";
        
            for (; ; )
            {
                Loop ="LOOOOOOPS";
            }
        }
    }
}

