using MCM.Web.Managers;
using MCM.SharedKernel;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MCM.Web.Pages
{
    public class MatrixChainMultiplicationModel : PageModel
    {
        [BindProperty]
        public MatrixChainMultiplyResult DynamicMethodResult { get; set; }

        private readonly MatrixMultplicatorManager _matrixMultplicatorManager;

        public MatrixChainMultiplicationModel()
        {
            _matrixMultplicatorManager = new();
        }

        public void OnGet(string matrixChainData)
        {
            DynamicMethodResult = _matrixMultplicatorManager.GetMatrixChainMultiplyResult("Dynamic", matrixChainData);
        }
    }
}
