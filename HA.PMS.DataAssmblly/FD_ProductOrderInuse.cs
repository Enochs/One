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
    
    public partial class FD_ProductOrderInuse
    {
        public string OrderCoder { get; set; }
        public int InuseId { get; set; }
        public string CustomerName { get; set; }
        public string Planner { get; set; }
        public string WorkersPerson { get; set; }
        public string WinShop { get; set; }
        public Nullable<System.DateTime> PartyDate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}