//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SWarehouse
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_DETAILS
    {
        public int Product_ID { get; set; }
        public int Order_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual ORDER ORDER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}