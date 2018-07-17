﻿using System;
using System.Collections.Generic;
using HA.PMS.ToolsLibrary;
using HA.PMS.DataAssmblly;
using HA.PMS.BLLAssmblly.Report;
using System.Web.UI.WebControls;
using HA.PMS.BLLAssmblly.Flow;

namespace HA.PMS.WeddingManagerWeb.AdminPanlWorkArea.QuotedPrice
{
    public partial class QuotedPriceEmployeeManager : HA.PMS.Pages.SystemPage
    {
        BLLAssmblly.Flow.QuotedPrice ObjQuotedPriceBLL = new BLLAssmblly.Flow.QuotedPrice();

        #region 页面加载
        /// <summary>
        /// 页面初始化
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData(sender, e);
            }
        }
        #endregion

        #region 数据绑定
        /// <summary>
        /// 数据绑定
        /// </summary>
        protected void BindData(object sender, EventArgs e)
        {
            if (sender is System.Web.UI.WebControls.Button)
            {
                switch (((System.Web.UI.WebControls.Button)sender).ID.ToLower())
                {
                    case "btnquery": CtrPageIndex.CurrentPageIndex = 1; break;
                }
            }
            List<PMSParameters> objParmList = new List<PMSParameters>();


            //婚礼顾问查询

            if (MyManager.SelectedValue.ToInt32() > 0)
            {
                objParmList.Add("EmployeeID", MyManager.SelectedValue, NSqlTypes.Equal);
            }
            else
            {
                objParmList.Add("EmployeeID", User.Identity.Name.ToInt32(), NSqlTypes.Equal, true);
            }
            //数据页面列表绑定
            objParmList.Add("ParentQuotedID", 0, NSqlTypes.Equal);
            //按订单编号查询
            objParmList.Add(txtOrderCoder.Text.Trim() != string.Empty, "OrderCoder", txtOrderCoder.Text.Trim(), NSqlTypes.LIKE);
            //按婚期查询
            objParmList.Add(QueryDateRanger.IsNotBothEmpty, ddltype.SelectedValue.ToString(), QueryDateRanger.StartoEnd, NSqlTypes.DateBetween);


            objParmList.Add("State", 206, NSqlTypes.NotEquals);
            objParmList.Add("State", 29, NSqlTypes.NotEquals);
            objParmList.Add("IsDelete", false, NSqlTypes.Equal);

            objParmList.Add(ddlHotel.SelectedValue.ToInt32() > 0, "Wineshop", ddlHotel.SelectedItem.Text, NSqlTypes.StringEquals);

            //联系电话
            if (txtCellPhone.Text != string.Empty)
            {
                objParmList.Add("ContactPhone", txtCellPhone.Text, NSqlTypes.StringEquals);
            }
            //新人 姓名(联系人)
            if (txtContactMan.Text != string.Empty)
            {
                objParmList.Add("ContactMan", txtContactMan.Text, NSqlTypes.LIKE);
            }

            int startIndex = CtrPageIndex.StartRecordIndex;
            int SourceCount = 0;
            var query = ObjQuotedPriceBLL.GetByWhereParameter(objParmList, ddltype.SelectedValue.ToString(), CtrPageIndex.PageSize, CtrPageIndex.CurrentPageIndex, out SourceCount);
            repCustomer.DataBind(query);
            CtrPageIndex.RecordCount = SourceCount;
        }
        #endregion


        #region 改派策划师
        /// <summary>
        /// 改派
        /// </summary>
        protected void repCustomer_ItemCommand(object source, System.Web.UI.WebControls.RepeaterCommandEventArgs e)
        {
            int key = (e.CommandArgument + string.Empty).ToInt32();
            int empLoyeeID = e.GetTextValue("hiddeEmpLoyeeID").To<Int32>(User.Identity.Name.To<Int32>(1));

            BLLAssmblly.Flow.QuotedPrice quotedPriceBLL = new BLLAssmblly.Flow.QuotedPrice();
            Report ObjReportBLL = new Report();
            FL_QuotedPrice fL_QuotedPrice = quotedPriceBLL.GetByID(key);
            SS_Report ObjReportModel = ObjReportBLL.GetByCustomerID(fL_QuotedPrice.CustomerID.ToString().ToInt32(), User.Identity.Name.ToInt32());
            switch (e.CommandName)
            {
                case "Save":
                    ObjReportModel.QuotedEmployee = empLoyeeID;
                    ObjReportBLL.Update(ObjReportModel);

                    fL_QuotedPrice.EmpLoyeeID = empLoyeeID;
                    quotedPriceBLL.Update(fL_QuotedPrice);

                    JavaScriptTools.AlertWindow("修改成功", Page);
                    break;
                default: break;
            }
        }
        #endregion

        #region 会员标志
        /// <summary>
        /// 会员标志显示
        /// </summary> 
        protected void repCustomer_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
        {
            Customers ObjCustomersBLL = new Customers();
            Image imgIcon = e.Item.FindControl("ImgIcon") as Image;
            int CustomerID = (e.Item.FindControl("HideCustomerID") as HiddenField).Value.ToString().ToInt32();
            var CustomerModel = ObjCustomersBLL.GetByID(CustomerID);
            if (CustomerModel.IsVip == true)            //该客户是会员
            {
                imgIcon.Visible = true;
            }
            else     //不是会员
            {
                imgIcon.Visible = false;
            }
        }
        #endregion
    }
}