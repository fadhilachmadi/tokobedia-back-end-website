using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.repository
{
    public class TransactionRepository
    {
        public static DatabaseEntities db = new DatabaseEntities();

        public static List<HeaderTransaction> GetTransactions()
        {
            return db.HeaderTransactions.ToList();
        }
    }
}