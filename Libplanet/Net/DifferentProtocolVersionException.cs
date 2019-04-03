using System;

namespace Libplanet.Net
{
    /// <summary>
    /// The exception that is thrown when the version of the
    /// <see cref="Peer" /> that <see cref="Swarm" /> is trying to connect
    /// to is different.
    /// </summary>
    [Serializable]
    public sealed class DifferentProtocolVersionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DifferentProtocolVersionException"/> class.
        /// </summary>
        /// <param name="expectedVersion">The protocol version of the current
        /// <see cref="Swarm"/>.</param>
        /// <param name="actualVersion">The protocol version of the
        /// <see cref="Peer"/> that <see cref="Swarm" /> is trying to connect
        /// to.</param>
        /// <param name="message">Specifies an <see cref="Exception.Message"/>.
        /// </param>
        public DifferentProtocolVersionException(
            string message,
            int expectedVersion,
            int actualVersion)
            : base($"Expected Version: {expectedVersion}, " +
                   $"Actual Version: {actualVersion}, {message}")
        {
            ExpectedVersion = expectedVersion;
            ActualVersion = actualVersion;
        }

        /// <summary>
        /// The protocol version of the current <see cref="Swarm"/>.
        /// </summary>
        public int ExpectedVersion { get; }

        /// <summary>
        /// The protocol version of the <see cref="Peer"/> that the
        /// <see cref="Swarm" /> is trying to connect to.
        /// </summary>
        public int ActualVersion { get; }
    }
}
