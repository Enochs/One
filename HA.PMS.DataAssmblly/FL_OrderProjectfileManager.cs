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
    
    public partial class FL_OrderProjectfileManager
    {
        public int FileID { get; set; }
        public string FileURI { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int OrderID { get; set; }
        public int EmpLoyeeID { get; set; }
        public string CreateEmpLoyeeID { get; set; }
    
        public virtual FL_Order FL_Order { get; set; }
    }
}
