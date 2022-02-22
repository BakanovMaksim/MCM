using MCM.Infrastructure.Factories;
using MCM.SharedKernel;

namespace MCM.Web.Managers
{
    public class MatrixMultplicatorManager
    {
        public MatrixChainMultiplyResult GetMatrixChainMultiplyResult(string multiplicatorName, string matrixChainData)
        {
            var matrixChain = matrixChainData
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            var multiplicator = MatrixMultiplicatorFactory.Create(multiplicatorName, matrixChain);

            if (multiplicator == null)
            {
                throw new ArgumentNullException("", nameof(multiplicator));
            }

            return multiplicator.Solve();
        }
    }
}
