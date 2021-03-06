﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RenewInvite.aspx.cs" Inherits="HA.PMS.WeddingManagerWeb.AdminPanlWorkArea.Invite.Customer.RenewInvite" Title="邀约恢复" MasterPageFile="~/AdminPanlWorkArea/Master/MainMaster.Master" %>

<%@ Register Assembly="HA.PMS.ToolsLibrary" Namespace="HA.PMS.ToolsLibrary" TagPrefix="cc1" %>

<%@ Register Assembly="HA.PMS.EditoerLibrary" Namespace="HA.PMS.EditoerLibrary" TagPrefix="cc2" %>


<%@ Register Src="~/AdminPanlWorkArea/Control/MessageBoard.ascx" TagPrefix="uc1" TagName="MessageBoard" %>
<%@ Register Src="~/AdminPanlWorkArea/Control/MessageBoardforall.ascx" TagPrefix="uc1" TagName="MessageBoardforall" %>
<%@ Register Src="~/AdminPanlWorkArea/Control/MyManager.ascx" TagPrefix="uc1" TagName="MyManager" %>




<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="Content1">

    <style type="text/css">
        .centerTxt {
            width: 85px;
            height: 20px;
        }

        .centerSelect {
            width: 98px;
            height: 30px;
        }

        /*小屏幕分辨率*/
        .centerSmallTxt {
            width: 55px;
            height: 20px;
        }

        .centerSmallSelect {
            width: 88px;
            height: 30px;
        }
    </style>
    <script type="text/javascript">

        $(document).ready(function () {
            $("#trContent th").css({ "white-space": "nowrap" });
            $(".queryTable").css("margin-left", "15px");//98    24
            $(".queryTable td").each(function (indexs, values) {
                if (indexs != 4) {
                    $(this).css({ "border": "0", "vertical-align": "middle" }).after("&nbsp;&nbsp;&nbsp;&nbsp;");
                }
                if (indexs == $(".queryTable td").length - 1) {
                    $(this).css("vertical-align", "top");
                }

            });
            $(":text").each(function (indexs, values) {
                $(this).addClass("centerTxt");
            });
            $("select").addClass("centerSelect");

            //
            $("html").css({ "overflow-x": "hidden" });

            if (window.screen.width >= 1280 && window.screen.width <= 1366) {

                $(":text").each(function (indexs, values) {
                    $(this).addClass("centerSmallTxt");
                });
                $("select").addClass("centerSmallSelect");
            }


            $(".popuLoseContent").fancybox({
                'topRatio': 0.2
            });
            $(".popuLoseContent").hover(function () {
                $(this).css({ "color": "#ff0000" });
            }, function () {
                $(this).css({ "color": "#0094ff" });
            });
        });

    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div style="overflow-x: auto;">
        <div class="widget-box">

            <div class="widget-box" style="height: 60px; border: 0px;">
                <table class="queryTable">
                    <tr>
                        <td>渠道类型:</td>
                        <td>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>
                                    <cc2:ddlChannelType ID="ddlChanneltype" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlChanneltype_SelectedIndexChanged" Width="75"></cc2:ddlChannelType>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </td>
                        <td>渠道名称:<cc2:ddlChannelName ID="ddlChannelname" runat="server"></cc2:ddlChannelName>
                        </td>
                        <td>流失原因:<cc2:ddlLoseContent ID="ddlLoseContent" runat="server"></cc2:ddlLoseContent>
                        </td>
                        <td>流失时间:
                                        <cc2:DateEditTextBox runat="server" onclick="WdatePicker();" ID="txtStar"></cc2:DateEditTextBox>
                        </td>
                        <td>到: 
                                        <cc2:DateEditTextBox runat="server" onclick="WdatePicker();" ID="txtEnd"></cc2:DateEditTextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>新人姓名:</td>
                        <td>
                            <asp:TextBox ID="txtName" runat="server" Width="75"></asp:TextBox>
                        </td>
                        <td>联系电话:<asp:TextBox ID="txtCellphone" runat="server" Width="75"></asp:TextBox>
                        </td>
                        <td>
                            <uc1:MyManager runat="server" ID="MyManager" Title="邀约人" />
                        </td>
                        <td>
                            <asp:Button ID="btnSerch" runat="server" CssClass="btn btn-primary" Text="查询" OnClick="btnSerch_Click" />
                            <cc2:btnReload ID="btnReload2" runat="server" />
                        </td>
                    </tr>
                </table>

            </div>
            <table class="table table-bordered table-striped">

                <thead>
                    <tr id="trContent">
                        <th style="white-space: nowrap;">新人姓名</th>
                        <th style="white-space: nowrap;">联系电话</th>
                        <th style="white-space: nowrap;">婚期</th>
                        <th style="white-space: nowrap;">酒店</th>
                        <th style="white-space: nowrap;">来源渠道</th>
                        <th style="white-space: nowrap;">邀约人</th>
                        <th style="white-space: nowrap;">接受日期</th>
                        <th>流失时间</th>
                        <th>流失原因</th>
                        <th>操作</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="repTelemarketingManager" runat="server" OnItemCommand="repTelemarketingManager_ItemCommand">
                        <ItemTemplate>
                            <tr>
                                <td><a target="_blank" href="/AdminPanlWorkArea/Invite/Customer/InviteCommunicationContent.aspx?Sucess=1&OnlyView=1&CustomerID=<%#Eval("CustomerID") %>"><%#Eval("ContactMan") %></a></td>
                                <td><%#Eval("ContactPhone") %></td>
                                <td><%#ShowPartyDate(Eval("PartyDate")) %></td>
                                <td><%#Eval("Wineshop") %></td>
                                <td><%#GetChannelTypeName(Eval("ChannelType")) %></td>
                                <td><%#GetEmployeeName(Eval("InviteEmployee")) %></td>
                                <td><%#ShowShortDate(Eval("CreateDate")) %></td>
                                <td>
                                    <asp:Label runat="server" ID="lblLastFollowDate" Text='<%#ShowShortDate(Eval("LastFollowDate")) %>' />
                                </td>
                                <td>
                                    <%--                                        <a href="/AdminPanlWorkArea/Invite/Customer/InviteCommunicationContent.aspx?CustomerID=<%#Eval("CustomerID") %>&Sucess=1"><%#GetLoseContent(Eval("ContentID")) %></a>--%>
                                    <a class="popuLoseContent " style="text-decoration: underline; color: #0094ff;" href='#Details<%#Eval("CustomerID") %>'><%#GetLoseContent(Eval("ContentID")) %></a>
                                    <div id='Details<%#Eval("CustomerID") %>' style="display: none; width: 250px; width: 250px; text-align: center;">
                                        <span style="font-weight: bold;">流失具体原因说明</span>
                                        <br />
                                        <%#GetLoseContentDetails(Eval("CustomerID")) %>
                                    </div>
                                </td>
                                <td>
                                    <asp:LinkButton ID="ReInvite" Text="恢复邀约" OnClientClick="return confirm('确认恢复该新人到邀约中？')" CommandArgument='<%#Eval("CustomerID") %>' CommandName="ReInvite" CssClass="btn btn-mini btn-primary" runat="server" />
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
                <tfoot>
                    <tr>
                        <td colspan="9" style="text-align: left;">
                            <cc1:AspNetPagerTool ID="CtrPageIndex" AlwaysShow="true" runat="server" OnPageChanged="CtrPageIndex_PageChanged"></cc1:AspNetPagerTool>
                        </td>
                    </tr>
                </tfoot>
            </table>

            <uc1:MessageBoardforall runat="server" ID="MessageBoardforall" />

        </div>
    </div>
</asp:Content>
