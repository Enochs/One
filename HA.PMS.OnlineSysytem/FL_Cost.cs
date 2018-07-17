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
    
    public partial class FL_Cost
    {
        public FL_Cost()
        {
            this.FL_CostforEmpLoyee = new HashSet<FL_CostforEmpLoyee>();
            this.FL_OrderfinalCost = new HashSet<FL_OrderfinalCost>();
        }
    
        public int CostKey { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<decimal> ProfitMargin { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateEmpLoyee { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<bool> IsLock { get; set; }
    
        public virtual ICollection<FL_CostforEmpLoyee> FL_CostforEmpLoyee { get; set; }
        public virtual ICollection<FL_OrderfinalCost> FL_OrderfinalCost { get; set; }
    }
}
