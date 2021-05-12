<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="WebApplication1.chat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<asp:TextBox ID="inputText" runat="server"></asp:TextBox>
</br>
<asp:Label ID="name" runat="server" Text="name"></asp:Label>
</br>
<asp:Button ID="sendRtn" runat="server" Text="送出訊息" OnClick="sendRtn_Click" />
    <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick">
    </asp:Timer>
</br>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Label ID="chatResult" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
        </Triggers>
    </asp:UpdatePanel>


</asp:Content>
