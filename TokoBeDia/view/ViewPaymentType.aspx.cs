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
    public partial class ViewPaymentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if ((String)Session["role"] == "admin")
            {
                dgvPaymentType.Columns[1].Visible = true;
                dgvPaymentType.Columns[2].Visible = true;
            }

            Response viewPaymentType = PaymentTypeController.ViewPaymentType();
            dgvPaymentType.DataSource = viewPaymentType.data;
            dgvPaymentType.DataBind();
        }

        protected void btnUpdatePaymentType_Click(object sender, EventArgs e)
        {
            int paymentTypeId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response.Redirect("UpdatePaymentType.aspx?id=" + paymentTypeId);
        }

        protected void btnDeletePaymentType_Click(object sender, EventArgs e)
        {
            int paymentTypeId = Int32.Parse((sender as LinkButton).CommandArgument);
            Response DeletePaymentType = PaymentTypeController.DeletePaymentType(paymentTypeId);
            if (!DeletePaymentType.successStatus)
            {
                ErrorMessage.print(this, DeletePaymentType.message);
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void btnInsertPaymentType_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPaymentType.aspx");
        }
    }
}