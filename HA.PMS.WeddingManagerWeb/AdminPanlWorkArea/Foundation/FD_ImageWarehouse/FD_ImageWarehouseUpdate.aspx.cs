﻿/**
 Version :HaoAi 1.0
 File Name :好爱1.0
 Author:杨洋
 Date:2013.3.19
 Description:公司图片管理修改页面
 History:修改日志

 Author:杨洋
 date:2013.3.19
 version:好爱1.0
 description:修改描述
 
 
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HA.PMS.BLLAssmblly;
using HA.PMS.BLLAssmblly.Flow;
using HA.PMS.ToolsLibrary;
using HA.PMS.Pages;
using HA.PMS.DataAssmblly;
using HA.PMS.BLLAssmblly.FD;
using HA.PMS.BLLAssmblly.Sys;
using HA.PMS.BLLAssmblly.Emnus;
using System.IO;

namespace HA.PMS.WeddingManagerWeb.AdminPanlWorkArea.Foundation.FD_ImageWarehouse
{
    public partial class FD_ImageWarehouseUpdate :SystemPage
    {
        ImageType objImageType = new ImageType();
        ImageWarehouse objImageWarehouseBLL = new ImageWarehouse();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ImageID = Request.QueryString["ImageID"].ToInt32();
                
                DataBinder();
                HA.PMS.DataAssmblly.FD_ImageWarehouse fD_ImageWarehouse = 
                    objImageWarehouseBLL.GetByID(ImageID);
                ddlImageType.Items.FindByValue(fD_ImageWarehouse.ImageTypeId.ToString()).Selected = true;
                txtImageName.Text = fD_ImageWarehouse.ImageTitle;
            }
        }
         
        /// <summary>
        /// 初始化绑定数据源
        /// </summary>
        protected void DataBinder()
        {
            ddlImageType.DataSource = objImageType.GetByAll();
            ddlImageType.DataTextField = "TypeName";
            ddlImageType.DataValueField = "TypeId";
            ddlImageType.DataBind();
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int ImageID = Request.QueryString["ImageID"].ToInt32();
            HA.PMS.DataAssmblly.FD_ImageWarehouse fD_ImageWarehouse =
                  objImageWarehouseBLL.GetByID(ImageID);
            int result = objImageWarehouseBLL.Update(fD_ImageWarehouse);
            fD_ImageWarehouse.ImageTitle = txtImageName.Text;
            fD_ImageWarehouse.ImageTypeId = ddlImageType.SelectedValue.ToInt32();
            
            //根据返回判断添加的状态
            if (result > 0)
            {
                JavaScriptTools.AlertAndClosefancybox("修改成功", this.Page);
            }
            else
            {
                JavaScriptTools.AlertAndClosefancybox("修改失败,请重新尝试", this.Page);

            }
        }
    }
}