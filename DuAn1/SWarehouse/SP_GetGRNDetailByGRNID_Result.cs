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
    
    public partial class SP_GetGRNDetailByGRNID_Result
    {
        public int Product_ID { get; set; }
        public string ProductName { get; set; }
        public int Supplier_id { get; set; }
        public string SupplierName { get; set; }
        public Nullable<int> Quantity_of_request { get; set; }
        public Nullable<int> Actual_Amount { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}
