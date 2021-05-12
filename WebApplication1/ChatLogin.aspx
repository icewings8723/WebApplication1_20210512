<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChatLogin.aspx.cs" Inherits="WebApplication1.ChatLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="name" runat="server"></asp:TextBox>
    <asp:Label ID="nameLabel" runat="server"></asp:Label>
    </br>
    <asp:TextBox ID="user" runat="server"></asp:TextBox>
    <asp:Label ID="userLabel" runat="server"></asp:Label>
    </br>
    <asp:TextBox ID="passwd" runat="server" TextMode="Password"></asp:TextBox>
    <asp:Label ID="passwdLabel" runat="server"></asp:Label>
    </br>
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />

    <asp:Label ID="LblCount" runat="server" Text="目前使用者:"></asp:Label>
    <asp:Label ID="LabelCount" runat="server" ></asp:Label>
</asp:Content>
