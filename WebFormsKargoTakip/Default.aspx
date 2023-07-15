<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsKargoTakip._Default" %>



<!DOCTYPE html>
<html>
<head>
    <title>Giriş Ekranı</title>
</head>
<body>
    <form runat="server" style="display: flex; flex-direction: column; align-items: center; justify-content: center; height: 100vh;">
        <div style="text-align: center;">
            <div style="margin-bottom: 10px;">
                <label for="txtUsername">Kullanıcı Adı:</label>
                <br />
                <input type="text" id="txtUsername" runat="server" />
            </div>

            <div style="margin-bottom: 10px;">
                <label for="txtPassword">Şifre:</label>
                <br />
                <input type="password" id="txtPassword" runat="server" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Giriş Yap" OnClick="btnLogin_Click" />

            <br />

            <asp:Label ID="lblErrorMessage" runat="server" CssClass="error-message"></asp:Label>
        </div>
    </form>
</body>
</html>
