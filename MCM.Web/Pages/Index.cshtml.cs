using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCM.Web.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string MatrixChainData { get; set; }

        public IndexModel()
        {

        }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var url = Url.Page("MatrixChainMultiplication", new { matrixChainData = MatrixChainData });

            return Redirect(url);
        }
    }
}