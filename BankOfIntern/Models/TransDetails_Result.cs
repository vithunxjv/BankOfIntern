//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankOfIntern.Models
{
    using System;
    
    public partial class TransDetails_Result
    {
        public decimal TransactionID { get; set; }
        public Nullable<decimal> ToAccNo { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> TransDate { get; set; }
        public Nullable<System.TimeSpan> TransTime { get; set; }
        public int AccBalance { get; set; }
    }
}
