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
        .auto-style27 {
            width: 152px;
            height: 88px;
        }
        .auto-style28 {
            width: 56px;
            height: 88px;
        }
        .auto-style29 {
            width: 255px;
            height: 88px;
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
                    <td class="auto-style22">
                        </td>
                    <td class="auto-style26">
                        <asp:Label ID="lblUserAccess" runat="server" Text="Give UserID access:" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        <asp:TextBox ID="txtuserAccess" runat="server" Visible="False"></asp:TextBox>
&nbsp;<asp:Button ID="btnPermission" runat="server" CssClass="btnUpload" OnClick="btnPermission_Click" Text="Grant Permission" Visible="False" />
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
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblTitleData" runat="server" Text="Metadata" Font-Size="Large" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblImageTile" runat="server" Text="Image Title: " Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtImageTitle" runat="server" CssClass="txtCameraType" Visible="False"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblCamera" runat="server" Text="Camera Type:" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtCameraType" runat="server" CssClass="txtCameraType" Visible="False"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                    <asp:Label ID="lblLocation" runat="server" Text="Location Of Image:" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style14">
                    <asp:TextBox ID="txtImageLocation" runat="server" CssClass="txtCameraType" Visible="False"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        &nbsp;</td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style14">
                        <asp:Button ID="btnInsertData" runat="server" CssClass="btnUpload" Text="Insert data" Width="94px" OnClick="btnInsertData_Click" Visible="False" />
                        <asp:Button ID="btnUpdate" runat="server" CssClass="btnUpload" OnClick="btnUpdate_Click" Text="Update" Width="94px" Visible="False" />
                        <asp:Button ID="btnDeleteData" runat="server" CssClass="btnUpload" OnClick="btnDeleteData_Click" Text="Delete" Visible="False" Width="94px" />
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
                        <asp:Label ID="lblDeleteTitle" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Delete Photo" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style27">
                        </td>
                    <td class="auto-style28">
                        <asp:Label ID="lblSearchTitle" runat="server" Font-Size="Large" Text="Search By Image Title:" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style29">
                        <asp:TextBox ID="txtDelete" runat="server" CssClass="txtCameraType" Visible="False"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btnDelete" runat="server" CssClass="btnUpload" OnClick="btnDelete_Click" Text="Delete" Width="94px" Visible="False" />
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
                        <asp:Label ID="lblViewTitle" runat="server" Font-Bold="True" Font-Size="X-Large" Text="View Photo" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style24">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        </td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        </asp:GridView>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
                        <asp:Label ID="lbl1" runat="server" Text="Image Title:" Visible="False"></asp:Label>
                        <asp:Label ID="lblMTitle" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lbl2" runat="server" Text="Camera Type:" Visible="False"></asp:Label>
                        <asp:Label ID="lblCType" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="lbl3" runat="server" Text="Location Of Image:" Visible="False"></asp:Label>
                        <asp:Label ID="lblLImage" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style26">
                        &nbsp;</td>
                    <td class="auto-style24">
        <asp:Image ID="imgDisplay" runat="server" Height="250px" Width="300px" />
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
            </table>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <p>
            &nbsp;&nbsp;</p>
    </form>
</body>
</html>
