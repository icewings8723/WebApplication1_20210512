<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TalkLogin.aspx.cs" Inherits="WebApplication1.TalkLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <div>
            <asp:TextBox ID="name" runat="server" Text="小"></asp:TextBox>
            <br>
            <input type="text" id="user" name="user" value="lccnet" >
            <br>
            <input type="text" id="passwd" name="passwd" value="123456">
            <br>
            <input type="submit" value="Submit">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AccountConnectionString2 %>" SelectCommand="SELECT * FROM [accountInformation]"></asp:SqlDataSource>
            
        </div>
    </form>
</body>
</html>
