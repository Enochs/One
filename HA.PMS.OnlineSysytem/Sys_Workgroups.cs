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
    
    public partial class Sys_Workgroups
    {
        public Sys_Workgroups()
        {
            this.Sys_Employee = new HashSet<Sys_Employee>();
        }
    
        public int GroupID { get; set; }
        public string GroupName { get; set; }
    
        public virtual ICollection<Sys_Employee> Sys_Employee { get; set; }
    }
}
