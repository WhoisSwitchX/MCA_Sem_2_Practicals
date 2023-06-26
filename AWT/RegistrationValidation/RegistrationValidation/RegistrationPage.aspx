<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="RegistrationValidation.RegistrationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="username" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="username" runat="server" ErrorMessage="Enter username"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="password" TextMode="Password" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="password" runat="server" ErrorMessage="Enter password"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="confirm" TextMode="Password" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="confirm" runat="server" ErrorMessage="*required"></asp:RequiredFieldValidator><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="confirm" ControlToCompare="password" ErrorMessage="Please enter correct password"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="email" TextMode="Email" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="email" runat="server" ErrorMessage="*required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label></td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" GroupName="gender" Text="Male" runat="server" Checked="True" /><asp:RadioButton ID="RadioButton2" GroupName="gender" Checked="false" Text="Female" runat="server" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label6" runat="server" Text="Courses"></asp:Label></td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="C++" />
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Java"/>
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Python"/></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Register"  OnClick="Button1_Click"/>
                    </td>
                </tr>
            </table>
            <asp:Label ID="message" runat="server" ></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="ShowUsernameLabel" runat="server" ></asp:Label></td>
                    <td>
                        <asp:Label ID="ShowUsername" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="ShowEmailLabel" runat="server" ></asp:Label></td>
                    <td>
                        <asp:Label ID="ShowEmail" runat="server" ></asp:Label></td>
                <tr>
                    <td>
                        <asp:Label ID="ShowGenderLabel" runat="server" ></asp:Label></td>
                    <td>
                        <asp:Label ID="ShowGender" runat="server" ></asp:Label></td>
                </tr>
                    <tr>
                    <td>
                        <asp:Label ID="ShowCourseLabel" runat="server" ></asp:Label></td>
                    <td>
                        <asp:Label ID="ShowCourse" runat="server" ></asp:Label></td>
                </tr>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
