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
    
    public partial class FL_CelebrationProductItem
    {
        public int ItemIndex { get; set; }
        public int CelebrationID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> ParentCategoryID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> IsChecks { get; set; }
        public string ChecksContent { get; set; }
        public string ChecksTitle { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Unit { get; set; }
        public string Specifications { get; set; }
        public string ServiceContent { get; set; }
        public string Requirement { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<System.DateTime> PlannedCompletionTime { get; set; }
        public Nullable<int> RowType { get; set; }
        public Nullable<int> ItemLevel { get; set; }
        public Nullable<int> ParentQuotedID { get; set; }
        public Nullable<int> ParentCelebrationID { get; set; }
        public string ParentItemIndex { get; set; }
        public Nullable<int> QuotedID { get; set; }
        public string ParentCategoryName { get; set; }
        public Nullable<bool> NewAdd { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<decimal> ItemAmount { get; set; }
        public Nullable<decimal> ItemSaleAmount { get; set; }
        public Nullable<int> Productproperty { get; set; }
        public string SupplierName { get; set; }
        public string Classification { get; set; }
    
        public virtual FL_Celebration FL_Celebration { get; set; }
    }
}
