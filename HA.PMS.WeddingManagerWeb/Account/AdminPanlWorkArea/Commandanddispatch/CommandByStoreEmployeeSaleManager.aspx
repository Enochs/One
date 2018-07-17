﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPanlWorkArea/Master/MainMaster.Master" AutoEventWireup="true" CodeBehind="CommandByStoreEmployeeSaleManager.aspx.cs" Inherits="HA.PMS.WeddingManagerWeb.AdminPanlWorkArea.Commandanddispatch.CommandByStoreEmployeeSaleManager" %>
<%@ Register Assembly="HA.PMS.EditoerLibrary" Namespace="HA.PMS.EditoerLibrary" TagPrefix="cc1" %>
<%@ Register Src="~/AdminPanlWorkArea/Control/MessageBoardforall.ascx" TagPrefix="HA" TagName="MessageBoardforall" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {

            $("#trContent th").css({ "white-space": "nowrap" });
            $(".queryTable td").css({ "border": "0", "vertical-align": "top" });
            $("html").css({ "overflow-x": "hidden" });
            //成功预订率
            matrixing(0, 1, 2, 1);
            //预约率 完成率
            matrixing(3, 4, 5, 100);
            //到店率
            matrixing(6, 7, 8, 1);
        });


        //两个数的结果比例换算 first,second,third 这三个参数是当前tbody元素下面 tr 所对应的下标 
        //multiplication 乘以
        function matrixing(first, second, third, multiplication) {

            var firstTr = $("#tbodyContent tr").eq(first);

            var secondTr = $("#tbodyContent tr").eq(second);

            var thridTr = $("#tbodyContent tr").eq(third);
            firstTr.children("td").each(function (indexs, values) {
                if (indexs >= 2 && indexs <= (2 +<%=ViewState["employeeCount"]%> +2)) {
                           //当前月份计划完成目标
                           var targetMonth = parseFloat($(this).text()) * multiplication;
                           var validMonth = parseFloat(secondTr.children("td").eq(indexs).text()) * multiplication;
                           if (targetMonth == 0) {
                               thridTr.children("td").eq(indexs).text("0 %");
                           } else {
                               var result = (validMonth / targetMonth).toFixed(2);
                               if (result >= 1) {
                                   thridTr.children("td").eq(indexs).text((result * 100).toFixed(2) + " %");
                               } else {
                                   thridTr.children("td").eq(indexs).text(result + " %");
                               }

                           }

                       }
                   });
                   }


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="widget-box">
        <div class="widget-content">
            <div class="widget-box">
                <div class="widget-content">
                    <!---销售跟单员工指挥台  -->
                    <table class="queryTable">
                        <tr>
                            <td>
                                <table>
                                    <tr>
                                        <td>年份: 
                                         <cc1:ddlRangeYear ID="ddlChooseYear" Width="130" yearStar="2013" yearEnd="2020"  runat="server"></cc1:ddlRangeYear>
                                        </td>
                                      
                                        <td>
                                              
                                        月份:
                                            <cc1:ddlMonth ID="ddlChooseMonth" Width="130" runat="server"></cc1:ddlMonth>
                                        </td>
                                        <td></td>
                                        <td>
                                            <asp:Button ID="btnQuery" CssClass="btn btn-primary" OnClick="btnQuery_Click" runat="server" Text="查询" />

                                        </td>
                                    </tr>

                                </table>

                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <table class="table table-bordered table-striped">
                <thead>
                    <tr id="trContent">
                        <th></th>
                        <th></th>
                        <asp:Repeater ID="rptEmployee" runat="server">
                            <ItemTemplate>

                                    <th>
                                        <asp:HiddenField ID="hfEmployee"  Value='<%#Eval("EmployeeID")%>' runat="server" />
                                        <%#Eval("EmployeeName")%>
                                    </th>
                      
                            </ItemTemplate>
                        </asp:Repeater>
                        <th>当年合计</th>
                        <th>上年合计</th>
                        <th>历史累计</th>

                    </tr>
                </thead>
                <tbody id="tbodyContent">
                      <tr>
                        <td>成功预订数</td>
                        
                        <td>计划</td>
                        <%= ViewState["successOrder"]  %>

                    </tr>
                     <tr>
                        <td></td>
                        
                        <td>实际完成</td>
                        <%=ViewState["sbOrderSuccess"] %>

                    </tr>
                     <tr>
                        <td></td>
                        
                        <td>完成率</td>
                        <td></td>
                         <%=ViewState["sbTds"] %>

                    </tr>
                     <tr>
                        <td>预订率</td>
                        
                        <td>计划</td>
                        <%= ViewState["OrderRate"] %>

                    </tr>
                       <tr>
                        <td></td>
                        
                        <td>实际完成</td>
                        <%=ViewState["orderRate"] %>

                    </tr>
                     <tr>
                        <td></td>
                        
                        <td>完成率</td>
                        <td></td>
                          <%=ViewState["sbTds"] %>

                    </tr>
                     <tr>
                        <td>总邀约到店数</td>
                        
                        <td></td>
                        <%=ViewState["sbInviteSuccess"] %>

                    </tr>
                     <tr>
                        <td>实际到店数</td>
                        <td></td>
                        <%=ViewState["validateCount"] %>

                    </tr>
                       <tr>
                        <td>到店率</td>
                        
                        <td></td>
                          <%=ViewState["sbTds"] %>

                    </tr>
                     <tr>
                        <td>定金总额</td>
                        
                        <td></td>
                       <%=ViewState["sbEarnest"]  %>

                    </tr>
                     <tr>
                        <td>总订单额</td>
                        
                        <td></td>
                        <%= ViewState["orderAggregateSuccess"] %>

                    </tr>
                </tbody>
                </table>
            <HA:MessageBoardforall runat="server" ID="MessageBoardforall" />
            </div>
         </div>
</asp:Content>
