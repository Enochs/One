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
    
    public partial class Sys_Employee
    {
        public Sys_Employee()
        {
            this.FD_PPTWarehouse = new HashSet<FD_PPTWarehouse>();
            this.FL_FinishTargetSum = new HashSet<FL_FinishTargetSum>();
            this.Sys_ClientManager = new HashSet<Sys_ClientManager>();
            this.Sys_EmpLoyeeHigherups = new HashSet<Sys_EmpLoyeeHigherups>();
        }
    
        public int EmployeeID { get; set; }
        public Nullable<int> JobID { get; set; }
        public int DepartmentID { get; set; }
        public int GroupID { get; set; }
        public int EmployeeTypeID { get; set; }
        public string EmployeeName { get; set; }
        public string PassWord { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> LoginYear { get; set; }
        public Nullable<int> LoginMonth { get; set; }
        public Nullable<int> LoginDay { get; set; }
        public Nullable<int> Sex { get; set; }
        public System.DateTime BornDate { get; set; }
        public bool IsClose { get; set; }
        public string Employeekey { get; set; }
        public string CellPhone { get; set; }
        public string TelPhone { get; set; }
        public string QQ { get; set; }
        public string Email { get; set; }
        public Nullable<int> PlanChecks { get; set; }
        public Nullable<int> Coach { get; set; }
        public Nullable<int> Look { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsLoading { get; set; }
        public string LoginName { get; set; }
        public string ImageURL { get; set; }
        public string UploadImageName { get; set; }
        public string CurrentLocation { get; set; }
        public Nullable<int> CreateEmployee { get; set; }
        public string CardId { get; set; }
        public string WeiXin { get; set; }
        public string WeiBo { get; set; }
        public string BankCard { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
        public Nullable<System.DateTime> PosiTime { get; set; }
        public Nullable<int> WorkNumber { get; set; }
        public string CardIdUrl { get; set; }
        public string UploadCardIdName { get; set; }
        public string BackUps { get; set; }
        public string Remark { get; set; }
        public string BankName { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public string EmergencyContactShip { get; set; }
    
        public virtual ICollection<FD_PPTWarehouse> FD_PPTWarehouse { get; set; }
        public virtual ICollection<FL_FinishTargetSum> FL_FinishTargetSum { get; set; }
        public virtual ICollection<Sys_ClientManager> Sys_ClientManager { get; set; }
        public virtual Sys_Department Sys_Department { get; set; }
        public virtual Sys_EmployeeJob Sys_EmployeeJob { get; set; }
        public virtual Sys_EmployeeType Sys_EmployeeType { get; set; }
        public virtual Sys_Workgroups Sys_Workgroups { get; set; }
        public virtual ICollection<Sys_EmpLoyeeHigherups> Sys_EmpLoyeeHigherups { get; set; }
    }
}