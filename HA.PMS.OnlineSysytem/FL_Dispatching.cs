//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HA.PMS.OnlineSysytem
{
    using System;
    using System.Collections.Generic;
    
    public partial class FL_Dispatching
    {
        public FL_Dispatching()
        {
            this.FL_ProductforDispatching = new HashSet<FL_ProductforDispatching>();
        }
    
        public int DispatchingID { get; set; }
        public int CelebrationID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsBegin { get; set; }
        public Nullable<bool> Isover { get; set; }
        public Nullable<bool> IsAppraise { get; set; }
        public Nullable<bool> IsCost { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> QuotedID { get; set; }
        public string OrderCoder { get; set; }
        public Nullable<int> ParentDispatchingID { get; set; }
        public Nullable<int> QuotedEmpLoyee { get; set; }
        public Nullable<bool> AppraiseOver { get; set; }
        public string WorkReport { get; set; }
    
        public virtual ICollection<FL_ProductforDispatching> FL_ProductforDispatching { get; set; }
    }
}