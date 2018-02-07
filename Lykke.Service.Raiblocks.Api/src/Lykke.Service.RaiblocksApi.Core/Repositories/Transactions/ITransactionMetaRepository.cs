﻿using Lykke.Service.RaiblocksApi.Core.Domain.Entities.Transactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lykke.Service.RaiblocksApi.Core.Repositories.Transactions
{
    public interface ITransactionMetaRepository<TransactionMeta> : IRepository<TransactionMeta>
        where TransactionMeta : ITransactionMeta
    {
    }
}
