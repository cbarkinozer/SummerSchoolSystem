<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SummerSchoolSystem.WebForm1"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <asp:Label for="TxtName" runat="server" Text="Student Name" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtSurname" runat="server" Text="Student SurName" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtNumber" runat="server" Text="Student Number" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtPassword" runat="server" Text="Student Password" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TxtMail" runat="server" Text="Student Mail" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" CssClass="btn btn-info" />
    </form>
</asp:Content>
