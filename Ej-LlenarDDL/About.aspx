<%@ Page Title="Acerca de nosotros" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="Ej_LlenarDDL.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
  <center>
    <h2>Artista</h2>
    <p>
        <asp:DropDownList ID="ddl_Artist" runat="server" 
            onselectedindexchanged="ddl_Artist_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
        <h2>Album</h2>
    <p>
        <asp:DropDownList ID="ddl_Album" runat="server" 
            onselectedindexchanged="ddl_Album_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
        <h2>Track</h2>
    <p>
        <asp:DropDownList ID="ddl_Track" runat="server" 
            onselectedindexchanged="ddl_Track_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    </center>
</asp:Content>
