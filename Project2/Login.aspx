<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100px;
            height: 100px;
            overflow: hidden;
            top: -5px;
            left: 125px;
            position: absolute;
            bottom: 484px;
        }

        .auto-style3 {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 350px;
            height: 419px;
            padding: 80px 40px;
            box-sizing: border-box;
        }
  
        .auto-style4 {
            width: 585px;
            height: 96px;
        }
  
    </style>
</head>
<body>
    <div class="auto-style1">
        <div class="auto-style1">
    <div class="auto-style3">
        
        &nbsp;<h2>Login/Register<img src="User_icon_2.svg.png" alt="Alternate Text" class="auto-style2" /></h2>
        <form runat="server">
            <br />
            <asp:Label Text="Username" CssClass="lblusername" runat="server" />
            <br />
            <asp:Textbox runat="server" CssClass="txtpassword" placeholder="example: WaterFlow123" ID="txtusername" ForeColor="White" />
            <br />
            <asp:Label Text="Password" CssClass="lblpassword" runat="server" />
            <asp:Textbox runat="server" CssClass="txtpassword" placeholder="****************" ID="txtpassword" ForeColor="White" />
            <asp:Label Text="Email" CssClass="lblemail" runat="server" />
            <asp:Textbox runat="server" CssClass="txtemail" placeholder="example: michael@gmail.com" ID="txtemail" ForeColor="White"  />
           
           
            <asp:Button Text="Sign In" CssClass="btnsubmit" runat="server" OnClick="Unnamed4_Click" />
            <br />
            <asp:Button ID="btnAccess" runat="server" CssClass="btnsubmit" Text="Share Image" OnClick="btnAccess_Click" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Invalid Email Address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" ErrorMessage="Require a Username"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Require a password"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtemail" ErrorMessage="Require email address"></asp:RequiredFieldValidator>
        </form>
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <img class="auto-style4" src="cooltext396455928968337.png" /></div>
</body>
</html>
