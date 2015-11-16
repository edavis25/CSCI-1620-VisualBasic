<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Contact.aspx.vb" Inherits="CSCI1620Lab9A.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
            width: 550px;
        }
        .auto-style3 {
            font-size: large;
            width: 550px;
        }
        .auto-style4 {
            width: 550px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FFFF">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><strong>Contact Us At</strong></td>
                <td rowspan="4">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Payphone.wmf" />
                </td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: 700" class="auto-style4">Email: Webmaster@rnrbooks.com</td>
            </tr>
            <tr>
                <td style="font-size: medium; font-weight: 700" class="auto-style4">Phone: 1-(800)-555-1111</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Return to R &#39;n R Main Page</asp:HyperLink>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
