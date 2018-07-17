﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanlWorkArea/Master/PopuMaster.Master" AutoEventWireup="true" CodeBehind="Sys_PlanningCreate.aspx.cs" Inherits="HA.PMS.WeddingManagerWeb.AdminPanlWorkArea.Foundation.FD_Content.Sys_PlanningCreate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">

       $(document).ready(function () {
           $("html,body").css({ "width": "500px", "height": "170px", "background-color": "transparent" });
       });
       $(window).load(function () {
           BindCtrlRegex();
           BindCtrlEvent('input[check],textarea[check]');
           $("#<%=btnSave.ClientID%>").click(function () {
                    return ValidateForm('input[check],textarea[check]');
                });
       });
            function BindCtrlRegex() {
                BindString(20, '<%=txtCategoryName.ClientID%>');
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="widget-box">   
        <div class="widget-content">
            <table class="table table-bordered table-striped" style="width:500px;"> 
                <tr>
                    <td>类别名:</td>
                    <td>
                        <asp:TextBox ID="txtCategoryName" check="1" MaxLength="20" tip="限20个字符！" Width="130" runat="server" />
                        <span style="color:red">*</span>
                    </td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnSave" CssClass="btn btn-success" runat="server" Text="确定" OnClick="btnSave_Click" /></td>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
