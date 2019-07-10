using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Website.Start.Pages
{
    public class GalleryModel: PageModel
    {
        public string Message;

        public void OnGet()
        {
            Message = "Authentic Documentation";
        }
    }
}
