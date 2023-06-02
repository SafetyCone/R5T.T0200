using System;


namespace R5T.T0200.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToLocalRepositoryDirectoryPath(string)"/>
        public static ILocalRepositoryDirectoryPath ToLocalRepositoryDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLocalRepositoryDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToRepositoryDirectoryPath(string)"/>
        public static IRepositoryDirectoryPath ToRepositoryDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToRepositoryDirectoryPath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLocalGitRepositoryDirectoryPath(string)"/>
        public static ILocalGitRepositoryDirectoryPath ToLocalGitRepositoryDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLocalGitRepositoryDirectoryPath(value);
        }
    }
}
