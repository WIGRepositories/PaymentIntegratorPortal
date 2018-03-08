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
using System.Net.Mail;

namespace PaymentIntegratorPortal.Controllers
{
    public class RegistrationController : ApiController
    {
        [HttpGet]
        [Route("api/Registration/GetRegistrations")]
        public DataTable GetRegistrations()
        {

            DataTable tbl = new DataTable();

            string constr = ConfigurationManager.ConnectionStrings["PayInt"].ToString();

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = constr;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetRegistrations";
            cmd.Connection = con;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(tbl);
            return tbl;
        }


        [HttpPost]
        [Route("api/Registration/RegistrationDetails")]
        public DataTable RegistrationDetails(Registrations us)
        {
            DataTable tb = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["PayInt"].ToString();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsUpdDelRegistrations";

                SqlParameter id = new SqlParameter("Id", SqlDbType.Int);
                id.Value = us.Id;
                cmd.Parameters.Add(id);

                SqlParameter cn = new SqlParameter("Name", SqlDbType.VarChar, 50);
                cn.Value = us.Name;
                cmd.Parameters.Add(cn);

                SqlParameter cr = new SqlParameter("Company", SqlDbType.VarChar, 50);
                cr.Value = us.Company;
                cmd.Parameters.Add(cr);

                SqlParameter ed = new SqlParameter("EmailId", SqlDbType.VarChar, 50);
                ed.Value = us.Email;
                cmd.Parameters.Add(ed);

                SqlParameter tt = new SqlParameter("Country", SqlDbType.VarChar, 50);
                tt.Value = us.Country;
                cmd.Parameters.Add(tt);

                SqlParameter cp = new SqlParameter("MobileNumber", SqlDbType.VarChar,20);
                cp.Value = us.MobileNumber;
                cmd.Parameters.Add(cp);

                SqlParameter cy = new SqlParameter("Password", SqlDbType.VarChar,50);
                cy.Value = us.Password;
                cmd.Parameters.Add(cy);


                SqlParameter zc = new SqlParameter("Address", SqlDbType.VarChar,50);
                zc.Value = us.Address;
                cmd.Parameters.Add(zc);


                SqlParameter st = new SqlParameter("StatusId", SqlDbType.Int);
                st.Value = us.StatusId;
                cmd.Parameters.Add(st);


                //SqlParameter ss = new SqlParameter("CreatedOn", SqlDbType.VarChar);
                //ss.Value = us.CreatedOn;
                //cmd.Parameters.Add(ss);


                SqlParameter fs = new SqlParameter("Createdby", SqlDbType.VarChar,50);
                fs.Value = us.Createdby;
                cmd.Parameters.Add(fs);

                SqlParameter fl = new SqlParameter("flag", SqlDbType.VarChar);
                fl.Value = us.flag;
                cmd.Parameters.Add(fl);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tb);

                #region password otp
                string name = tb.Rows[0]["Name"].ToString();
                string mobile = tb.Rows[0]["Mobilenumber"].ToString();
                string company = tb.Rows[0]["company"].ToString();
                string ctry = tb.Rows[0]["Country"].ToString();
                string add = tb.Rows[0]["Address"].ToString();
                string Reference = tb.Rows[0]["ReferenceId"].ToString();
                
                
                if (name != null)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        string emailserver = System.Configuration.ConfigurationManager.AppSettings["emailserver"].ToString();

                        string username = System.Configuration.ConfigurationManager.AppSettings["username"].ToString();
                        string pwd = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                        string fromaddress = System.Configuration.ConfigurationManager.AppSettings["fromaddress"].ToString();
                        string port = System.Configuration.ConfigurationManager.AppSettings["port"].ToString();

                        SmtpClient SmtpServer = new SmtpClient(emailserver);

                        mail.From = new MailAddress(fromaddress);
                        mail.To.Add(fromaddress);                        
                        mail.Subject = "Payment Intetgrator-Registration Request ";
                        mail.IsBodyHtml = true;

                        string verifcodeMail = @"<table>
                                                        <tr>
                                                            <td>
                                                                <h2>New User Registration Request</h2>
                                                                <table width=\""760\"" align=\""center\"">
                                                                    <tbody style='background-color:#F0F8FF;'>
                                                                        <tr>
                                                                            <td style=\""font-family:'Zurich BT',Arial,Helvetica,sans-serif;font-size:15px;text-align:left;line-height:normal;background-color:#F0F8FF;\"" >
<div style='padding:10px;border:#0000FF solid 2px;'>    <br /><br />
                                                                             
