using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TokoBeDia.handler;
using TokoBeDia.helper;

namespace TokoBeDia.controller
{
    public class HomepageController
    {
           public static Response ViewHomepage()
        {
            return new Response(true, HomepageHandler.viewHomepage());
        }
    }
}