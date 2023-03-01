<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TextFromDB.aspx.cs" Inherits="DataTableSample.TextFromDB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:Label ID="LabelTextFromDB" runat="server" Text="Label"></asp:Label>
            </h1>

            <p>
                <asp:Label ID="LabelParagraf1" runat="server" Text="Label"></asp:Label>
            </p>
            <br />
            Du må gjøre det motsatte for å lagre tekst til databasen fra nettsiden her. Den store boksen under er et tekstfelt.
            Her kan det skrives noe. Klikker man på lagre, havner det som står i tekstboksen i databasen.
            <br />
            <asp:TextBox ID="TextBoxEditOnPage" Visible="false" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonEdit" Visible="false" runat="server" Text="UPDATE" OnClick="ButtonEdit_Click" />
            <br />
            <br />
            <asp:TextBox ID="TextBoxEdit" TextMode="MultiLine" runat="server" Height="421px" Width="624px"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonSave" runat="server" Text="Lagre tekst til DB" OnClick="ButtonSave_Click" />
            

        </div>
    </form>
</body>
</html>
