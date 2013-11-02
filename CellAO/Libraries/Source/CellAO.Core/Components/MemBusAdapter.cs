﻿#region License

// Copyright (c) 2005-2013, CellAO Team
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     * Neither the name of the CellAO Team nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
// A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
// PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
// NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// Last modified: 2013-11-02 14:58

#endregion

namespace CellAO.Core.Components
{
    #region Usings ...

    using System;
    using System.ComponentModel.Composition;

    using MemBus;
    using MemBus.Configurators;

    #endregion

    /// <summary>
    /// </summary>
    [Export(typeof(IBus))]
    public class MemBusAdapter : IBus
    {
        #region Fields

        /// <summary>
        /// </summary>
        private readonly MemBus.IBus memBus;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// </summary>
        /// <param name="iocAdapter">
        /// </param>
        [ImportingConstructor]
        public MemBusAdapter(IocAdapter iocAdapter)
        {
            this.memBus =
                BusSetup.StartWith<AsyncConfiguration>()
                    .Apply<IoCSupport>(s => s.SetAdapter(iocAdapter).SetHandlerInterface(typeof(IHandle<>)))
                    .Construct();
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// </summary>
        /// <param name="message">
        /// </param>
        public void Publish(object message)
        {
            this.memBus.Publish(message);
        }

        /// <summary>
        /// </summary>
        /// <param name="action">
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// </returns>
        public IDisposable Subscribe<T>(Action<T> action)
        {
            return this.memBus.Subscribe(action);
        }

        #endregion
    }
}