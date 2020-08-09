using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.service
{
    /// <summary>
    /// Summary description for TransactionService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TransactionService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public static string GetTransactions()
        {
            return JsonHelper.Serialize(TransactionHandler.GetTransactions());
        }
    }
}
