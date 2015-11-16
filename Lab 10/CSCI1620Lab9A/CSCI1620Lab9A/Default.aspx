<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="CSCI1620Lab9A._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 59%;
            height: 324px;
        }
        .auto-style2 {
            font-size: large;
            width: 136px;
        }
        .auto-style5 {
            width: 370px;
        }
        .auto-style7 {
            width: 103px;
        }
        .auto-style8 {
            width: 136px;
        }
        .auto-style9 {
            width: 103px;
            height: 26px;
        }
        .auto-style10 {
            width: 136px;
            height: 26px;
        }
        .auto-style11 {
            width: 370px;
            height: 26px;
        }
        .auto-style12 {
            width: 370px;
            font-size: large;
        }
        .auto-style13 {
            width: 103px;
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="background-color: #00FFFF">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style2"><strong>R &#39;n R Book Sales</strong></td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style9" style="font-size: medium; font-weight: 700; text-align: right">Quantity</td>
                <td class="auto-style10">
                    <asp:TextBox ID="QuantityTextBox" runat="server" Width="200px" style="text-align: right"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="QuantityRequiredFieldValidator" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="QuantityRangeValidator" runat="server" ControlToValidate="QuantityTextBox" ErrorMessage="1-100 Only" MaximumValue="100" MinimumValue="1" Type="Integer" ForeColor="Red"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="font-weight: 700; font-size: medium; text-align: right">Title</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TitleTextBox" runat="server" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" style="font-size: medium; font-weight: 700; text-align: right">Price</td>
                <td class="auto-style8">
                    <asp:TextBox ID="PriceTextBox" runat="server" style="text-align: right" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="PriceRequiredFieldValidator" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Required Field" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="PriceRangeValidator" runat="server" ControlToValidate="PriceTextBox" ErrorMessage="Must be numeric" ForeColor="Red" MaximumValue="999999999" MinimumValue="1" Type="Currency"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="font-size: medium; font-weight: 700; text-align: right">Extended Price</td>
                <td class="auto-style8">
                    <asp:TextBox ID="ExtendedPriceTextBox" runat="server" BackColor="Transparent" ReadOnly="True" style="text-align: right" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="font-weight: 700; font-size: medium; text-align: right">15% Discount</td>
                <td class="auto-style8">
                    <asp:TextBox ID="DiscountTextBox" runat="server" BackColor="Transparent" ReadOnly="True" style="text-align: right" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7" style="font-weight: 700; font-size: medium; text-align: right">Discounted Price</td>
                <td class="auto-style8">
                    <asp:TextBox ID="DiscountedPriceTextBox" runat="server" BackColor="Transparent" ReadOnly="True" style="text-align: right" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="DiscountTotalLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">
                    <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
                    <asp:Button ID="ClearButton" runat="server" Text="Clear" Width="64px" />
                    <asp:Button ID="SummaryButton" runat="server" Text="Summary" CausesValidation="False" />
                </td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:HiddenField ID="DiscountTotalHiddenField" runat="server" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style5">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Contact.aspx">Contact Us</asp:HyperLink>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
