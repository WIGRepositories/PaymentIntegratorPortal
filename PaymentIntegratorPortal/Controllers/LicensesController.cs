using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace PaymentIntegratorPortal.Controllers
{
    public class LicensesController : ApiController
    {
        [HttpGet]
        [Route("api/Licenses/getReferenceId")]
        public DataTable getReferenceId(string ReferenceId)
        {
            DataTable Tbl = new DataTable();

            //LogTraceWriter traceWriter = new LogTraceWriter();
            //traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "GetTypesByGroupId credentials....");

            //connect to database
            SqlConnection conn = new SqlConnection();
            try
            {


                //connetionString="Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
                conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PayInt"].ToString();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ValReferenceId";
                cmd.Connection = conn;

                SqlParameter Gid = new SqlParameter();
                Gid.ParameterName = "@ReferenceId";
                Gid.SqlDbType = SqlDbType.VarChar;
                Gid.Value = ReferenceId;
                cmd.Parameters.Add(Gid);

                DataSet ds = new DataSet();
                SqlDataAdapter db = new SqlDataAdapter(cmd);
                db.Fill(ds);
                Tbl = ds.Tables[0];
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //prepare a file
            StringBuilder str = new StringBuilder();

            str.Append(string.Format("test\n{0}", ReferenceId.ToString()));



            //traceWriter.Trace(Request, "0", TraceLevel.Info, "{0}", "GetTypesByGroupId Credentials completed.");
            // int found = 0;
            return Tbl;
        }

    }
}
