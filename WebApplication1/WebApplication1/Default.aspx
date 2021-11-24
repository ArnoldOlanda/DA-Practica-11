<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>Cookies</title>
</head>
<body>
<%--    <style>
        form{
            width:300px;
            height:40vh;
            background-color:gray;
        }
        body{
            display:flex;
            justify-content:center;
            align-items:center;
        }
    </style>
 <form id="form1" runat="server">
 <div>
 <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
 </div>
 </form>--%>
    <form id="form2" runat="server">
     <asp:Label ID="Label2" runat="server" Text="Select Brand
    Preferences"></asp:Label>
     <br />
     <br />
     <asp:CheckBox ID="auriculares" runat="server" Text="Auriculares" />
     <br />
     <asp:CheckBox ID="teclados" runat="server" Text="Teclado TKL" />
     <br />
     <br />
     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit"
    />
     <p>
     <asp:Label ID="Label3" runat="server"></asp:Label>
     </p>
</form>
</body>
</html>

