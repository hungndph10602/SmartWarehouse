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
    
    public partial class STAFF_STORE
    {
        public int Store_id { get; set; }
        public int Staff_id { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual STAFF STAFF { get; set; }
        public virtual STORE STORE { get; set; }
    }
}