﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextFromDB.aspx.cs" Inherits="DataTableSample.TextFromDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:Label ID="LabelTextFromDB" runat="server" Text="Label"></asp:Label>
            </p>
            <br />
            Du må gjøre det motsatte for å lagre tekst til databasen fra nettsiden her.
            <asp:TextBox ID="TextBoxEdit" runat="server" Height="421px" Width="624px"></asp:TextBox>
            <asp:Button ID="ButtonSave" runat="server" Text="Lagre tekst til DB" />
            

        </div>
    </form>
</body>
</html>