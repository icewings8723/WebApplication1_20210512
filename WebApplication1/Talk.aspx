<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Talk.aspx.cs" Inherits="WebApplication1.Talk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
    </br>
    <asp:TextBox ID="inputText" runat="server"></asp:TextBox>
    </br>
    
    </br>
    <asp:Button ID="sendBtn" runat="server" Text="送出訊息" OnClick="sendBtn_Click" />
    </br>

    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/pic/scissors.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/pic/stone.png" OnClick="Button_Click" />
    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/pic/paper.png" OnClick="Button_Click" />
    </br>
    <asp:Label ID="userResult" runat="server"></asp:Label>
    </br>
    <asp:Image ID="computerImage" runat="server" BorderStyle="None" Height="138px" Width="153px" />
    </br>
    <asp:Label ID="computerResult" runat="server"></asp:Label>
    </br>
    <asp:Label ID="final" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </br>
    <asp:Button ID="Logout" runat="server" Text="登出" OnClick="Logout_Click" />
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Timer ID="countTimer" runat="server" Interval="1000" OnTick="countTimer_Tick"></asp:Timer>
      
    
    
      
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="chatResult" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="countTimer" EventName="Tick" />
        </Triggers>
      
    </asp:UpdatePanel>

</asp:Content>
