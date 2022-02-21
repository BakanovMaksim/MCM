namespace MCM.Core.Multiplicators
{
    public class DynamicMatrixMultiplicator : BaseMatrixMultiplicator
    {
        public DynamicMatrixMultiplicator(IReadOnlyList<int> matrixChain)
            : base(matrixChain) { }

        protected override int Multiplicate()
        {
            var n = _matrixChain.Count - 1;
            var container = new int[n, n];

            for (int index = 0; index < n; index++)
            {
                container[index, index] = 0;
            }

            for (int l = 1; l < n; l++)
            {
                for (int i = 0; i < n - l; i++)
                {
                    var j = i + l;
                    container[i, j] = int.MaxValue;

                    for (int k = i; k < j; k++)
                    {
                        var intermediateValue = container[i, k] + container[k + 1, j] + (_matrixChain[i] * _matrixChain[k + 1] * _matrixChain[j + 1]);
                        container[i, j] = Math.Min(container[i, j], intermediateValue);
                    }
                }
            }

            return container[0, n - 1];
        }
    }
}
