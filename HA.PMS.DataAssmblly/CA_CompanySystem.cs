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
    
    public partial class CA_CompanySystem
    {
        public int SystemId { get; set; }
        public string SystemTitle { get; set; }
        public string SystemURL { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> CreateEmployee { get; set; }
        public string SystemPureRoute { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
