using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaymentIntegratorPortal.Models
{
    public class Registrations
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int StatusId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Createdby { get; set; }
        public string flag { get; set; }
    }
    public class paymentdetails
    {
        public string flag { get; set; }
        public int Id { get; set; }
        public int PaymentId { get; set; }
        public string cardcategory { get; set; }
        public string status { get; set; }
        public int gatewayid { get; set; }
        public string transactiontype { get; set; }


        public string servicetype { get; set; }

        public int Transactionid { get; set; }
        public string Transaction_Number { get; set; }
        public int Amount { get; set; }
        public int Paymentmode { get; set; }

        public int Pnr_Id { get; set; }
        public string Pnr_No { get; set; }
        public string Gateway_transId { get; set; }
        public int TransactionStatus { get; set; }
    }
    public class TripPayment
    {
        public string flag { get; set; }
        public int Id { get; set; }
        public int BNo { get; set; }
        public decimal Amount { get; set; }
        public int StatusId { get; set; }
        public int GatewayId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? PaymentTime { get; set; }
        public int PaymentModeId { get; set; }
        public string Comments { get; set; }
        public int CustAccountId { get; set; }
        public int AppUserId { get; set; }
        public string UserName { get; set; }
        public string BankName { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string Status { get; set; }
    }
}

    

