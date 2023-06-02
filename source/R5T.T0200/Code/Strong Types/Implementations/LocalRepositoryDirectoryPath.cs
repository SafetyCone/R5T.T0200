using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0200
{
    /// <inheritdoc cref="ILocalRepositoryDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class LocalRepositoryDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ILocalRepositoryDirectoryPath
    {
        public LocalRepositoryDirectoryPath(string value)
            : base(value)
        {
        }
    }
}