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
    
    public partial class FL_DispatchingEmployeeManager
    {
        public int DeJey { get; set; }
        public int DispatchingID { get; set; }
        public string TelPhone { get; set; }
        public string EmployeeType { get; set; }
        public string EmployeeName { get; set; }
        public string Bulding { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateEmployee { get; set; }
        public Nullable<int> CreateEmpoyeeType { get; set; }
        public Nullable<int> DispachingType { get; set; }
        public Nullable<int> SuppName { get; set; }
        public string FinishAmount { get; set; }
    
        public virtual FL_Dispatching FL_Dispatching { get; set; }
    }
}
