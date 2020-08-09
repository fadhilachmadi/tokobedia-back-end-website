using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.helper
{
    public class ErrorMessage
    {
        public static void print(System.Web.UI.Page page,string message)
        {
            page.Response.Write("<script>alert(\"" + message  + "\")</script>");
        }
    }
}