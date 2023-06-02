using System;

using R5T.T0132;


namespace R5T.T0200.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="ILocalRepositoryDirectoryPath"/>
        public ILocalRepositoryDirectoryPath ToLocalRepositoryDirectoryPath(string value)
        {
            var output = new LocalRepositoryDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IRepositoryDirectoryPath"/>
        public IRepositoryDirectoryPath ToRepositoryDirectoryPath(string value)
        {
            var output = new RepositoryDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="ILocalGitRepositoryDirectoryPath"/>
        public ILocalGitRepositoryDirectoryPath ToLocalGitRepositoryDirectoryPath(string value)
        {
            var output = new LocalGitRepositoryDirectoryPath(value);
            return output;
        }
    }
}
