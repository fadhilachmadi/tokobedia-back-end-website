using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TokoBeDia.helper
{
    public class Response
    {

        public bool successStatus;
        public string message;
        public dynamic data;

        public Response(bool successStatus)
        {
            this.successStatus = successStatus;
        }

        public Response(bool successStatus, string message) {
            this.successStatus = successStatus;
            this.message = message;
        }

        public Response(bool successStatus, dynamic data)
        {
            this.successStatus = successStatus;
            this.data = data;
        }

        public Response(bool successStatus, string message, dynamic data) {
            this.successStatus = successStatus;
            this.message = message;
            this.data = data;
        }
    }
}