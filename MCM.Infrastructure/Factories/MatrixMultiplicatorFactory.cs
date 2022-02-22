using MCM.Core.Multiplicators;
using MCM.SharedKernel;

namespace MCM.Infrastructure.Factories
{
    public class MatrixMultiplicatorFactory
    {
        private static IDictionary<string, Func<List<int>, BaseMatrixMultiplicator>> Instances =
            new Dictionary<string, Func<List<int>, BaseMatrixMultiplicator>>
            {
                ["Dynamic"] = (matrixChain) => new DynamicMatrixMultiplicator(matrixChain),
            };

        public static BaseMatrixMultiplicator? Create(string instanceName, List<int> matrixChain)
        {
            return Instances.TryGetValue(instanceName, out var instance) ? instance(matrixChain) : null;
        }
    }
}
