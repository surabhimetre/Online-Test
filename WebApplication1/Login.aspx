<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 519px;
            margin-left: 252px;
            height: 294px;
        }
        .auto-style2 {
            position: absolute;
            top: 241px;
            left: 431px;
            z-index: 1;
            width: 168px;
            height: 55px;
            font-size: x-large;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            font-size: xx-large;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style4"><strong>ROBOCON 2K17-18</strong></span><br />
            <br />
            <br />
            <br />
            <span class="auto-style3">NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;</span>&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="272px" Height="34px"></asp:TextBox>
            <br />
            <br />
            <span class="auto-style3">ROBOCON ID :&nbsp;</span>&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="271px" Height="29px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="LOGIN" />
        </div>
    </form>
</body>
</html>
