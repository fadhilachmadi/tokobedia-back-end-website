using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.repository;

namespace TokoBeDia.handler
{
    public class TransactionHandler
    {
        public static List<HeaderTransaction> GetTransactions()
        {
            return TransactionRepository.GetTransactions();
        }
    }
}