using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PaymentIntegratorPortal.Models;
using System.Web.Http.Tracing;
using System.Text;
using PaymentIntegrator;

namespace PaymentIntegratorPortal.Controllers
{
    public class PaymentsController : ApiController
    {
        [HttpGet]
        [Route("api/Payments/Getpayment")]
        public DataTable Getpayment()
        {
            DataTable dt = new DataTable();
            LogTraceWriter traceWriter = new LogTraceWriter();
            SqlConnection conn = new SqlConnection();

            try
            {
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Getpayment....");

                conn.ConnectionString = ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PSGetPayments";

                cmd.Connection = conn;

                SqlDataAdapter db = new SqlDataAdapter(cmd);
                db.Fill(dt);
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Getpayment successful....");

            }
            catch (Exception ex)
            {
                traceWriter.Trace(Request, "0", TraceLevel.Error, "{0}", "Getpayment...." + ex.Message.ToString());
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
            return dt;

        }

        [HttpPost]
        [Route("api/Payments/Pay")]
        public DataTable Pay(paymentdetails s)
        {
            DataTable dt = new DataTable();
            LogTraceWriter traceWriter = new LogTraceWriter();
            SqlConnection conn = new SqlConnection();
            StringBuilder str = new StringBuilder();
            try
            {
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Pay....");


                str.Append("CardCategories:" + s.cardcategory + ",");
                str.Append("Status:" + s.status + ",");
                str.Append("Amount:" + s.Amount + ",");
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Input sent...." + str.ToString());

                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PSInsUpdPayments";

                cmd.Connection = conn;


                SqlParameter T = new SqlParameter("@flag", SqlDbType.VarChar);
                T.Value = s.flag;
                cmd.Parameters.Add(T);

                SqlParameter q = new SqlParameter("@CardCategories", SqlDbType.VarChar, 50);
                q.Value = s.cardcategory;
                cmd.Parameters.Add(q);

                SqlParameter e = new SqlParameter("@Status", SqlDbType.VarChar, 50);
                e.Value = s.status;
                cmd.Parameters.Add(e);

                SqlParameter q1 = new SqlParameter("@Amount", SqlDbType.Decimal);
                q1.Value = s.Amount;
                cmd.Parameters.Add(q1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Pay successful....");

            }
            catch (Exception ex)
            {
                traceWriter.Trace(Request, "0", TraceLevel.Error, "{0}", "Pay...." + ex.Message.ToString());
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
            return (dt);


        }

        //[HttpGet]
        //[Route("api/Payment/PostilionTest")]
        //public Messages.Core.Message.Default PostilionTest()
        //{
        //    Class1 c = new Class1();
        //    return c.GetPositionMssg();
        //}


        [HttpGet]
        [Route("api/Payments/Getpayments")]
        public DataTable Getpayments()
        {
            DataTable dt = new DataTable();
            LogTraceWriter traceWriter = new LogTraceWriter();
            SqlConnection conn = new SqlConnection();
            StringBuilder str = new StringBuilder();

            try
            {
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Getpayments....");


                conn.ConnectionString = ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PSGetPaymentdetails";

                cmd.Connection = conn;


                SqlDataAdapter db = new SqlDataAdapter(cmd);
                db.Fill(dt);
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Getpayments successful....");

            }
            catch (Exception ex)
            {
                traceWriter.Trace(Request, "0", TraceLevel.Error, "{0}", "Getpayments...." + ex.Message.ToString());
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
            return dt;

        }

        [HttpPost]
        [Route("api/Payments/Paydetails")]
        public DataTable Paydetails(paymentdetails s)
        {
            DataTable dt = new DataTable();
            LogTraceWriter traceWriter = new LogTraceWriter();
            SqlConnection conn = new SqlConnection();
            StringBuilder str = new StringBuilder();

            try
            {
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Paydetails....");

                str.Append("PaymentId:" + s.PaymentId + ",");
                str.Append("CardCategories:" + s.cardcategory + ",");
                str.Append("Status:" + s.status + ",");
                str.Append("TransactionType:" + s.transactiontype + ",");
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Input sent...." + str.ToString());

                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PSInsUpdPaymentDetails";

                cmd.Connection = conn;


                SqlParameter T = new SqlParameter("@flag", SqlDbType.VarChar);
                T.Value = s.flag;
                cmd.Parameters.Add(T);

                SqlParameter q = new SqlParameter("@PaymentId", SqlDbType.Int);
                q.Value = s.PaymentId;
                cmd.Parameters.Add(q);

                SqlParameter e = new SqlParameter("@CardCategories", SqlDbType.VarChar);
                e.Value = s.cardcategory;
                cmd.Parameters.Add(e);

                SqlParameter q1 = new SqlParameter("@Status", SqlDbType.VarChar, 50);
                q1.Value = s.status;
                cmd.Parameters.Add(q1);

                SqlParameter qq = new SqlParameter("@GatewayId", SqlDbType.Int);
                qq.Value = s.gatewayid;
                cmd.Parameters.Add(qq);

                SqlParameter ss = new SqlParameter("@TransactionType", SqlDbType.VarChar, 50);
                ss.Value = s.transactiontype;
                cmd.Parameters.Add(ss);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "Paydetails successful....");

            }
            catch (Exception ex)
            {
                traceWriter.Trace(Request, "0", TraceLevel.Error, "{0}", "Paydetails...." + ex.Message.ToString());
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(conn);
            }
            return (dt);

            //Verify Passwordotp

        }


        [HttpPost]
        [Route("api/Payments/MakePayment")]
        public DataTable MakePayment(TripPayment t)
        {

            DataTable dt = new DataTable();
            LogTraceWriter traceWriter = new LogTraceWriter();
            SqlCommand cmd = new SqlCommand();

            {
                SqlConnection conn = new SqlConnection();
                traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "MakePayment....");
                StringBuilder str = new StringBuilder();
                str.Append("@BNo" + t.BNo + ",");
                str.Append("@Amount" + t.Amount + ",");
               // str.Append("@GatewayTransId" + t.GatewayTransId + ",");
                str.Append("@TransDate" + t.PaymentDate + ",");
                str.Append("@AppUserId" + t.AppUserId + ",");

                //traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "MakePayment Input sent...." + str.ToString());

                //if (dt.Rows.Count > 0)
                //    traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "MakePayment Output...." + dt.Rows[0].ToString());
                //else
                //    traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "MakePayment Output....BookedHistory ");
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PSInsUpdPayments";
                cmd.Connection = conn;


                SqlParameter f = new SqlParameter("@flag", SqlDbType.VarChar);
                f.Value = t.flag;
                cmd.Parameters.Add(f);

                SqlParameter s = new SqlParameter("@Id", SqlDbType.Int);
                s.Value = t.Id;
                cmd.Parameters.Add(s);
               
                SqlParameter am = new SqlParameter("@Amount", SqlDbType.Decimal);
                am.Value = t.Amount;
                cmd.Parameters.Add(am);

                SqlParameter si = new SqlParameter("@StatusId", SqlDbType.Int);
                si.Value = t.StatusId;
                cmd.Parameters.Add(si);

                SqlParameter ss = new SqlParameter("@Status", SqlDbType.VarChar,50);
                ss.Value = t.Status;
                cmd.Parameters.Add(ss);

                SqlParameter gti = new SqlParameter("@GatewayId", SqlDbType.VarChar);
                gti.Value = t.GatewayId;
                cmd.Parameters.Add(gti);

                SqlParameter td = new SqlParameter("@PaymentDate", SqlDbType.DateTime);
                td.Value = t.PaymentDate;
                cmd.Parameters.Add(td);

                SqlParameter pt = new SqlParameter("@PaymentTime", SqlDbType.DateTime);
                pt.Value = t.PaymentTime;
                cmd.Parameters.Add(pt);   

                SqlParameter ci = new SqlParameter("@CustAccountId", SqlDbType.Int);
                ci.Value = t.CustAccountId;
                cmd.Parameters.Add(ci);               

                SqlParameter un = new SqlParameter("@UserName", SqlDbType.VarChar,50);
                un.Value = t.UserName;
                cmd.Parameters.Add(un);

                SqlParameter bn = new SqlParameter("@BankName", SqlDbType.VarChar,50);
                bn.Value = t.BankName;
                cmd.Parameters.Add(bn);

                SqlParameter ch = new SqlParameter("@CardHolderName", SqlDbType.VarChar,50);
                ch.Value = t.CardHolderName;
                cmd.Parameters.Add(ch);

                SqlParameter cn = new SqlParameter("@CardNumber", SqlDbType.VarChar,50);
                cn.Value = t.CardNumber;
                cmd.Parameters.Add(cn);

                SqlParameter em = new SqlParameter("@ExpMonth", SqlDbType.Int);
                em.Value = t.ExpMonth;
                cmd.Parameters.Add(em);

                SqlParameter ey = new SqlParameter("@ExpYear", SqlDbType.Int);
                ey.Value = t.ExpYear;
                cmd.Parameters.Add(ey);



                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                string GuiId = new Guid().ToString();

                //return 1;


                //Payengine.Controllers.Payengine e = new Payengine.Controllers.Payengine();
                //string transId = e.ProcessPayment();

                //if (dt.Rows.Count >= 0)
                //{


                //    //var GatewayTransId = dt.Rows[0]["GatewayTransId"].ToString();
                //    if (transId != "")
                //    {
                //        f.Value = "U";
                //        s.Value = dt.Rows[0]["Id"].ToString();
                //        var GateTransId = transId;

                //        gti.Value = transId;
                //        dt = new DataTable();
                //        da.Fill(dt);
                //    }
                //}
                //1) insert the details with status as new/inprogess into trippayments table

                //2) once the id is obtained call the payment gateway

                //3) get the success/failure status from gateway

                //4) update the table again with status and gateway id

                //5) let the customer know the status

            }


            return dt;
        }

    }
}
