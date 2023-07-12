<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PDF.Reader.App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="container">
            <asp:FileUpload id="pdfUpload" runat="server" CssClass="form-control w-50" /> <br /><br />
            <asp:Button ID="pdfUploadBtn" Text="Upload File" runat="server" Width="105px" OnClick="pdfUploadBtn_Click" CssClass="btn btn-primary" /> &nbsp;&nbsp;
            <asp:Button Text="Reset" CssClass="btn btn-warning" runat="server" CausesValidation="false" /> <br /><br />
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </div>
    </main>

</asp:Content>
