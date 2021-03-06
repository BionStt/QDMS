﻿// -----------------------------------------------------------------------
// <copyright file="IDividendDataSource.cs" company="">
// Copyright 2017 Alexander Soffronow Pagonidis
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QDMS
{
    /// <summary>
    /// Interface for earnings announcement data sources
    /// </summary>
    public interface IEarningsAnnouncementSource
    {
        /// <summary>
        /// Fires on any error.
        /// </summary>
        event EventHandler<ErrorArgs> Error;

        /// <summary>
        /// 
        /// </summary>
        bool Connected { get; }

        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        void Connect();

        /// <summary>
        /// 
        /// </summary>
        void Disconnect();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<List<EarningsAnnouncement>> RequestData(EarningsAnnouncementRequest request);
    }
}