                                                        <h3>" + name + @" </h3>
                                                        <h3>" + mobile + @" </h3>  
                                                        Company:<h3>" + company + @" </h3>  
                                                        Country :<h3>" + ctry + @" </h3>  
                                                        Address :<h3>" + add + @" </h3>
                                                        Reference Id No:<h3>" + Reference + @" </h3>
                                                        If you didn't make this request, <a href='http://154.120.237.198:52800'>click here</a> to cancel.

                                                                                <br/>
                                                                                <br/>             
                                                                       
                                                                               
</div>
                                                                            </td>
                                                                        </tr>

                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>

                                                    </table>";


                        mail.Body = verifcodeMail;
                        //SmtpServer.Port = 465;
                        //SmtpServer.Port = 587;
                        SmtpServer.Port = Convert.ToInt32(port);
                        SmtpServer.UseDefaultCredentials = false;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(username, pwd);
                        SmtpServer.EnableSsl = true;
                        //SmtpServer.TargetName = "STARTTLS/smtp.gmail.com";
                        SmtpServer.Send(mail);
                        //Status = 1;

                    }





                    catch (Exception ex)
                    {
                        //throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
                    }
                    finally
                    {
                        conn.Close();
                    }

                #endregion password otp

                }

                #region password otp
              

                if (name != null)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        string emailserver = System.Configuration.ConfigurationManager.AppSettings["emailserver"].ToString();

                        string username = System.Configuration.ConfigurationManager.AppSettings["username"].ToString();
                        string pwd = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
                        string fromaddress = System.Configuration.ConfigurationManager.AppSettings["fromaddress"].ToString();
                        string port = System.Configuration.ConfigurationManager.AppSettings["port"].ToString();

                        SmtpClient SmtpServer = new SmtpClient(emailserver);

                        mail.From = new MailAddress(fromaddress);
                        mail.To.Add(us.Email);
                        mail.Subject = "Payment Integrator - Registration ";
                        mail.IsBodyHtml = true;

                        string verifcodeMail = @"<table>
                                                        <tr>
                                                            <td>
                                                                <h2>Thank you for registering with Payment Integrator</h2>
                                                                <table width=\""760\"" align=\""center\"">
                                                                    <tbody style='background-color:#F0F8FF;'>
                                                                        <tr>
                                                                            <td style=\""font-family:'Zurich BT',Arial,Helvetica,sans-serif;font-size:15px;background-color:#F0F8FF;\"" >
<div style='padding:10px;border:#0000FF solid 2px;'>   
                                                                             
                                                       
                                                          Hello :<h3>"  + name + @"</h3> 
                                                         Company:<h3>" + company + @" </h3>  
                                                         Country :<h3>" + ctry + @" </h3>  
                                                       
                                                        Your Reference Id No:<h3>" + Reference + @" </h3>
                                                        If you didn't make this request, <a href='http://154.120.237.198:52800'>click here</a> to cancel.

                                                                                <br/>
                                                                                <br/>             
                                                                       <h3>Our Team Will Contact you soon.<h3/>
                                                                                Warm regards,<br>
                                                                                Payment Integrator, Client Services Team<br/><br />
</div>
                                                                            </td>
                                                                        </tr>

                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>

                                                    </table>";


                        mail.Body = verifcodeMail;
                        //SmtpServer.Port = 465;
                        //SmtpServer.Port = 587;
                        SmtpServer.Port = Convert.ToInt32(port);
                        SmtpServer.UseDefaultCredentials = false;

                        SmtpServer.Credentials = new System.Net.NetworkCredential(username, pwd);
                        SmtpServer.EnableSsl = true;
                        //SmtpServer.TargetName = "STARTTLS/smtp.gmail.com";
                        SmtpServer.Send(mail);
                        //Status = 1;

                    }





                    catch (Exception ex)
                    {
                        //throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
                    }
                    finally
                    {
                        conn.Close();
                    }

                #endregion password otp
                }

            }
            catch (Exception ex)
            {
                //throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message));
            }
            finally
            {
                conn.Close();
            }

            return tb;





        }
    }
}
        

