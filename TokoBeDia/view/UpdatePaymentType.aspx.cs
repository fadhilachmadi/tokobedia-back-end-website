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
    public partial class UpdatePaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                //call the function to load initial data into controls....
                int id = Int32.Parse(Request.QueryString["id"].ToString());
                Response ViewUpdatePaymentType = PaymentTypeController.ViewUpdatePaymentType(id);
                PaymentType paymentType = ViewUpdatePaymentType.data;
                txtName.Text = paymentType.Name;
            }
        }

        protected void btnUpdatePaymentType_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Request.QueryString["id"].ToString());
            Response UpdatePaymentType = PaymentTypeController.UpdatePaymentType(id, txtName.Text);

            if (!UpdatePaymentType.successStatus)
            {
                ErrorMessage.print(this, UpdatePaymentType.message);
                return;
            }
            Response.Redirect("ViewPaymentType.aspx");
        }
    }
}