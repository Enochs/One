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
    
    public partial class CS_Complain
    {
        public int ComplainID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string ComplainContent { get; set; }
        public Nullable<System.DateTime> ComplainDate { get; set; }
        public string ComplainRemark { get; set; }
        public string ReturnContent { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<int> ComplainEmployeeId { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    
        public virtual FL_Customers FL_Customers { get; set; }
    }
}
