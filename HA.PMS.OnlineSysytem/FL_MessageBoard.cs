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
    
    public partial class FL_MessageBoard
    {
        public int MessageBoardID { get; set; }
        public string MessAgeContent { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateEmpLoyee { get; set; }
        public Nullable<int> EmpLoyeeID { get; set; }
        public Nullable<int> Parent { get; set; }
        public string CreateEmpLoyeeName { get; set; }
    }
}
