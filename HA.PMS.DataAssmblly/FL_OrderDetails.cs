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
    
    public partial class FL_OrderDetails
    {
        public int DetailID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<System.DateTime> FollowDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string FollowContent { get; set; }
        public string LoseContent { get; set; }
        public Nullable<System.DateTime> LoseDate { get; set; }
        public Nullable<int> CreateEmpLoyee { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string StateName { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<System.DateTime> NextPlanDate { get; set; }
    
        public virtual FL_Order FL_Order { get; set; }
    }
}
