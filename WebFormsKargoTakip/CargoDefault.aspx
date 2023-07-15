<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CargoDefault.aspx.cs" Inherits="WebFormsKargoTakip.CargoDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display: flex; justify-content: center; align-items: flex-start;">
            <div style="margin-right: 50px;">
                <asp:Table ID="tblGridView" runat="server">
                    <asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                <h2>Kargo Listesi</h2>
                            </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="SenderName" HeaderText="Gönderici Adı" />
                                    <asp:BoundField DataField="BuyerName" HeaderText="Alıcı Adı" />
                                    <asp:BoundField DataField="Address" HeaderText="Adres" />
                                    <asp:TemplateField HeaderText="Durum">
                                        <ItemTemplate>
                                            <asp:Label ID="lblStatus" runat="server" Text='<%# Convert.ToBoolean(Eval("Status")) ? "True" : "False" %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="İşlemler">
                                        <ItemTemplate>
                                            <asp:Label ID="lblID" runat="server" Text='<%# Eval("ID") %>' Visible="False"></asp:Label>
                                            <asp:Button ID="btnDuzenle" runat="server" Text="Düzenle" CommandName="Duzenle"
                                                CommandArgument='<%# string.Format("{0}|{1}|{2}|{3}|{4}", Eval("ID"), Eval("SenderName"), Eval("BuyerName"),Eval("Address"), Eval("Status")) %>' />
                                            <asp:Button ID="btnSil" runat="server" Text="Sil" CommandName="Sil" CommandArgument='<%# Eval("ID") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
            <div style="margin-right: 50px;">
                
                <asp:Table ID="tblYeniKargo" runat="server">
                    <asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                <h2>Kargo Bilgisi Ekle</h2>
                            </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblSenderName" runat="server" Text="Gönderici Adı:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtNewSenderName" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblBuyerName" runat="server" Text="Alıcı Adı:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtNewBuyerName" runat="server"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblAddress" runat="server" Text="Adres:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:TextBox ID="txtNewAddress" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Label ID="lblStatus" runat="server" Text="Durum:"></asp:Label>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:CheckBox ID="NewchkStatus" runat="server" Text="Aktif" Checked="True"></asp:CheckBox>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow>
                        <asp:TableCell>
                            <asp:Button ID="btnEkle" runat="server" Text="Ekle" OnClick="btnEkle_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
            <div>

                <div style="margin-right: 50px;">
                    <asp:Table ID="tblUpdateCargo" runat="server" Visible="False">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>
                                <h2>Kargo Bilgisi Güncelle</h2>
                            </asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="UCargoID" runat="server" Text='<%# Eval("ID") %>' Visible="False"></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label1" runat="server" Text="Gönderici Adı:"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtUpdateSenderName" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label2" runat="server" Text="Alıcı Adı:"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtUpdateBuyerName" runat="server"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label3" runat="server" Text="Adres:"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:TextBox ID="txtUpdateAddress" runat="server" TextMode="MultiLine" Rows="3"></asp:TextBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Label ID="Label4" runat="server" Text="Durum:"></asp:Label>
                            </asp:TableCell>
                            <asp:TableCell>
                                <asp:CheckBox ID="UpdateCheckbox" runat="server" Text="Aktif" Checked="True"></asp:CheckBox>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
