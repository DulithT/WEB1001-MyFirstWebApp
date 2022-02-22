using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB1001_MyFirstWebApp_CS.Pages
{
    public class IntroModel : PageModel
    {

        public int Int1 { get; set; } = 0;
        public int Int2 { get; set; } = 0;


        public void OnGet()
        {
        }
    }
}
