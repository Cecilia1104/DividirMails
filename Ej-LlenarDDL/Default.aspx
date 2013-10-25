<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Ej_LlenarDDL._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
<br />
<br />
<asp:DropDownList id ="ddlComputedColumns" runat ="server">
                  <asp:ListItem value ="1"> Juan Valdez</asp:ListItem>
                 </asp:DropDownList>
</asp:Content>
