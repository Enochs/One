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
    
    public partial class sys_WorkReport
    {
        public int WorkID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> CreateNum { get; set; }
        public Nullable<int> InviteNum { get; set; }
        public Nullable<int> LoseInviteNum { get; set; }
        public Nullable<int> InviteSuccessNum { get; set; }
        public Nullable<int> OrderNum { get; set; }
        public Nullable<int> LoseOrderNum { get; set; }
        public Nullable<int> OrderSuccessNum { get; set; }
        public Nullable<int> QuotedCheckNum { get; set; }
        public Nullable<decimal> FinishAmount { get; set; }
        public Nullable<decimal> OrderAmount { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public string Remark { get; set; }
        public Nullable<int> InviteSumTotal { get; set; }
        public Nullable<int> OrderSumTotal { get; set; }
    }
}