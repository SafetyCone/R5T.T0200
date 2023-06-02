using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0200
{
    /// <inheritdoc cref="ILocalGitRepositoryDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class LocalGitRepositoryDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ILocalGitRepositoryDirectoryPath
    {
        public LocalGitRepositoryDirectoryPath(string value)
            : base(value)
        {
        }
    }
}