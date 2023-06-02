using System;

using R5T.T0178;


namespace R5T.T0200
{
    /// <summary>
    /// <inheritdoc cref="ILocalRepositoryDirectoryPath" path="/summary"/>
    /// <para>
    /// Quality-of-life name for <see cref="ILocalRepositoryDirectoryPath"/>.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IRepositoryDirectoryPath : IStrongTypeMarker,
        ILocalRepositoryDirectoryPath
    {
    }
}