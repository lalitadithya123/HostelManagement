//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HostelManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HostelTransaction
    {
        public int id { get; set; }
        public string bid { get; set; }
        public System.DateTime dateOfPay { get; set; }
        public int paymentTypeId { get; set; }
        public int head { get; set; }
        public string receipt { get; set; }
        public string bankName { get; set; }
    
        public virtual PaymentType PaymentType { get; set; }
        public virtual Student Student { get; set; }
        public virtual HostelCharge HostelCharge { get; set; }
    }
}
