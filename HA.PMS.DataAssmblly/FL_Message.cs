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
    
    public partial class FL_Message
    {
        public int MessageID { get; set; }
        public string MessAgeTitle { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> MissionID { get; set; }
        public string Message { get; set; }
        public bool IsLook { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string KeyWords { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public string CreateEmployeename { get; set; }
    }
}
