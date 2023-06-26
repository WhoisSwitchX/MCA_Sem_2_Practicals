<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DisconnectedArch.WebForm1" EnableEventValidation="False" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
        .center-table {
            margin: 0 auto; /* Set left and right margins to auto */
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Disconnected Architecture"></asp:Label>
            
            <br />
            <br />
            <br />
            
            <table align="center" class="center-table auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="City"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <br />
                
            <asp:Button ID="Insert" runat="server" Text="Insert" BackColor="#66FF99" OnClick="Insert_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Update" runat="server" Text="Update" BackColor="#FFFF99" OnClick="Update_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Delete" runat="server" Text="Delete" BackColor="#FF3300" OnClick="Delete_Click" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
            </asp:GridView>
            <br />



        </div>
        </center>
    </form>
</body>
</html>
