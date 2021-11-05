<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project2.Register" %>

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
        
        &nbsp;<h2>Login<img src="User_icon_2.svg.png" alt="Alternate Text" class="auto-style2" /></h2>
        <form runat="server">
            <br />
            <asp:Label Text="Username" CssClass="lblusername" runat="server" />
            <br />
            <asp:Textbox runat="server" CssClass="txtpassword" placeholder="example: WaterFlow123" ID="txtusername" ForeColor="White" />
            <br />
            <asp:Label Text="Password" CssClass="lblpassword" runat="server" TextMode ="Password" />
            <asp:Textbox runat="server" CssClass="txtpassword" placeholder="****************" ID="txtpassword" ForeColor="White" TextMode ="Password"/>
           
           
            <asp:Button Text="Login" CssClass="btnsubmit" runat="server" OnClick="Unnamed4_Click"  />
            <br />
            <asp:Button ID="btnAccess" runat="server" CssClass="btnsubmit" Text="Share Image"  />
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Blue" NavigateUrl="Login.aspx">Don&#39;t have an account?</asp:HyperLink>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtusername" ErrorMessage="Require a Username"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Require a password"></asp:RequiredFieldValidator>
            <br />
        </form>
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <img class="auto-style4" src="cooltext396455928968337.png" /></div>
    </body>
</html>
