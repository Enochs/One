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
    
    public partial class FL_CategoryForQuotedPrice
    {
        public int PriceKey { get; set; }
        public Nullable<int> QuotedID { get; set; }
        public string Unit { get; set; }
        public string ServiceContent { get; set; }
        public string Requirement { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public string Remark { get; set; }
        public bool IsDelete { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Specifications { get; set; }
        public Nullable<bool> IsChange { get; set; }
        public Nullable<bool> IsSvae { get; set; }
        public Nullable<int> ChangeID { get; set; }
    
        public virtual FL_QuotedPrice FL_QuotedPrice { get; set; }
    }
}
