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
    
    public partial class GOODS_DELIVERY_NOTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GOODS_DELIVERY_NOTE()
        {
            this.GOODS_DELIVERY_NOTE_DETAILS = new HashSet<GOODS_DELIVERY_NOTE_DETAILS>();
        }
    
        public int ID { get; set; }
        public int Warehouse_ID { get; set; }
        public int Account_ID { get; set; }
        public int Request_ID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string MoreInfo { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual DELIVERY_REQUESTS DELIVERY_REQUESTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOODS_DELIVERY_NOTE_DETAILS> GOODS_DELIVERY_NOTE_DETAILS { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
