<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageShare.aspx.cs" Inherits="Project2.ImageShare" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Image.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 204px;
        }
        .auto-style9 {
            width: 152px;
        }
        .auto-style14 {
            width: 255px;
        }
        .auto-style22 {
            width: 152px;
            height: 22px;
        }
        .auto-style24 {
            width: 255px;
            height: 22px;
        }
        .auto-style25 {
            width: 56px;
        }
        .auto-style26 {
            width: 56px;
            height: 22px;
        }
    </style>
</head>
<body>
  

    
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">
                        <asp:Panel ID="Panel1" runat="server">
                        </asp:Panel>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        <asp:Label ID="Label19" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Upload "></asp:Label>
                        <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Photo"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
            <asp:Label ID="Label2" runat="server" Text="File name: " Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="btnInsert" runat="server" OnClick="Button1_Click" Text="Upload" Width="94px" CssClass="btnUpload" />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        </td>
                    <td class="auto-style26">
                        </td>
                    <td class="auto-style24">
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        </td>
                    <td class="auto-style26">
            <asp:Label ID="Label3" runat="server" Text="UserID:"></asp:Label>
                    </td>
                    <td class="auto-style24"> 
                        <asp:Label ID="lblUserID" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
            <asp:Label ID="Label4" runat="server" Text="Username"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="lblUsername" runat="server"></asp:Label>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblTitleData" runat="server" Text="Metadata" Font-Size="Large"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="lblTest" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblImageTile" runat="server" Text="Image Title: "></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtImageTitle" runat="server" CssClass="txtCameraType"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblCamera" runat="server" Text="Camera Type:"></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtCameraType" runat="server" CssClass="txtCameraType"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblLocation" runat="server" Text="Location Of Image:"></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtImageLocation" runat="server" CssClass="txtCameraType"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style14">
                        <asp:Button ID="btnInsertData" runat="server" CssClass="btnUpload" Text="Insert data" Width="94px" OnClick="btnInsertData_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        <asp:Label ID="lblDeleteTitle" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Delete Photo"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        <asp:Label ID="lblSearchTitle" runat="server" Font-Size="Large" Text="Search By Image Title:"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtDelete" runat="server" CssClass="txtCameraType"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        </td>
                    <td class="auto-style26">
                    </td>
                    <td class="auto-style24">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        <asp:Label ID="lblViewTitle" runat="server" Font-Bold="True" Font-Size="X-Large" Text="View Photo"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        <asp:Label ID="lblView" runat="server" Font-Size="Large" Text="View Photo:"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        <asp:TextBox ID="txtView" runat="server" CssClass="txtCameraType"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <p>
            &nbsp;</p>
        <asp:Image ID="imgDisplay" runat="server" />
    </form>
</body>
</html>
