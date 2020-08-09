using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.helper;
using TokoBeDia.service;

namespace TokoBeDia.controller
{
    public class TransactionController
    {
        public static List<HeaderTransaction> GetTransactions()
        {
            return JsonHelper.Deserialize<List<HeaderTransaction>>(TransactionService.GetTransactions());
        }

    }
}