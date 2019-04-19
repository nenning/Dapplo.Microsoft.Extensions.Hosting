// Copyright (c) Dapplo and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace Dapplo.Microsoft.Extensions.Hosting.Wpf.Internals
{
    /// <inheritdoc />
    public class WpfContext : IWpfContext
    {
        /// <inheritdoc />
        public ShutdownMode ShutdownMode { get; set; } = ShutdownMode.OnLastWindowClose;

        /// <inheritdoc />
        public bool IsLifetimeLinked { get; set; }

        /// <inheritdoc />
        public bool IsRunning { get; set; }

        /// <inheritdoc />
        public Application WpfApplication { get; set; }
    }
}