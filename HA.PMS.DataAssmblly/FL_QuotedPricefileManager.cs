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
    
    public partial class FL_QuotedPricefileManager
    {
        public int FileID { get; set; }
        public int QuotedID { get; set; }
        public string Filename { get; set; }
        public string FileAddress { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<int> KindID { get; set; }
        public Nullable<int> Type { get; set; }
    
        public virtual FL_QuotedPrice FL_QuotedPrice { get; set; }
    }
}
