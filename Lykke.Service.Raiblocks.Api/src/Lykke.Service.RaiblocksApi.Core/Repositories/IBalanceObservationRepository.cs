﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lykke.Service.RaiblocksApi.Core.Repositories
{
    public interface IBalanceObservationRepository
    {
        Task<bool> CreateIfNotExistsAsync(string address);
    }
}
