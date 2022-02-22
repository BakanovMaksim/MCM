namespace MCM.SharedKernel
{
    public abstract class BaseMatrixMultiplicator
    {
        protected readonly IReadOnlyList<int> _matrixChain;

        public BaseMatrixMultiplicator(IReadOnlyList<int> matrixChain)
        {
            if (matrixChain == null)
                throw new ArgumentNullException(ExceptionMessages.ARGUMENT_NULL, nameof(matrixChain));

            if (matrixChain.Count == 0)
                throw new ArgumentException(ExceptionMessages.INPUT_ARGUMENT_NO_CORRECT, nameof(matrixChain));

            _matrixChain = matrixChain;
        }

        public abstract MatrixChainMultiplyResult Solve();
    }
}
