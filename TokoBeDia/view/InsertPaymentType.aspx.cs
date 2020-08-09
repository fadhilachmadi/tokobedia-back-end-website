using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;
using TokoBeDia.helper;

namespace TokoBeDia.view
{
    public partial class InsertPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnInsertPaymentType_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;

            Response InsertPaymentType = PaymentTypeController.InsertPaymentType(name);

            if (!InsertPaymentType.successStatus)
            {
                ErrorMessage.print(this, InsertPaymentType.message);
            }
            Response.Redirect("ViewPaymentType.aspx");
        }
    }
}