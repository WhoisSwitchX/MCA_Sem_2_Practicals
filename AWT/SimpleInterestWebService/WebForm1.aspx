﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SimpleInterestWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <table class="auto-style1">
            <tr>
                <td>Enter value of Principal</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter value of Years</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Enter value of ROI</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Calculate Simple Interest" OnClick="Button1_Click" />
                </td>
              
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                
            </tr>
        </table>
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
            </center>
    </form>
</body>
</html>
