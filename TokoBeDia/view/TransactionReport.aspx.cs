using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TokoBeDia.controller;

namespace TokoBeDia.view
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String)Session["role"] != "admin")
            {
                Response.Redirect("Homepage.aspx");
            }

            TransactionReports reports = new TransactionReports();
            TransactionReportViewer.ReportSource = reports;
            reports.SetDataSource(GenerateData(TransactionController.GetTransactions()));
        }

        private TransactionDataSet GenerateData(List<HeaderTransaction> transactionList)
        {
            TransactionDataSet dataset = new TransactionDataSet();
            var headerTransactionTable = dataset.HeaderTransaction;
            var detailTransactionTable = dataset.DetailTransaction;

            foreach (var ht in transactionList)
            {
                var headerTransactionRow = headerTransactionTable.NewRow();
                headerTransactionRow["Id"] = ht.Id;
                headerTransactionRow["Username"] = ht.User.Name;
                headerTransactionRow["PaymentType"] = ht.PaymentType.Name;
                headerTransactionRow["Date"] = ht.Date;
                headerTransactionTable.Rows.Add(headerTransactionRow);

                foreach (var dt in ht.DetailTransactions)
                {
                    var detailTransactionRow = detailTransactionTable.NewRow();
                    detailTransactionRow["TransactionID"] = ht.Id;
                    detailTransactionRow["ProductName"] = dt.Product.Name;
                    detailTransactionRow["ProductPrice"] = dt.Product.Price;
                    detailTransactionRow["Quantity"] = dt.Quantity;
                    detailTransactionTable.Rows.Add(detailTransactionRow);
                }
            }
            return dataset;
        }
    }
}