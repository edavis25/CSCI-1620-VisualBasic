<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="CSCI1620Lab9B._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 74%;
            height: 281px;
            margin-top: 0px;
        }
        .auto-style2 {
            width: 277px;
            text-align: right;
            font-size: medium;
            font-weight: bold;
        }
        .auto-style3 {
            width: 297px;
        }
        .auto-style4 {
            width: 277px;
            text-align: right;
            font-size: medium;
            font-weight: bold;
            height: 26px;
        }
        .auto-style5 {
            width: 297px;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
        }
        .auto-style7 {
            width: 277px;
            text-align: right;
            font-size: medium;
            font-weight: bold;
            height: 23px;
        }
        .auto-style8 {
            width: 297px;
            height: 23px;
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 149px;
            height: 26px;
        }
        .auto-style11 {
            width: 149px;
            text-align: right;
            font-size: large;
            font-weight: 700;
        }
        .auto-style12 {
            width: 149px;
            height: 23px;
            text-align: right;
            font-size: large;
            font-weight: 700;
        }
        .auto-style13 {
            width: 277px;
            text-align: right;
            font-size: medium;
            font-weight: bold;
            height: 28px;
        }
        .auto-style14 {
            width: 297px;
            height: 28px;
        }
        .auto-style15 {
            width: 149px;
            text-align: right;
            font-size: large;
            font-weight: 700;
            height: 28px;
        }
        .auto-style16 {
            height: 28px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" style="background-color: #C0C0C0">
            <tr>
                <td class="auto-style4">Name:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="NameTextBox" runat="server" TabIndex="1" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">Address:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="AddressTextBox" runat="server" TabIndex="2" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">City:</td>
                <td class="auto-style14">
                    <asp:TextBox ID="CityTextBox" runat="server" TabIndex="3" Width="200px"></asp:TextBox>
                </td>
                <td class="auto-style15"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style7">State:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="StateTextBox" runat="server" TabIndex="4" Width="100px"></asp:TextBox>
                </td>
                <td class="auto-style12">Miles Driven:</td>
                <td class="auto-style9">
                    <asp:TextBox ID="MilesDrivenTextBox" runat="server" BackColor="Transparent" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Zip:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="ZipTextBox" runat="server" TabIndex="5" Width="100px"></asp:TextBox>
                </td>
                <td class="auto-style11">Total Price:</td>
                <td>
                    <asp:TextBox ID="TotalPriceTextBox" runat="server" BackColor="Transparent" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Beginning Odometer:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="BeginningOdometerTextBox" runat="server" TabIndex="6" Width="100px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="BeginningOdometerRequiredFieldValidator" runat="server" ControlToValidate="BeginningOdometerTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="BeginningOdometerRangeValidator" runat="server" ControlToValidate="BeginningOdometerTextBox" ErrorMessage="Must be numeric" ForeColor="Red" MaximumValue="9999999" MinimumValue="1" Type="Double"></asp:RangeValidator>
                </td>
                <td class="auto-style11">
                    <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" style="font-size: medium"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ending Odometer:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="EndingOdometerTextBox" runat="server" TabIndex="7" Width="100px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="EndingOdometerRequiredFieldValidator" runat="server" ControlToValidate="EndingOdometerTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="EndingOdometerRangeValidator" runat="server" ControlToValidate="EndingOdometerTextBox" ErrorMessage="Must be numeric" ForeColor="Red" MaximumValue="9999999" MinimumValue="1" Type="Double"></asp:RangeValidator>
                </td>
                <td class="auto-style11">
                    <asp:Button ID="CalculateButton" runat="server" TabIndex="9" Text="Calculate" />
                </td>
                <td>
                    <asp:Button ID="ClearButton" runat="server" CausesValidation="False" TabIndex="10" Text="Clear" Width="80px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Number of Days:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="DaysRentedTextBox" runat="server" TabIndex="8" Width="100px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="DaysRentedRequiredFieldValidator" runat="server" ControlToValidate="DaysRentedTextBox" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="DaysRentedRangeValidator" runat="server" ControlToValidate="DaysRentedTextBox" ErrorMessage="Must be whole number" ForeColor="Red" MaximumValue="9999999" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style6"></td>
            </tr>
        </table>
    
    </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
