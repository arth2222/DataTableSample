<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DataTableSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Denne fylles med data fra en DataTable
            <br />
            <br />
            <asp:TextBox ID="TextBoxSearchTeacher" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSearchTeacher" runat="server" Text="Søk lærer" OnClick="ButtonSearchTeacher_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
