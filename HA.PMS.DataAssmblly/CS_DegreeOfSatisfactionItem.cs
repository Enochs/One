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
    
    public partial class CS_DegreeOfSatisfactionItem
    {
        public CS_DegreeOfSatisfactionItem()
        {
            this.CS_DegreeOfSatisfactionContent = new HashSet<CS_DegreeOfSatisfactionContent>();
        }
    
        public int ItemKey { get; set; }
        public string Title { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<CS_DegreeOfSatisfactionContent> CS_DegreeOfSatisfactionContent { get; set; }
    }
}
