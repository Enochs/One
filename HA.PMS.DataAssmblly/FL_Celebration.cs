//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HA.PMS.DataAssmblly
{
    using System;
    using System.Collections.Generic;
    
    public partial class FL_Celebration
    {
        public FL_Celebration()
        {
            this.FL_CelebrationProductItem = new HashSet<FL_CelebrationProductItem>();
            this.FL_Dispatching = new HashSet<FL_Dispatching>();
        }
    
        public int CelebrationID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public Nullable<int> QuotedID { get; set; }
        public string OrderCoder { get; set; }
        public Nullable<int> ParentCelebrationID { get; set; }
        public Nullable<int> QuotedEmpLoyee { get; set; }
    
        public virtual ICollection<FL_CelebrationProductItem> FL_CelebrationProductItem { get; set; }
        public virtual ICollection<FL_Dispatching> FL_Dispatching { get; set; }
        public virtual FL_Order FL_Order { get; set; }
        public virtual FL_Customers FL_Customers { get; set; }
    }
}
