<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="game.aspx.cs" Inherits="WebApplication1.game" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
    <asp:Label ID="LabelWin" runat="server" ></asp:Label>
    </br>
    <asp:Label ID="LabelLose" runat="server" ></asp:Label>
    </br>
    <asp:Label ID="LabelTie" runat="server" ></asp:Label>
    </br>
    <asp:Label ID="final" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    <asp:Label ID="Label1" runat="server" ></asp:Label>
    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000"></asp:Timer>
    </br>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>
    </br>
    <asp:Button ID="ButtonExit" runat="server" Text="Exit" OnClick="ButtonExit_Click" />



</asp:Content>
