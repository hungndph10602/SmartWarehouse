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
    
    public partial class GOODS_RECEIVED_NOTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GOODS_RECEIVED_NOTE()
        {
            this.GOODS_RECEIVED_NOTE_DETAILS = new HashSet<GOODS_RECEIVED_NOTE_DETAILS>();
            this.SHIPMENT_OF_GOODS = new HashSet<SHIPMENT_OF_GOODS>();
        }
    
        public int ID { get; set; }
        public int Warehouse_ID { get; set; }
        public int Account_ID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<decimal> MoneyPaid { get; set; }
        public Nullable<decimal> AmountOwn { get; set; }
        public string MoreInfo { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GOODS_RECEIVED_NOTE_DETAILS> GOODS_RECEIVED_NOTE_DETAILS { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENT_OF_GOODS> SHIPMENT_OF_GOODS { get; set; }
    }
}
