<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxTreeList.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxTreeList" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="mainForm" runat="server">
        <div>
            <dx:ASPxTreeList ID="ASPxTreeListDemo" runat="server" AutoGenerateColumns="False"
                DataSourceID="AccessDataSourceDemo" ParentFieldName="ReportsTo" KeyFieldName="EmployeeID"
                OnHtmlRowPrepared="ASPxTreeListDemo_HtmlRowPrepared">
                <SettingsSelection Enabled="True" />
                <Columns>
                    <dx:TreeListTextColumn FieldName="LastName" VisibleIndex="0">
                    </dx:TreeListTextColumn>
                    <dx:TreeListTextColumn FieldName="FirstName" VisibleIndex="1">
                    </dx:TreeListTextColumn>
                    <dx:TreeListTextColumn FieldName="Title" VisibleIndex="2">
                    </dx:TreeListTextColumn>
                </Columns>
                <SettingsBehavior AutoExpandAllNodes="True" />
            </dx:ASPxTreeList>
        </div>
        <asp:AccessDataSource ID="AccessDataSourceDemo" runat="server" DataFile="~/App_Data/nwind.mdb"
            SelectCommand="SELECT [EmployeeID], [LastName], [FirstName], [Title], [ReportsTo] FROM [Employees]">
        </asp:AccessDataSource>
    </form>
</body>
</html>
