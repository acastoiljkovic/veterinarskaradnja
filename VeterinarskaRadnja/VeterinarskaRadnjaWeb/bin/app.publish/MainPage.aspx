<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="VeterinarskaRadnjaWeb.MainPage" %>

<asp:Content ID="Main" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="container">
        <div class="topFrame">
        <div class="titleText">
            <h2 class="welcomeTitle">Welcome</h2>
        </div>
        <div class="rightForm">
            <form runat="server" class="">
                <asp:TextBox runat="server" CssClass="txt" ID="txtSearch" Placeholder="Unesite tekst za pretragu"></asp:TextBox>
                <asp:CheckBox CssClass="checkboxGroup" ID="cbImeKorisnika" runat="server" Text="Ime Korisnika" />
                <asp:CheckBox CssClass="checkboxGroup" ID="cbPrezimeKorisnika" runat="server" Text="Prezime Korisnika" />
                <asp:CheckBox CssClass="checkboxGroup" ID="cbNazivLjubimca" runat="server" Text="Naziv Ljubimca" />
                <asp:Button ID="btnPretrazi" CssClass="btn" Text="Pretrazi" runat="server" OnClick="btnPretrazi_Click" />
            </form>
        </div>
            </div>
        <asp:Table ID="tableResult" runat="server"></asp:Table>
    </div>
</asp:Content>
