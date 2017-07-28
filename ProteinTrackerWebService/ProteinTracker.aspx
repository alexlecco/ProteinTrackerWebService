<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProteinTracker.aspx.cs" Inherits="ProteinTrackerWebService.ProteinTracker" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Protein Tracker</title>
    <script type="text/javascript" src="Scripts/jquery-3.1.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="ProteinTracker.asmx" />
            </Services>
        </asp:ScriptManager>
        <h1>Protein Tracker</h1>
        <div>
            <label for="select-user">Select a user</label>
            <select id="select-user"></select>
        </div>
    </form>
</body>
</html>
