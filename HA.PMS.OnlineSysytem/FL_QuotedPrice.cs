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
    
    public partial class FL_QuotedPrice
    {
        public FL_QuotedPrice()
        {
            this.FL_QuotedCollectionsPlan = new HashSet<FL_QuotedCollectionsPlan>();
        }
    
        public int QuotedID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string OrderCoder { get; set; }
        public bool IsDelete { get; set; }
        public string CategoryName { get; set; }
        public Nullable<bool> IsChecks { get; set; }
        public string ChecksContent { get; set; }
        public string ChecksTitle { get; set; }
        public Nullable<int> EmpLoyeeID { get; set; }
        public Nullable<int> CheckState { get; set; }
        public Nullable<int> ChecksEmployee { get; set; }
        public Nullable<int> Dispatching { get; set; }
        public Nullable<decimal> EarnestMoney { get; set; }
        public Nullable<decimal> AggregateAmount { get; set; }
        public Nullable<decimal> RealAmount { get; set; }
        public Nullable<decimal> FinishAmount { get; set; }
        public Nullable<decimal> Noneyremaining { get; set; }
        public Nullable<bool> IsFirstCreate { get; set; }
        public Nullable<int> ParentQuotedID { get; set; }
        public string Remark { get; set; }
        public Nullable<int> IsDispatching { get; set; }
        public Nullable<int> QuotedType { get; set; }
        public Nullable<int> QuotedKind { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<bool> HaveFile { get; set; }
        public string QuotedTitle { get; set; }
        public Nullable<decimal> AddedAmount { get; set; }
        public Nullable<decimal> LessenedAmount { get; set; }
        public Nullable<bool> StarDispatching { get; set; }
        public Nullable<int> FileCheck { get; set; }
        public string PakegName { get; set; }
        public string PakegTyper { get; set; }
        public Nullable<System.DateTime> NextFlowDate { get; set; }
        public Nullable<int> SaleEmployee { get; set; }
        public Nullable<bool> FlowerCheck { get; set; }
        public Nullable<bool> MoneyCheck { get; set; }
        public Nullable<bool> BuyCheck { get; set; }
        public Nullable<int> FlowerCheckEmployee { get; set; }
        public Nullable<int> MoneyCheckEmployee { get; set; }
        public Nullable<int> BuyCheckEmployee { get; set; }
        public Nullable<int> LoseCheckEmployee { get; set; }
        public string LoseNode { get; set; }
        public Nullable<bool> LoseCheck { get; set; }
        public Nullable<int> MissionManagerEmployee { get; set; }
    
        public virtual ICollection<FL_QuotedCollectionsPlan> FL_QuotedCollectionsPlan { get; set; }
    }
}
