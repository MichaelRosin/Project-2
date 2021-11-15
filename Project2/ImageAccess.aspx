<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageAccess.aspx.cs" Inherits="Project2.ImageAccess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Access.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style2 {
            width: 207px;
        }
        .auto-style4 {
            width: 279px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style6 {
            width: 279px;
            height: 22px;
        }
        .auto-style7 {
            width: 207px;
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <table class="auto-style5">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="View Image"></asp:Label>
                    <br />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    </asp:GridView>
                </td>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Enter UserID:"></asp:Label>
                    <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Image ID="imgDisplay" runat="server" Height="250px" Width="300px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Metadata"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Image Title:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblImageTitle" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Camera Type:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblCameraType" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Location of Image:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblLocation" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style6"></td>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit Metadata"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label8" runat="server" Text="Image Title:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtImageTitle" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="Camera Type:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCamera" runat="server" Width="170px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="Label10" runat="server" Text="Location: Image:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLocation" runat="server" Width="169px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" CssClass="btnUpload" OnClick="btnUpdate_Click" Text="Update" Width="91px" />
&nbsp;<asp:Button ID="btnDelete" runat="server" CssClass="btnUpload" OnClick="btnDelete_Click" Text="Delete" Width="91px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />

    </div>
        <div>
        </div>
    </form>
</body>
</html>
