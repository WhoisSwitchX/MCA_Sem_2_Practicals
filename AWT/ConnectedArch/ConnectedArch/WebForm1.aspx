<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ConnectedArch.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <table class="auto-style1">
                <tr>
                    <th>
                        <asp:Label ID="Label1" runat="server" Text="Student ID"></asp:Label>
                    </th>
                    <th>
                        <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" TextMode="MultiLine" runat="server" Height="172px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" Height="171px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Show Student Data" OnClick="Button1_Click" /></td>
                    
                </tr>
            </table>
                </center>

        </div>
    </form>
</body>
</html>
