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
    
    public partial class FD_Category
    {
        public FD_Category()
        {
            this.FD_CelebrationPackageMakeQuotedPrice = new HashSet<FD_CelebrationPackageMakeQuotedPrice>();
            this.FD_Product = new HashSet<FD_Product>();
        }
    
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int ParentID { get; set; }
        public string SortOrder { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> Productproperty { get; set; }
        public Nullable<bool> IsShow { get; set; }
    
        public virtual ICollection<FD_CelebrationPackageMakeQuotedPrice> FD_CelebrationPackageMakeQuotedPrice { get; set; }
        public virtual ICollection<FD_Product> FD_Product { get; set; }
    }
}
